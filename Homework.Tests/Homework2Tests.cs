using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class Homework2Tests
    {
        [TestCase(321, 123)]
        [TestCase(6872, 2786)]
        [TestCase(130, 31)]
        public void ReversChislaTest(int a, int expected)
        {
            Homework2 hw = new Homework2();



            double actual = hw.ReversChisla(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, "/", 2, "2 / 2 = 1")]
        [TestCase(2, "/", 0, "На ноль делить нельзя")]
        [TestCase(5, "/", 2, "5 / 2 = 2,5")]
        public void CalcTest(int a, string sign, int b, string expected)
        {
            Homework2 hw = new Homework2();


            string actual = hw.Calc(a, sign, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] {1})]
        [TestCase(3, new int[] { 1, 1, 2 })]
        [TestCase(5, new int[] { 1, 1, 2, 3, 5 })]
        public void FibonacciTest(int a, int[] expected)
        {
            Homework2 hw = new Homework2();

            int[] actual = hw.Fibonacci(a);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 5 }, new int[] { 5, 3, 2, 1 })]
        [TestCase(new int[] { 4, 1, 2, 3, 5 }, new int[] { 5, 3, 2, 1, 4 })]
        [TestCase(new int[] { 1, 1, 2, 3, 5 }, new int[] { 5, 3, 2, 1, 1 })]
        public void ReversArrTest(int[] arr, int[] expected)
        {
            Homework2 hw = new Homework2();

            int[] actual = hw.ReversArr(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 2, 3, 5 }, 4,  new int[] { 2, 2 })]
        [TestCase(new int[] { 1, 4, 2, 3, 5 }, 5, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 1, 2, 3, 5, 6 }, 6, new int[] { 1, 1, 2 })]
        public void AverageTest(int[] arr, int n, int[] expected)
        {
            Homework2 hw = new Homework2();

            int[] actual = hw.Average(arr, ref n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 1)]
        [TestCase(new int[] { 7, 4, 2, 3, 5 }, 2)]
        [TestCase(new int[] { 67, 34, 9, 3, 5, 6 }, 3)]
        public void MinElemTest(int[] arr, int expected)
        {
            Homework2 hw = new Homework2();

            int actual = hw.MinElem(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 5)]
        [TestCase(new int[] { 7, 4, 2, 3, 5 }, 7)]
        [TestCase(new int[] { 67, 34, 9, 3, 5, 6 }, 67)]
        public void MaxElemTest(int[] arr, int expected)
        {
            Homework2 hw = new Homework2();

            int actual = hw.MaxElem(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 3)]
        [TestCase(new int[] { 7, 4, 2, 3, 5 }, 0)]
        [TestCase(new int[] { 67, 34, 9, 3, 5, 6 }, 0)]
        public void MaxElemIndexTest(int[] arr, int expected)
        {
            Homework2 hw = new Homework2();

            int actual = hw.MaxElemIndex(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 5 }, 5)]
        [TestCase(new int[] { 7, 4, 2, 3, 5 }, 4)]
        [TestCase(new int[] { 67, 34, 9, 3, 5, 6 }, 43)]
        public void SumBetweenMinAndMaxTest(int[] arr, int expected)
        {
            Homework2 hw = new Homework2();

            int actual = hw.SumBetweenMinAndMax(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 2, 3, 5 }, new int[] { 3,5, 2, 2 })]
        [TestCase(new int[] { 1, 4, 2, 3, 5 }, new int[] { 3, 5, 2, 1, 4 })]
        [TestCase(new int[] { 1, 1, 2, 3, 5, 6 }, new int[] { 3, 5, 6, 1, 1, 2 })]
        public void SwapHalfTest(int[] arr, int[] expected)
        {
            Homework2 hw = new Homework2();

            int[] actual = hw.SwapHalf(arr);

            Assert.AreEqual(expected, actual);
        }

        
    }
}
