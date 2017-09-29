using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Game
    {
        public int TotalScore { get; private set; }

        public void Score(int v)
        {
           if(v>0)
                TotalScore += v;
        }
    }
}
