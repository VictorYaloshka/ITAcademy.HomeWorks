using System;
using System.Diagnostics;

namespace HW06.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] arr = new Int64[100000000];
            Random r = new Random();
            int size = arr.Length - 1;
            Int64 t;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (Int64)(r.Next());
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < size; i++, size--)
            {
                t = arr[i];
                arr[i] = arr[size];
                arr[size] = t;
            }
            stopwatch.Stop();
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Array.Reverse(arr);
            stopwatch2.Stop();
            long milliseconds = stopwatch.ElapsedMilliseconds;
            long milliseconds2 = stopwatch2.ElapsedMilliseconds;
            Console.WriteLine($"My method runtime:\t\t{milliseconds} ms");
            Console.WriteLine($"MicroSoft method runtime:\t{milliseconds2} ms");
        }
    }
}
