using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataCS
{
    public class Game
    {
        private int sc = 0;

        public void roll(int pins)
        {
            sc += pins;
        }

        public int score()
        {
            return sc;
        }
    }
}
