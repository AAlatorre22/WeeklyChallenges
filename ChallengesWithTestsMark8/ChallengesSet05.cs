﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
           
            //startNumber++;

            //while (startNumber % n != 0)
            //    {
            //       startNumber ++;
            //    }
            //    return startNumber;

            return ((startNumber / n) +1) * n;

        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //foreach (var business in businesses)
            //{
            //    if (business.TotalRevenue == 0)
            //    {
            //        business.Name = "CLOSED";
            //    }

            //}

            businesses.Where(x => x.TotalRevenue == 0).ToList().ForEach(x => x.Name = "CLOSED");

        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;

            //return numbers == null ? 0 : numbers.Skip(1).Where((item, index) => numbers[index] % 2 == 0).Sum();

        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            foreach (var word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }
            sentence = sentence.Trim();
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();

            for (var i = 3;  i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }
            return everyFourth.ToArray();



        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {

            for (var i = 0; i < nums.Length; i++)
            {
               for (var k = i + 1; k < nums.Length;  k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;


        }
    }
}
