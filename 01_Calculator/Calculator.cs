using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        public static int Power(int n1, int n2)
        {
            int result = n1;
            for (int i = n2; i > 1; i--)
            {
                result *= n1;
            }
            return result;
        }
        public static int Factorial(int n)
        {
            int sum = n;

            if (n == 0 || n == 1)
            {
                return 1;

            } else {
                for (int i = n; i > 1; i--)
                {
                    sum *= i-1;
                }
                return sum;
            }
            
        }


    }
}