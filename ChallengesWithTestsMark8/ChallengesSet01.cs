﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            return (num1 == num2) ? true : false;
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();

            
            return minuend - subtrahend;


        }

        public int Add(int number1, int number2)
        {
            
            return number1 + number2;
            
            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return Math.Min(number1, number2);
            
            
            //throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
           
            
            //throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {

            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else return $"Hello, {nameOfPerson}!";

            //throw new NotImplementedException();
        }

        public string GetHey()
        {
            return ("HEY!");
           // throw new NotImplementedException();
        }
    }
}
