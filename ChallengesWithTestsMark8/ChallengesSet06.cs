using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || string.IsNullOrEmpty(word))
            {
                return false;
            }

            foreach (var wrd in words)
            {
                if (ignoreCase == true && wrd != null)
                {
                    if (wrd.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                }
                else
                {
                    if (wrd == word)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            {
                if (num < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                {
                    return true;
                }
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;
            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }
                if (uindex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }


        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }
            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }
            return nthElement.ToArray();
        }
    }
}
