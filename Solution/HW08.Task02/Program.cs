using System;
using System.Collections.Generic;
using System.Linq;

namespace HW08.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Convert.ToString(Console.ReadLine());

            DelLongWord(str);
            ReplaceWords(str);
            NumOfChars(str);
            ArraySort(str);
        }

        static void DelLongWord(string str, int longword = 0, int index = 0)
        {
            List<string> list = str.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > longword)
                {
                    longword = list[i].Length;
                    index = i;
                }
            }
            list.RemoveAt(index);
            Console.WriteLine("\n1. Removing the longest word from a string:");
            foreach (string item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void ReplaceWords(string str, int temp = 0, int maxindex = 0, int minindex = 0)
        {
            List<string> list = str.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > temp)
                {
                    temp = list[i].Length;
                    maxindex = i;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length < temp)
                {
                    temp = list[i].Length;
                    minindex = i;
                }
            }
            
            string buf = string.Empty;
            buf = list[maxindex];
            list[maxindex] = list[minindex];
            list[minindex] = buf;
            Console.WriteLine("\n2. Swap the longest word with the shortest:");
            foreach (string item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        
        static void NumOfChars (string str, int lcount=0, int dcount=0, int pcount=0)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    lcount++;
                }
                else if (char.IsDigit(str[i]))
                {
                    dcount++;
                }
                else if (char.IsPunctuation(str[i]))
                {
                    pcount++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("3. The number of letters: {0}",lcount);
            Console.WriteLine("   The number of digits: {0}", dcount);
            Console.WriteLine("   The number of punctuation marks: {0}", pcount);
        }

        static void ArraySort(string str)
        {
            string[] arr1 = str.Split(' ', ',', '.', ':', '!', '?', ';');
            string temp;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = arr1.Length - 1; j > i; j--)
                {
                    if (arr1[j - 1].Length < arr1[j].Length)
                    {
                        temp = arr1[j - 1];
                        arr1[j - 1] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n4. Sorting words in a string:");
            foreach (string item in arr1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
