using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using ClassPoStepeniAvtomatistia;

namespace TestProgm
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
            double actual=t.Summ(x, y);
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
    }
}
