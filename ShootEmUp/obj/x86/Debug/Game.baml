   M S B A M L   `   `   `  ����D  @ShootEmUp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ShootEmUp	ShootEmUp  5   	       ShootEmUp.Game   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ShootEmUp     5   	   J FXamlAnimatedGif, Version=1.2.3.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5   	   -   5        $��
gameWindow��5	   i     � Title$
  Game��6	   $	��450��6   $	��800��6$    � WindowState$ 	Maximized=�60    � Cursor$
 None��6H    � WindowStyle$
 None=�6V   ��6�   Z�  � 	Resources 5      !   ShootEmUp.NegativeConverter   Negative$   ShootEmUp.LeftCanvasPlayerShip  
LeftCanvas��%:   &	        &	        5   
   6"     5   
   6%   5      .��5      � -   5        $��
gridWindow��5       � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��14* �6   �� 5      $	��15* �6   .+�5   
   r� -   5        $��gamebgmPlayer��5   ;   $y�	Collapsed=�6P    r� LoadedBehavior$ Manual=�6g   6   �� 5   
   -   5        $��superBorder��5      $��1��6$   
�������$��3q�6H   ._�5      �� -   5        $��gameArea��5      $��1��6]   |�. 
���������6%   ��  �� ElementName$ superBorder�� �� Path$ Height�.+�5      �� -   5        $	��bg1��5      
���  ��
	 �� Top$	 0��6�   
 �� Left$
 0��6�   ��62   �� $ gameArea��$ ActualWidth���6k   �� $ gameArea��$ ActualHeight�6�   �� 5      -   5        $	��bg2��5      
��� � �$
 0��6�   ��64   �� $ gameArea��$ ActualWidth���6m   �� $ gameArea��$ ActualHeight�	 6�   �� $ gameArea��$ ActualHeight� �� 	Converter# [  �� 5      -   5        $��playerShipRect��5      
�������$	��109��6?   $��88��6K   
 6W   �� $ gameArea��$ ActualWidth�# [ 	 6�   �� $ gameArea��$ ActualHeight�A� 5      -	   5         A�Name$ explosionAni��5      $y�Visible=�60   
��� ���6E   5      5      �� 5   
   -
   5        $
��void��5      $��32(�6    
�������$��OCR A Extended)�6A   $��0��6]   $��5,0,0,0q�6m   �� 5    
   -   5        $��panelControls��5       $��2��6*   .+�5!      �� -   5        $��scoreTextblock��5!      $��Score: 0��6.   $��32(�6>   
�������$��OCR A Extended)�6_   � 5"      -   5        $��stackpanelGrid��5"      $
��Left=�6g   ��6)   �� $ panelControls��$ ActualWidth� 5#      �� 5$      $
��2.2* �6'   66   �� 5%      6)   �� 5&      6)   �� 5'      6)   �� 5(      $��8* �6'   64   .+�5*      �� -   5        $��damageTextblock��5*   ,   $��0��6   $��Lives:��6C   $��32(�6Q   
�������$��OCR A Extended)�6r   �� 5+      -   5        $��shipIndicator1��5+   r   $��1��6   $/��)/Resources/Graphics/playership_frame1.png��6(   $��26��6[   $��26��6g   6r   �� 5,      -   5        $��shipIndicator2��5,   r   $��2��6   $/��)/Resources/Graphics/playership_frame1.png��6(   $��26��6[   $��26��6g   6r   �� 5-      -   5        $��shipIndicator3��5-   r   $��3��6   $/��)/Resources/Graphics/playership_frame1.png��6(   $��26��6[   $��26��6g   6r   5.      5/      �� 51   
   -   5        $��startingLabel��51   4   $��1��6   $��starting��6$   
�������$��42(�6\   $��OCR A Extdended)�6j   $y�Visible=�6�   $��Center=�6�   $��Center=�6�    �� TextAlignment$ Center=�6�   52      54      