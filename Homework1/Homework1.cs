 using System;

namespace Homework
{
   public class Homework1
    {
       public int Add(int a, int b, int c=0)
        {
            return a + b + c; 
        }
        public int Mult(int a, int b, int c = 1)
        {
            return a * b * c;
        }
        public int Factorial(int n )
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
        public double[] CalcCreditSum(int creditAmount, int year, double loanRate)
        {
            int n = creditAmount, y = year;
            double m, s;
            double  p = loanRate;
            p /= 100;
            m = Math.Round((n * p * Math.Pow((1 + p), y)) / (12 * (Math.Pow((1 + p), y) - 1)));
            s = Math.Round(m * 12 * y, 2);
            double[] res = new double[] { m, s };

            return res;
        }
        public double HypotenuseLength(int a, int b)
        {
            double c = Math.Sqrt(a * a + b * b);
            return c;
        }
        public string Equation(int x1,int y1,int x2,int y2)
        {
          
            string op = "+";

            

           int k = (y1 - y2) / (x1 - x2);
           int b = y2 - k * x2;

            if (b < 0)
            {
                op = "-";
                b *= -1;
                return $"y = {k}x {op} {b}";
            }

            return $"y = {k}x {op} {b}";
        }
        public double[] QuadraticEquation(double a, double b, double c)
        {
            double d;
            if (a == 0)
            {

                double[] res= new double[] { }; 
                return res;
            }
            else
            {
                d = b * b - 4 * a * c;
                
                if (d < 0)
                {
                    double[] res= new double[] { }; 
                    return res;
                }
                else if (d == 0)
                {
                    double[] res= new double[1]; 
                    res[0] = (-b + Math.Sqrt(d)) / 2 * a;
                    return res;
                }
                else
                {
                    double[] res = new double[2];
                    res[0] = (-b + Math.Sqrt(d)) / (2 * a);
                    res[1] = (-b - Math.Sqrt(d)) / (2 * a);
                    return res;
                }
            }
        }
        public string WhichQuadrant(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return "The point is in the center";
            }
            else if (x < 0 && y < 0)
            {
                return "The point is in the third quarter";
            }
            else if (x < 0 && y > 0)
            {
                return "The point is in the second quarter";
            }
            else if (x > 0 && y > 0)
            {
                return "The point is in the first quarter";
            }
            else if (x > 0 && y < 0)
            {
                return "The point is in the fourth quarter";
            }
            else if (x == 0 && y > 0)
            {
                return "The point is between fourth and third quarters";
            }
            else if (x == 0 && y < 0)
            {
                return "The point is between first and second quarters";
            }
            else if (x > 0 && y == 0)
            {
                return "The point is between first and fourth quarters";
            }
            else if (x < 0 && y == 0)
            {
                return "The point is between third and second quarters";
            }
            else
            {
                return "Something strange";
            }
        }
        public bool DotAndCircle(int x, int y, int r)
        {

            double res1 = HypotenuseLength(x,y);


            if (res1 < r)
            {
                return true;
            }
            else return false;

        }
        public double FunctionValue(int i)
        {
            
               double Value = -0.23 * Math.Pow(i, 2) + i;
                return Math.Round(Value, 0);
            
        }
        public int SumRes(int n)
        {
            int sumRes = 0;
            while (n > 0)
            {
                sumRes += n % 10;
               
                n = n / 10;
            }
            return sumRes;
        }
        public int MultRes(int n)
        {
            int multRes = 1;
            while (n > 0)
            {
                multRes *= n % 10;
                n = n / 10;
            }
            return multRes;
        }
        public bool Evidence(int n)
        {
            int a = 0;
            for(int i = 1; i <= n; i++)
            {
                a += i;
            }
            int b = n * (n + 1) / 2;
            if (a==b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public bool DivideOrNotDivide(int a, int b)
        {
            return a % b == 0 ? true: false;
        }
    }
}

