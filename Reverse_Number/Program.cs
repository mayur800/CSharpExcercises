using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    internal class Program
    {
//Write a C# Sharp program to reverse the digits of a 32-bit signed integer.
//Expected Output:
//Original Integer value: 123456
//Reverse the digits of the said signed integer value:
//654321
        static void Main(string[] args)
        {
            int num1, reverse = 0, rem;
            Console.Write("Enter a number between{0} and {1}: ",int.MinValue,int.MaxValue);
            num1 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Original Integer value:{0}", num1);
            while (num1 != 0)
            {
                rem = num1 % 10;
                reverse = reverse * 10 + rem;
                num1=num1/ 10;
            }
            //Console.WriteLine("Original Integer value:",n);
            Console.Write("Reverse the digits of the said signed integer value :" + reverse);
            
            Console.ReadKey();
        }
    }
}
