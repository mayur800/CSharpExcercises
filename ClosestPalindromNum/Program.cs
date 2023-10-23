using System;

namespace ClosestPalindromNum
{

    class ClosestPalindrome
    {
//Write a C# Sharp program to find the closest palindrome number of an integer.
//If there are two palindrome numbers in absolute distance return the smallest number.
//Original number: 120
//Closest Palindrome number of the said number: 121
        static bool IsPalindrome(int num)
        {
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[numStr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static int FindClosestPalindrome(int num)
        {
            int lowerPalindrome = num - 1;
            int upperPalindrome = num + 1;

            while (true)
            {
                if (IsPalindrome(lowerPalindrome) && IsPalindrome(upperPalindrome))
                {
                    return Math.Min(lowerPalindrome, upperPalindrome);
                }
                else if (IsPalindrome(lowerPalindrome))
                {
                    return lowerPalindrome;
                }
                else if (IsPalindrome(upperPalindrome))
                {
                    return upperPalindrome;
                }

                lowerPalindrome--;
                upperPalindrome++;
            }
        }

        static void Main()
        {
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine($"Original Number:{num}");
                int closestPalindrome = FindClosestPalindrome(num);
                Console.WriteLine($"Closest Palindrome number of the said number: {closestPalindrome}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer!");
            }
            Console.ReadKey();
        }
    }

}
