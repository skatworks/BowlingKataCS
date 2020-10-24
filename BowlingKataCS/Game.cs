using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataCS
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        /// <summary>
        /// 1投で倒したピンの数
        /// <param name="pins">倒したピンの数</param>
        /// </summary>
        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        /// <summary>
        /// スコア
        /// <returns>スコア</returns>
        /// </summary>
        public int score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (rolls[frameIndex] == 10)
                {
                    score += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (rolls[frameIndex] + rolls[frameIndex + 1] == 10)
                {
                    score += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                } else
                {
                    score += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }
    }
}
