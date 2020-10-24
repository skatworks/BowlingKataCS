using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingKataCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKataCS.Tests
{
    [TestClass()]
    public class GameTests
    {
        private Game game;

        [TestInitialize()]
        public void init()
        {
            game = new Game();
        }

        /// <summary>
        /// すべてガターだった場合
        /// </summary>
        [TestMethod()]
        public void allGutterTest()
        {
            rollMany(20, 0);
            Assert.AreEqual(game.score(), 0);
        }

        /// <summary>
        /// すべて1ピンだった場合
        /// </summary>
        [TestMethod()]
        public void allOneRollTest()
        {
            rollMany(20, 1);
            Assert.AreEqual(game.score(), 20);
        }

        /// <summary>
        /// スペアを1回含む場合
        /// </summary>
        [TestMethod()]
        public void oneSpareTest()
        {
            game.roll(5);
            game.roll(5);
            game.roll(3);
            rollMany(17, 0);
            Assert.AreEqual(game.score(), 16);
        }

        public void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.roll(pins);
            }
        }
    }
}