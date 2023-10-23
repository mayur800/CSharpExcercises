using System;

class Program
{
    //Write a C# Sharp program to sort a given positive number in
    //descending/ascending order.
    //Descending : Highest to lowest.
    //Ascending : Lowest to highest.
    //Expected Output:
    //Original Number: 134543
    //Descending order of the said number: 544331
    //Ascending order of the said number: 133445
    static void Main(string[] args)
    {
        Console.Write("Enter an integer number: ");
        
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string numberString = number.ToString();

            // Sort the characters in ascending order
            char[] ascendingChars = numberString.ToCharArray();
            Array.Sort(ascendingChars);
            string ascendingResult = new string(ascendingChars);

            // Sort the characters in descending order
            char[] descendingChars = numberString.ToCharArray();
            Array.Sort(descendingChars);
            Array.Reverse(descendingChars);
            string descendingResult = new string(descendingChars);

            Console.WriteLine("Original Number:"+ number);
            Console.WriteLine("Ascending order of the said number: " + ascendingResult);
            Console.WriteLine("Descending order of the said number:" + descendingResult);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        Console.ReadKey();
    }
}
