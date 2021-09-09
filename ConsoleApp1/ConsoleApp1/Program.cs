using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; i < 9; i++)
            {
                Console.WriteLine($"{i} - {i * i}");

                Console.ReadKey();
            }
        }
        

    } 
}
