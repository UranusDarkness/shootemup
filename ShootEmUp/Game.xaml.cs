using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ShootEmUp
{
    /// <summary>
    /// Logica di interazione per Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        bool leftmove, rightmove, upmove, downmove;
        List<Rectangle> trashRect = new List<Rectangle>();
        ImageBrush playerShip_frame1 = new ImageBrush();
        ImageBrush playerShip_frame2 = new ImageBrush();
        ImageBrush background1 = new ImageBrush();
        ImageBrush background2 = new ImageBrush();
        ImageBrush explosionanimation = new ImageBrush();
        SoundPlayer explosionPlayer;
        SoundPlayer bulletPlayer;
        SoundPlayer spaceshipHit;
        Random rng = new Random();
        bool gamestarted = false;
        MenuWindow session;

        int oppcount = 100;
        double oppspeed = 3;
        int oppspritecount = 0;
        double playerspeed = 3;
        int limit = 150;
        int score = 0;
        int lives = 4;
        double bulletspeed = 3;
        int countbullets = 0;
        int destroyed = 0;
        int bgspeed = 4;
        int speededitor = 15;

        Rect hitboxPlayer;

        public Game(MenuWindow old)
        {
            InitializeComponent();
            session = old;
            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream s = a.GetManifestResourceStream("ShootEmUp.Resources.SFX.bullet_sfx.wav");
            bulletPlayer = new SoundPlayer(s);
            s = a.GetManifestResourceStream("ShootEmUp.Resources.SFX.ship_explosion.wav");
            explosionPlayer = new SoundPlayer(s);
            s = a.GetManifestResourceStream("ShootEmUp.Resources.SFX.spaceship_hit.wav");
            spaceshipHit = new SoundPlayer(s);

            gameArea.Focus();
            background1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/trybg.png"));
            background2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/trybg.png"));
            bg1.Fill = background1;
            bg2.Fill = background2;

            explosionanimation.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/EnemyExplosion/enemy-explosion-4.png"));
            explosionAni.Fill = explosionanimation;

            playerShip_frame2.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/playership_frame1.png"));
            playerShip_frame1.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/playership_frame2.png"));
            playerShipRect.Fill = playerShip_frame1;
        }

        public void renderGameLoop(object sender, EventArgs e)
        { 
            if (lives == 1)
            {
                CompositionTarget.Rendering -= renderGameLoop;
                countbullets = 5;
                GameOverWindow goverwindow = new GameOverWindow(score, session);
                this.Hide();
                gamebgmPlayer.Stop();
                goverwindow.Show();
            }
            if (destroyed == speededitor)
            {
                destroyed = 0;
                speededitor += 5;
                oppspeed += 0.5;
                bgspeed ++;
                playerspeed += 0.5;
                bulletspeed += 0.5;
            }

            explosionAni.Visibility = Visibility.Collapsed;
            Canvas.SetTop(bg1, Canvas.GetTop(bg1) + bgspeed);
            Canvas.SetTop(bg2, Canvas.GetTop(bg2) + bgspeed);

            if (Canvas.GetTop(bg1) > gameArea.ActualHeight)
                Canvas.SetTop(bg1, Canvas.GetTop(bg2) - bg2.ActualHeight);

            if(Canvas.GetTop(bg2) > gameArea.ActualHeight)
                Canvas.SetTop(bg2, Canvas.GetTop(bg1) - bg1.ActualHeight);


            if (playerShipRect.Fill == playerShip_frame1)  
                playerShipRect.Fill = playerShip_frame2;
            else
                playerShipRect.Fill = playerShip_frame1;

            hitboxPlayer = new Rect(Canvas.GetLeft(playerShipRect), Canvas.GetTop(playerShipRect), playerShipRect.Width, playerShipRect.Height);
            oppcount -= 1;
            scoreTextblock.Text = "Score: " + score;

            if(oppcount < 0)
            {
                enemyGenerator();
                oppcount = limit;
            }

            if (leftmove == true && Canvas.GetLeft(playerShipRect) > 0)
            {
                Canvas.SetLeft(playerShipRect, Canvas.GetLeft(playerShipRect) - playerspeed);
                
            }
            if (rightmove == true && Canvas.GetLeft(playerShipRect) + 90 < gameArea.ActualWidth-20)
            {
                Canvas.SetLeft(playerShipRect, Canvas.GetLeft(playerShipRect) + playerspeed);

            }

            if (upmove == true && Canvas.GetTop(playerShipRect) > 0)
            {
                Canvas.SetTop(playerShipRect, Canvas.GetTop(playerShipRect) - playerspeed);
            }

            if (downmove == true && Canvas.GetTop(playerShipRect) < gameArea.ActualHeight - playerShipRect.ActualHeight - 10)
            {
                Canvas.SetTop(playerShipRect, Canvas.GetTop(playerShipRect) + playerspeed*2);
            }

            foreach (var x in gameArea.Children.OfType<Rectangle>())
            {
                if(x is Rectangle && (string)x.Tag == "shipBullet")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) - bulletspeed);
                    Rect hitBoxBullet = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if (Canvas.GetTop(x) < 0)
                    {
                        trashRect.Add(x);
                        countbullets--;
                    }
                        

                    foreach (var y in gameArea.Children.OfType<Rectangle>())
                    {
                        if (y is Rectangle && (string)y.Tag == "Enemy")
                        {
                            Rect hitBoxEnemy = new Rect(Canvas.GetLeft(y), Canvas.GetTop(y), y.Width, y.Height);

                            if(hitBoxBullet.IntersectsWith(hitBoxEnemy))
                            {             
                                trashRect.Add(x);
                                trashRect.Add(y);
                                explosionAni.Width = y.Width;
                                explosionAni.Height = y.Height;
                                Canvas.SetTop(explosionAni, Canvas.GetTop(y));
                                Canvas.SetLeft(explosionAni, Canvas.GetLeft(y));
                                explosionAni.Visibility = Visibility.Visible;
                                explosionPlayer.Play();
                                destroyed++;
                                countbullets--;
                                score += 30;
                            }
                        }
                    }
                        
                }
                if (x is Rectangle && (string)x.Tag == "Enemy")
                {
                    Canvas.SetTop(x, Canvas.GetTop(x) + oppspeed);

                    if (Canvas.GetTop(x) > gameArea.ActualHeight)
                    {
                        trashRect.Add(x);
                        spaceshipHit.Play();
                        lives--;
                        if(lives > 0)
                        {
                            deleteLifeIcon(lives);
                        }
                    }
                        

                    Rect hitBoxEnemy = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if (hitboxPlayer.IntersectsWith(hitBoxEnemy))
                    {
                        trashRect.Add(x);
                        spaceshipHit.Play();
                        lives--;
                        if(lives>0)
                        {
                            deleteLifeIcon(lives);
                        }
                        
                    }
                        
                }
            }

            foreach  (Rectangle r in trashRect)
            {
                gameArea.Children.Remove(r);
            }
            
        }

        private void deleteLifeIcon(int indicator)
        {
            switch (lives)
            {
                case 1:
                    shipIndicator1.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    shipIndicator2.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    shipIndicator3.Visibility = Visibility.Collapsed;
                    break;
                default:
                    break;
            }
        }

        private void playerKeyDown (object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Left))
            {
                leftmove = true;
            }
            if (Keyboard.IsKeyDown(Key.Right))
            {
                rightmove = true;
            }
            if (e.Key == Key.Up)
            {
                upmove = true;
            }
            if (e.Key == Key.Down)
            {
                downmove = true;
            }
        }

        private void releasePlayerKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                leftmove = false;
            }
            if (e.Key == Key.Right)
            {
                rightmove = false;
            }
            if (e.Key == Key.Up)
            {
                upmove = false;
            }
            if (e.Key == Key.Down)
            {
                downmove = false;
            }

            if (e.Key == Key.Space)
            {
                if(countbullets < 5 && gamestarted)
                {
                    Rectangle bullet = new Rectangle
                    {
                        Tag = "shipBullet",
                        Height = 50,
                        Width = 10,
                        Fill = Brushes.White,
                        Stroke = Brushes.Red
                    };
                    Canvas.SetTop(bullet, Canvas.GetTop(playerShipRect) - bullet.Height);
                    Canvas.SetLeft(bullet, Canvas.GetLeft(playerShipRect) + playerShipRect.Width / 2);
                    gameArea.Children.Add(bullet);
                    bulletPlayer.Play();
                    countbullets++;
                }
                
            }
        }

        private void enemyGenerator()
        {
            ImageBrush enemyShip = new ImageBrush();

            oppspritecount = rng.Next(1, 4);

            switch (oppspritecount)
            {
                case 1:
                        enemyShip.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/enemyship1.png"));
                        break;
                case 2:
                    enemyShip.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/enemyship2.png"));
                    break;
                case 3:
                    enemyShip.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Graphics/enemyship3.png"));
                    break;
                default:
                    break;
            }

            Rectangle newEnemyShip = new Rectangle
            {
                Tag = "Enemy",
                Height = 88,
                Width = 108,
                Fill = enemyShip
            };

            Canvas.SetTop(newEnemyShip, -100);
            Canvas.SetLeft(newEnemyShip, rng.Next(20, (int)gameArea.ActualWidth-(int)newEnemyShip.Width));
            gameArea.Children.Add(newEnemyShip);
        }

        private void gameWindow_KeyDown(object sender, KeyEventArgs e)
        {

            if (Keyboard.IsKeyDown(Key.Escape))
                App.Current.Shutdown();

        }

        private void gameWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.connection.Close();
            App.Current.Shutdown();
        }

        private async void gameWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(playerShipRect, gameArea.ActualHeight-playerShipRect.ActualHeight);
            await Task.Delay(2000);
            this.startingLabel.Visibility = Visibility.Collapsed;
            CompositionTarget.Rendering += renderGameLoop;
            gamebgmPlayer.Source = new Uri(Environment.CurrentDirectory + "/Resources/BGM/play_bgm.mp3");
            gamebgmPlayer.Play();
            gamestarted = true;
        }

        private void bgmPlayer_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.ToString());
        }

        private void bgmPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            gamebgmPlayer.Stop();
            gamebgmPlayer.Play();
        }
    }
}
