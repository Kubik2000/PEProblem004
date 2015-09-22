using System;
/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99
 * Find the largest palindrome made from the product of two 3-digit numbers.
 * 
 * Create the number supposed palindrome and test it by the rules. The number can be 6 or 5 character long.
 */
namespace PEProblem004
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            int palindromeAdept = 0;
            string possiblePalindrome = "";
            int possiblePalindromeTmp = 0;

            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    possiblePalindromeTmp = i * j;
                    possiblePalindrome = possiblePalindromeTmp.ToString();

                    if (possiblePalindromeTmp > palindromeAdept)
                    {
                        if (possiblePalindrome.Length == 6)
                        {
                            if (possiblePalindrome[0].Equals(possiblePalindrome[5]))
                            {
                                if (possiblePalindrome[1].Equals(possiblePalindrome[4]))
                                {
                                    if (possiblePalindrome[2].Equals(possiblePalindrome[3]))
                                    {
                                        palindromeAdept = possiblePalindromeTmp;
                                    }
                                }
                            }
                        }
                        else if (possiblePalindrome.Length == 5)
                        {
                            if (possiblePalindrome[0].Equals(possiblePalindrome[4]))
                            {
                                if (possiblePalindrome[1].Equals(possiblePalindrome[3]))
                                {
                                    palindromeAdept = possiblePalindromeTmp;
                                }
                            }

                        }
                    }
                }
            }

            string result = palindromeAdept.ToString();

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}
