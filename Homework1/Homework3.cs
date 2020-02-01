using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Homework3
    {
        public string[] romanAlphabet = new string[] {"M", "CM", "D", "CD", "C", "XC", "L", "XL","X", "IX", "V","IV", "I" };
        public int[] arabicAlternative = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
         public int[,] SwapDiagonals(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int a = arr[i, i];
                arr[i, i] = arr[i, arr.GetLength(0) - 1 - i];

                arr[i, arr.GetLength(0) - 1 - i] = a;
            }
            return arr;
        }
        public int GetCountOfGreaterX(int[,] arr)
        {
            int count = 0;

            for (int i = 1; i < arr.GetLength(0)-1; i++)
            {
                for (int j = 1; j < arr.GetLength(1)-1; j++)
                {
                    //if (i != 0 && j != 0 && i != arr.GetLength(0)-1 && j != arr.GetLength(1)-1)
                    //{
                        if (arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i + 1, j] && arr[i, j] > arr[i, j+1])
                        {
                            count++;
                        }
                    //}
                }
            }
            return count;
        }
       public int[] SearchDividersAndCount(int a, int b, int c)
        {
            int countd = 0;
            
            for (int i = a; i <= b; i++)
            {
                int count = 0;
                

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count += 1;
                       
                    }
                }

                if (count >= c)
                {
                    countd++;
                    
                }
            }

            int[] result = new int[countd];

            countd = 0;
            for (int i = a; i <= b; i++)
            {
                int count = 0;
                

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count += 1;
                    }
                }

                if (count >= c)
                {
                    result[countd] = i;
                    countd += 1;
                }
            }
            return result;
        }
        public int CountNumeralInArray(int[] arr, int numeral)
        {
                int a;
                int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] > 0)
                {
                    a = arr[i] % 10;

                    if (a == numeral)
                    {
                        count++;

                    }
                    arr[i] /= 10;
                }
            }
            return count;
        }
        public int[] RearrangeInAscendingOrder(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = arr[i], minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }

        public string GetRomanNumber(int number)
        {
            StringBuilder romanNumber = new StringBuilder();
           
            for(int i= 0; i<romanAlphabet.Length; i++)
            {
                while (number>= arabicAlternative[i])
                {
                    romanNumber.Append(romanAlphabet[i]);
                    number -= arabicAlternative[i];
                }

            }

                return romanNumber.ToString(); 
            
        }


    }
}
