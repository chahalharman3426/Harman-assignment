using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGame_Project_asr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_Project_asr.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Shoot instance = new Shoot();
            int u = instance.checkPlayer(1,1);
            if (u == 0)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void Form2Test()
        {
            Shoot instance = new Shoot();
            int u = instance.ShootAwayPlayer(1, 1);
            if (u == 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

    }
}