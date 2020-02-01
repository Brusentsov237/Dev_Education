using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    class Homework3Tests
    {
            Homework3 hw3 = new Homework3();

        public int[,] GetArrayByName(string arrayName)
        {
            switch (arrayName)
            {
                case "matrixInput1":
                    return new int[,] { { 1, 2, 3 },
                                        { 4, 5, 6 },
                                        { 7, 8, 9 } }; 
                case "diagonalExpected1":
                    return new int[,] {{ 3, 2, 1 },
                                       { 4, 5, 6 },
                                       { 9, 8, 7 } };
                case "matrixInput2":
                    return new int[,] { { 1, 2 }, 
                                        { 3, 4 } };
                case "diagonalExpected2":
                    return new int[,] { { 2, 1 }, 
                                        { 4, 3 } };
                case "matrixInput3":
                    return new int[,] { { 1, 5 }, 
                                        { 8, 9 } };
                case "diagonalExpected3":
                    return new int[,] { { 5, 1 }, 
                                        { 9, 8 } };
                default:
                    return new int[,] { };
            }
        }

        [TestCase("matrixInput1", "diagonalExpected1")]
        [TestCase("matrixInput2", "diagonalExpected2")]
        [TestCase("matrixInput3", "diagonalExpected3")]
        //public void MakeDiagonalExchange_Test(int[,] matrix, int[,] expected)
        public void SwapDiagonals_Test(string matrix1Name, string matrix2Name)
        {

            int[,] matrix = GetArrayByName(matrix1Name);
            int[,] expected = GetArrayByName(matrix2Name);

            int[,] actual = hw3.SwapDiagonals(matrix);

            CollectionAssert.AreEqual(expected, actual);
        }

        public static object[] testDataForGetCountOfGreaterX =
        {
                new object[] {
                    new int[,]{{ 14, 23, 13, 14, 75 },
                               { 18, 26, 37, 24, 56 },
                               { 115, 22, 33, 54, 85 }},
                    1,
                },
                new object[] {
                    new int[,] {{ 14, 23, 13, 14, 75 },
                               { 18, 56, 37, 74, 56 },
                               { 115, 22, 33, 54, 85 }},
                    2,
                },
                new object[] {
                    new int[,] {{ 14, 23, 13, 14, 75 },
                               { 18, 56, 37, 74, 56 },
                               { 115, 22, 33, 54, 85 },
                                { 14, 23, 90, 14, 75 },
                               { 18, 56, 37, 74, 56 },
                               { 115, 22, 33, 54, 85 }},
                    5,
                },
        };
        [TestCaseSource("testDataForGetCountOfGreaterX")]
        public void CountOfGreaterXTest(int[,] arr, int expected )
        {

            int actual = hw3.GetCountOfGreaterX(arr);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(10, "X")]
        [TestCase(15, "XV")]
        [TestCase(33, "XXXIII")]
        public void GetRomanNumberTest(int arabicNumber, string romanNumber)
        {
            string actual = hw3.GetRomanNumber(arabicNumber);
            string expected = romanNumber;
            Assert.AreEqual(expected, actual);
        } 
    }
}
