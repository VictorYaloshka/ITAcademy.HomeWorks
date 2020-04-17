using System;

namespace HW06.Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Enter the value of {0} elment of array1:", i + 1);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array1:");
            foreach (int item in array1)
            {
                Console.Write($"{item}  ");
            }

            int[] array2 = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rand.Next();
            }
            Console.WriteLine("\narray2:");
            foreach (int item in array2)
            {
                Console.Write($"{item}  ");
            }

            int[] array3 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array3[i] = array1[i] + array2[i];
            }
            Console.WriteLine("\narray3 = array1 + array2:");
            foreach (int item in array3)
            {
                Console.Write($"{item}  ");
            }
        }
    }
}
