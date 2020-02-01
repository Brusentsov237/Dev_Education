using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class Homework1Tests
    {
        [TestCase(15000, 5, 10, new double[] { 330, 19800 })]
        [TestCase(1000000, 5, 5, new double[] { 19248, 1154880 })]
        public void CalcCreditSumTest(int creditAmount, int year, double loanRate, double[] expected)
        {
            //arrange
            Homework1 hw1 = new Homework1();

            //act
            double[] actual = hw1.CalcCreditSum(creditAmount, year, loanRate);


            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_a2b3c4()
        {
            //arrange
            Homework1 hw1 = new Homework1();

            int a = 2, b = 3, c = 4;
            int expected = 9;

            //act
            int actual = hw1.Add(a,b,c);


            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5,120)]
        [TestCase(1,1)]
        [TestCase(6,720)]
        public void FactorialTest(int n, int expected)
        {
            Homework1 hw1 = new Homework1();


            int actual = hw1.Factorial(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 5)]
        [TestCase(6, 8, 10)]
        [TestCase(9, 12, 15)]
        public void HypotenuseLength(int a, int b, double expected)
        {
            Homework1 hw1 = new Homework1();

           

            double actual = hw1.HypotenuseLength(a,b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Equation_x1_3_y1_5_x2_5_y2()
        {
            Homework1 hw1 = new Homework1();

            int x1 = 3, y1=5, x2=5, y2=3;
            string expected = "y = -1x + 8";

            string actual = hw1.Equation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void QuadraticEquation_a2_b6_c4()
        {
            Homework1 hw1 = new Homework1();

            int a = 2, b = 6, c = 4;
            double[] expected = new double[]{-1, -2};

            double[] actual = hw1.QuadraticEquation(a,b,c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5, 2, false)]
        [TestCase(5, 3, 2, false)]
        [TestCase(4, 6, 8, true)]
        public void DotAndCircleTest(int x, int y, int r, bool expected)
        {
            Homework1 hw1 = new Homework1();

            bool actual = hw1.DotAndCircle(x, y, r);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, true)]
        [TestCase(123, true)]
        public void EvidenceTest(int n, bool expected)
        {
            Homework1 hw1 = new Homework1();

            bool actual = hw1.Evidence(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(120, -3192)]
        [TestCase(121, -3246)]
        [TestCase(122, -3301)]
        [TestCase(123, -3357)]
        [TestCase(124, -3412)]
        public void FunctionValueTest(int n, double expected)
        {
            Homework1 hw1 = new Homework1();

            double actual = hw1.FunctionValue(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 6)]
        [TestCase(234, 9)]
        [TestCase(345, 12)]
        public void SumResTest(int n, int expected)
        {
            Homework1 hw1 = new Homework1();

            int actual = hw1.SumRes(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(123, 6)]
        [TestCase(234, 24)]
        [TestCase(345, 60)]
        public void MultResTest(int n, int expected)
        {
            Homework1 hw1 = new Homework1();

            int actual = hw1.MultRes(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 5, true)]
        [TestCase(3, 2, false)]
        [TestCase(4, 6, false)]
        public void DivideOrNotDivide(int x, int y, bool expected)
        {
            Homework1 hw1 = new Homework1();

            bool actual = hw1.DivideOrNotDivide(x, y);

            Assert.AreEqual(expected, actual);
        }

    }
}