using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                return true;
            }

            else if (c >= 'A' && c <= 'Z')

            {
                return true;
            }

            else

            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //var w = vals.Count();
            //if (w % 2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            
            return (vals.Length % 2 == 0);
                
        }

        public bool IsNumberEven(int number)
        {

            return number % 2 == 0;
            

            
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
           
            
            
            
            
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
               
            if (numbers == null || numbers.Count() == 0)
                {
                    return 0;
                }
               
            var sum = numbers.Min() + numbers.Max();
            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //var x = str1.Length;
            //var y = str2.Length;

            //if (x < y)
            //{
            //    return x;
            //}
            //else
            //{
            //    return y;
            //}

            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
            
            
        }

        public int Sum(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}

            //int sum = numbers.Sum();
            //return sum;

            return numbers?.Sum() ?? 0;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
               return 0;
            }

            var sumOfNumber = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumOfNumber += number;
                }
                
            }
            return sumOfNumber;
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
           if ((numbers == null) || (numbers.Count() == 0))
            {
                return false;
            }
            foreach (var number in numbers)
            {
            int sum = numbers.Sum();
                if (sum % 2 == 0)                 
                {
                    return false;
                }
                
                else 
                { 
                    return true;
                }
            }
            throw new NotImplementedException();


        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {

          if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
            
            throw new NotImplementedException();
        }
    }
}
