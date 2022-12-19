using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassPoStepeniAvtomatistia;
namespace TestProject
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

            Programs t = new Programs();
            double actual = t.Summ(x, y);
            Assert.AreEqual(except, actual);
        }

    }
}