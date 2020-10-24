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

        /// <summary>
        /// ストライクを1回含む場合
        /// </summary>
        [TestMethod()]
        public void oneStrikeTest()
        {
            game.roll(10);
            game.roll(3);
            game.roll(4);
            rollMany(18, 0);
            Assert.AreEqual(game.score(), 24);
        }

        /// <summary>
        /// パーフェクトゲームの場合
        /// </summary>
        [TestMethod()]
        public void perfectTest()
        {
            rollMany(12, 10);
            Assert.AreEqual(game.score(), 300);
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