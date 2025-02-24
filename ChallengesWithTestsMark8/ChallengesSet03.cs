using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            // We want to get the sum of the odd numbers in the list numbers
            // Then we check if the sum is an odd number
            if (numbers == null)
            {
                return false;
            }

            List<int> odds = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 1 || number % 2 == -1)
                {
                    odds.Add(number);
                }
            }

            int sum = 0;
            foreach (int odd in odds)
            {
                sum += odd;
            }

            if (sum % 2 == 1 || sum % 2 == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsNumber)
                && password.Any(char.IsUpper)
                && password.Any(char.IsLower);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //  int[] myArray = new int[50];
            // int index = 0;
            var odds = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {

                words[i] = words[i].ToUpper();
            }
        }
    }
}
