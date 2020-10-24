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

        // すべてガターの場合
        [TestMethod()]
        public void allGutterTest()
        {
            for (int i = 0; i < 20; i++)
            {
                game.roll(0);
            }
            Assert.AreEqual(game.score(), 0);
        }

        // すべて1ピンだった場合
        [TestMethod()]
        public void allOneRollTest()
        {
            for (int i = 0; i < 20; i++)
            {
                game.roll(1);
            }
            Assert.AreEqual(game.score(), 20);
        }
    }
}