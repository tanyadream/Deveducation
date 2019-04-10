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
        
        [Test]
        public void TestPlus1()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(5, 4, 1);
            double eres = 9;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestPlus2()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(0, 0, 1);
            double eres = 0;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestPlus3()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-2, -3, 1);
            double eres = -5;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestPlus4()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(5.4, 7.6, 1);
            double eres = 13;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestPlus5()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-2, 4, 1);
            double eres = 2;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestPlus6()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(2, -4, 1);
            double eres = -2;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestMinus1()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(15, 14, 2);
            double eres = 1;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestMinus2()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(6, -8, 2);
            double eres = 14;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestMinus3()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(9, -9, 2);
            double eres = 18;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestMinus4()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-6, 4, 2);
            double eres = -10;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestMinus5()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(0, 0, 2);
            double eres = 0;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestMinus6()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(0, -1, 2);
            double eres = 1;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestUmn1()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(0, -1, 3);
            double eres = 0;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestUmn2()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(1, 0, 3);
            double eres = 0;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestUmn3()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(2, 3, 3);
            double eres = 6;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestUmn4()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-3, 5, 3);
            double eres = -15;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestUmn5()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-8, -7, 3);
            double eres = 56;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestUmn6()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(10, -12, 3);
            double eres = -120;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestDel1()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(10, -2, 4);
            double eres = -5;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestDel2()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(10, 10, 4);
            double eres = 1;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestDel3()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-15, -3, 4);
            double eres = 5;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestDel4()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(1000, 0, 4);
            double eres = 0;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestDel5()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(0, 500, 4);
            double eres = 0;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestDel6()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-10, -5, 4);
            double eres = 2;
            Assert.AreEqual(fres, eres);

        }
        [Test]
        public void TestSQRT1()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(25, 15, 6);
            double eres = 5;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestSQRT2()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(225, 15, 6);
            double eres = 15;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestSQRT3()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(-36, 15, 6);
            double eres = 6;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestSQRT4()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(900, 15, 6);
            double eres = 30;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestSQRT5()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(0, 15, 6);
            double eres = 0;
            Assert.AreEqual(fres, eres);

        }

        [Test]
        public void TestSQRT6()
        {
            fCalc calc = new fCalc();
            double fres = calc.calculateNew(9, 15, 6);
            double eres = 3;
            Assert.AreEqual(fres, eres);

        }


    }
}
