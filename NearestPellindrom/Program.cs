using System;


class PalindromeNumber
{
    static bool IsPalindrome(int num)
    {
        string numStr = num.ToString();
        int left = 0;
        int right = numStr.Length - 1;

        while (left < right)
        {
            if (numStr[left] != numStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    static int FindClosestPalindrome(int num)
    {
        int lowerPalindrome = num - 1;
        int upperPalindrome = num + 1;

        while (true)
        {
            if (IsPalindrome(lowerPalindrome))
                return lowerPalindrome;

            if (IsPalindrome(upperPalindrome))
                return upperPalindrome;

            lowerPalindrome--;
            upperPalindrome++;
        }
    }

    static void Main()
    {
        Console.Write("Enter an integer: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            int closestPalindrome = FindClosestPalindrome(num);
            Console.WriteLine($"The closest palindrome number is: {closestPalindrome}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
