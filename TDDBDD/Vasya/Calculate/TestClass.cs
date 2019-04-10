using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculate
{
    [TestFixture]
    public class TestClassCalc
    {
        [TestCase(5, 4, 9)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -3, -5)]
        [TestCase(5.4, 7.6, 13)]
        [TestCase(-2, 4, 2)]
        [TestCase(2, -4, -2)]
        public void TestPlus(double a, double b, double _exp_res)
        {
            double _fact_res = new fCalc().calculateNew(a, b, 1);
            Assert.AreEqual(_fact_res, _exp_res);
        }

        [TestCase(15, 14, 1)]
        [TestCase(6, -8, 14)]
        [TestCase(9, -9, 18)]
        [TestCase(0, 0, 0)]
        [TestCase(0, -1, 1)]
        [TestCase(-6, 4, -10)]
        public void TestMinus(double a, double b, double _exp_res)
        {
            double _fact_res = new fCalc().calculateNew(a, b, 2);
            Assert.AreEqual(_fact_res, _exp_res);
        }


        [TestCase(0, -1, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(2, 3, 6)]
        [TestCase(-3, 5, -15)]
        [TestCase(-8, -7, 56)]
        [TestCase(10, -12, -120)]
        public void TestMult(double a, double b, double _exp_res)
        {
            double _fact_res = new fCalc().calculateNew(a, b, 3);
            Assert.AreEqual(_fact_res, _exp_res);
        }

        [TestCase(10, -2, -5)]
        [TestCase(10, 10, 1)]
        [TestCase(-15, -3, 5)]
        [TestCase(0, 500, 0)]
        [TestCase(-10, -5, 2)]
        public void TestDiv(double a, double b, double _exp_res)
        {
            double _fact_res = new fCalc().calculateNew(a, b, 4);
            Assert.AreEqual(_fact_res, _exp_res);
        }

       

    }
}