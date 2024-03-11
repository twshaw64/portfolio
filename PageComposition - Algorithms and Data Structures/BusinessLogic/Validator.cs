using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Validator
    {
        public static bool ValidatorCall(string str) // checks whether string is a 'word'
        {
            if (!IsLower(str))
            {
                return false;
            }

            if (!IsAlpha(str))
            {
                return false;
            }

            if (str.Length > 3) //if a string is longer than length 3
            {
                if (CountVowel(str) < 1) //and contains less than 2 vowels
                {
                    return false;
                }
            }
            else if (CountVowel(str) < 0) //if string is shorter than length 3, and contains at least 1 vowel
                                          //check if string length > 3 skips this
            {
                return false;
            }

            if (!AlphaVowels(str))
            {
                return false;
            }

            return true;
        }

        public static bool IsLower(string s) //checks if the string is lower case
        {
            return s.ToLower() == s;
        }

        public static bool IsAlpha(string s) //checks if string only contains letters 
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int check1 = 0;
            int check2 = 0;
            foreach (char c in s)
            {
                check1++;
                if (alpha.Contains(c))
                {
                    check2++;
                }
            }
            if (check1 == check2)
            {
                return true;
            }
            return false;
        }

        public static int CountVowel(string s) //counts amount of vowels in a string
        {
            string vowel = "aeiou";
            int count = 0;
            foreach (char c in s)
            {
                if (vowel.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool AlphaVowels(string s) //check if vowels are in alphabetical order
        {
            string vowel = "aeiou";
            var l = new List<char>();
            foreach (char c in s)
            {
                if (vowel.Contains(c))
                {
                    l.Add(c);
                }
            }
            if (l.SequenceEqual(l.OrderBy(c => c)))
            {
                return true;
            }
            return false;
        }
    }
}