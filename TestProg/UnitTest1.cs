using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassPoStepeniAvtomatistia;


namespace TestProg
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Summ_2_10_return12()
        {
            double x = 2;
            double y = 10;
            double except = 12;

            Program t = new Program();
            double actual = t.Summ(x, y);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void Raz_70_10_return60()
        {
            double x = 70;
            double y = 10;
            double except = 60;

            Program t = new Program();
            double actual = t.Razn(x, y);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void Ymn_7_10_return70()
        {
            double x = 7;
            double y = 10;
            double except = 70;

            Program t = new Program();
            double actual = t.Ymnog(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void Delenie_70_10_return7()
        {
            double x = 70;
            double y = 10;
            double except = 7;

            Program t = new Program();
            double actual = t.Delen(x, y);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void Pow_5_2_return25()
        {
            double x = 5;
            double y = 2;
            double except = 25;

            Program t = new Program();
            double actual = t.POW(x, y);
            Assert.AreEqual(except, actual);
        }



        [TestMethod]
        public void Summ_2_10_return14()
        {
            double x = 2;
            double y = 10;
            double except = 14;

            Program t = new Program();
            double actual = t.Summ(x, y);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void Raz_7_10_return60()
        {
            double x = 7;
            double y = 10;
            double except = 60;

            Program t = new Program();
            double actual = t.Razn(x, y);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void Ymn_7_1_return70()
        {
            double x = 7;
            double y = 1;
            double except = 70;

            Program t = new Program();
            double actual = t.Ymnog(x, y);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void Delenie_7_10_return7()
        {
            double x = 7;
            double y = 10;
            double except = 7;

            Program t = new Program();
            double actual = t.Delen(x, y);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void Pow_5_2_return255()
        {
            double x = 5;
            double y = 2;
            double except = 255;

            Program t = new Program();
            double actual = t.POW(x, y);
            Assert.AreEqual(except, actual);
        }
    }
}