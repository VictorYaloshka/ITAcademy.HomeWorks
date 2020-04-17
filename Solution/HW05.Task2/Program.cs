using System;
using System.Text;

namespace HW05.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In what direction you want to move?");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\t\tW\n\t\t↑\n\tA←\t\t→D\n\t\t↓\n\t\tS");
        link1:
            Console.WriteLine("Please, enter the direction:");
            char move = Convert.ToChar(Console.ReadLine());
            if (move == 'W' || move == 'w')
            {
                Console.WriteLine("You are moving Up");
            }
            else if (move == 'S' || move == 's')
            {
                Console.WriteLine("You are moving Down");
            }
            else if (move == 'A' || move == 'a')
            {
                Console.WriteLine("You are moving Left");
            }
            else if (move == 'D' || move == 'd')
            {
                Console.WriteLine("You are moving Right");
            }
            else
            {
                Console.WriteLine("Invalid character");
                goto link1;
            }
        }
    }
}
