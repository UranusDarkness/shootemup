using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootEmUp
{
    class Player
    {
        public string nickname { get; set; }
        public int score { get; set; }

        public Player(string n, int s)
        {
            nickname = n;
            score = s;
        }
    }
}
