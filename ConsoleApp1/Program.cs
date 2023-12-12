using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];
            names[0] = "D";
            names[1] = "Mahesh";
            names[2] = "Manish";
            names[3] = "Chintan";
            
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }
            //for (int i= 0; i < names.Length; i++) 
            //{
            //    Console.WriteLine(names[i]);
            //}
            Console.ReadKey();
        }
    }
}
