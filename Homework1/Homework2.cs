using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Homework2
    {
        public int ReversChisla(int n)
        {
            int res = 0;
            while (n > 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            return res;
        }
        public string Calc(double a, string sign, double b)
        {
            double res;

            switch (sign)
            {
                case ("+"):
                    res = (double)a + (double)b;
                    return $"{a} {sign} {b} = {res}";
                case ("-"):
                    res = (double)a - (double)b;
                    return $"{a} {sign} {b} = {res}";
                case ("/"):
                    if (b != 0)
                    {
                        res = (double)a / (double)b;
                        return $"{a} {sign} {b} = {res}";
                    }
                    else
                    {
                        return "На ноль делить нельзя";
                    }
                case ("*"):
                    res = (double)a + (double)b;
                    return $"{a} {sign} {b} = {res}";
                default:
                    return "";
            }
        }
        public int[] Fibonacci(int n)
        {
            int a = 1, b = 0, c = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                arr[i] = c;
                a = b;
                b = c;
            }
            return arr;
        }
        public int[] ReversArr(int[] arr)
        {
            int[] result = new int[arr.Length];
            int counter = 0;
            for (int i = arr.Length - 1; i >=0; i--)
            {
                
                result[counter] = arr[i];
                counter++;
            }
            return result;

        }
        public int[] Average(int[] arr, ref int n)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {

                sum += arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < sum / n)
                {
                    count++;
                }
            }

            int[] resultArr = new int[count];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < sum / n)
                {
                    resultArr[k] = arr[i];
                    k++;
                }
            }
            n = k;
            return resultArr;
        }
        public int MaxElemIndex(int[] arr)
        {
            int maxElem = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    maxElem = arr[0];
                }
                else
                {
                    if (arr[i] > maxElem)
                    {
                        maxElem = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        public int MinElemIndex(int[] arr)
        {
            int maxElem = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    maxElem = arr[0];
                }
                else
                {
                    if (arr[i] < maxElem)
                    {
                        maxElem = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }
        public int MinElem(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    min = arr[0];
                }
                else
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
            }
            return min;
        }
        public int MaxElem(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    max = arr[0];
                }
                else
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
            }
            return max;
        }
        public int SumBetweenMinAndMax(int[] arr)
        {
            int sum = 0;
            int min = MinElem(arr);
            int max = MaxElem(arr);
            if (MinElemIndex(arr) < MaxElemIndex(arr))
            {
                for (int i = MinElemIndex(arr); i < MaxElemIndex(arr); i++)
                {
                    if (arr[i] < max && arr[i] > min)
                        sum += arr[i];
                }
            }
            else
            {
                for (int i = MaxElemIndex(arr); i < MinElemIndex(arr); i++)
                {
                    if (arr[i] < max && arr[i] > min)
                        sum += arr[i];
                }
            }
            return sum;
        }
        public int[] SwapHalf(int[] arr)
        {
            int l = arr.Length / 2;
            for (int i = 0; i < l; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - l + i];
                arr[arr.Length - l + i] = temp;
            }
            return arr;
        }
        public double CheckRandom(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    count += 1;
                }

            }
            double Count = Convert.ToDouble(arr.Length);
            return count / Count;
        }
        public string CompareForEquality(int a, int b)
        {
            if (a == b)
            {
                return "Congrats!!!";
            }
            else if (a < b)
            {
                return "Загаданное число меньше!!!";
            }
            else
            {
                return "Загаданное число больше!!!";
            }
        }
    }
}
