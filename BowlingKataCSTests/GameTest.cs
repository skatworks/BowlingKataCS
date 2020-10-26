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
    public class GameTest
    {
        private Game game;

        [TestInitialize()]
        public void init()
        {
            game = new Game();
        }

        [TestMethod()]
        public void すべてガターの場合()
        {
            for (int i = 0; i < 20; i++)
            {
                game.roll(0);
            }
            Assert.AreEqual(0, game.getScore());
        }

        [TestMethod()]
        public void すべて1ピンの場合()
        {
            for (int i = 0; i < 20; i++)
            {
                game.roll(1);
            }
            Assert.AreEqual(20, game.getScore());
        }
    }
}