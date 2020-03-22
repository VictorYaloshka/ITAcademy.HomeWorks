using System;

namespace HW06.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int arr = array.Length - 1;
            for (int i = 0; i < arr; i++)
            {
                Console.WriteLine($"Enter the value of {i} element of array:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\narray:");
            foreach (int item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\nEnter the position of new element: 0..9");
            Console.Write("id = ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the value of '{id}' element:");
            Console.Write("val = ");
            int val = Convert.ToInt32(Console.ReadLine());

            for (int i = arr-1; i >= id; i--)
            {
                array[i + 1] = array[i];
            }
            array[id] = val;
            Console.WriteLine("\nnew array:");
            foreach (int item in array)
            {
                Console.Write($"{item}\t");
            }
        }
    }
}
