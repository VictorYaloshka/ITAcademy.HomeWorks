using System;

namespace HW08.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter a poem:");
            string str = Convert.ToString(Console.ReadLine());
            str = str.Replace("О", "А");
            string[] array1 = str.Split(';');

            Console.WriteLine();
            Console.WriteLine("The poem after formatting:");
            foreach (string item in array1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
