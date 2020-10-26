using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataCS
{
    public class Game
    {
        private int score = 0;
        public void roll(int pins)
        {
            score += pins;
        }

        public int getScore()
        {
            return score;
        }
    }
}
