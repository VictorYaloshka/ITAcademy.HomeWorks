using System;

namespace HW05.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90, a = 122; i > 64 & a>96; i--,a--)
            {
                char letter = (char)(int)i;
                char letter2 = (char)(int)a;
                Console.Write(letter);
                Console.WriteLine(letter2);
            }
           
        }
    }
}
