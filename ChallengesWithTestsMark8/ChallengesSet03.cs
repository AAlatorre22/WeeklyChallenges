using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            // My way ***

            //if (vals.Contains(false))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            // refactored ***

            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //My Way ***

            //if (numbers == null)
            //{
            //    return false;
            //}

            //var sumOdds = 0;
            //foreach (var number in numbers)
            //{
            //    if (number % 2 != 0)
            //    {
            //        sumOdds += number;
            //    }
            //}
            //if (sumOdds % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //Jeremy way ***

            //var odds = new List<int>();

            //foreach (var num in numbers)
            //{
            //    if (num % 2 != 0)
            //    {
            //        odds.Add(num);
            //    }
            //}

            //var sumOdds = odds.Sum();
            //return (sumOdds % 2 != 0);

            // Refactored ***

            return (numbers == null) ? false : numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;

        }


        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            return (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit));
           
        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0];

            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {

            //return (val[val.Length - 1]);

            //return val.Last();

            return val[^1];


        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            // My way ***

            //if (divisor == 0)
            //{
            //    return 0;
            //}
            //return dividend / divisor;

            //Refactored ***

            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            // My way ***

            //return nums[nums.Length - 1] - nums[0];

            // Refactored ***

            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {

            //My way ***

            //var oddsList = new List<int>();

            //for (var i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        oddsList.Add(i);
            //    }
            //}

            //return oddsList.ToArray();


            // Refactored

            return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
            

