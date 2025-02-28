﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            //var sum = 0;

            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        sum += num;
            //    }
            //    else
            //    {
            //        sum -= num;
            //    }
            //}

            //return sum;

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
            

            
        }
            

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            //return list.Min();

            return new List<string> { str1, str2, str3, str4 }.Min(x => x.Length);


        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //var list = new List<int>() { number1, number2, number3, number4 };
            //return list.Min();

            return new List<int> { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return  (
                sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1
                );
        }

        public bool IsStringANumber(string input)
        {
            //var isNumber = double.TryParse(input, out var number);
            //return isNumber;

            return double.TryParse(input, out var result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //var amount = objs.Length;
            //var majority = (amount / 2) + 1;

            //var count = 0;

            //foreach ( var obj in objs )
            //{
            //    if (obj == null)
            //    {
            //        count++;
            //    }
            //}
            //return count >= majority;

            return Convert.ToDouble(objs.Where(x => x == null).Count()) / Convert.ToDouble(objs.Length) > .5;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            int count = 0;

            if (numbers == null)
                return 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            //var fact = 1;
            //if (number < 0)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}

            //for (int i = number; i > 0; i--)
            //{
            //    fact *= i;

            //}
            //return fact;

            return (number == 0) ? 1 : Enumerable.Range(1, number).Aggregate((f, s) => f * s);
        }
    }
}
