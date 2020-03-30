using System;
using System.Text;

namespace HW08.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!!.. 4.!.?6 7! ..?";
            char ch = '?';
            int index = str.IndexOf(ch);

            StringBuilder sb = new StringBuilder(str);
            Console.WriteLine($"Original string:\t{sb}");

            for (int i = 0; i < index; i++)
            {
                if (sb[i]=='!'|| sb[i]=='.')
                {
                    sb = sb.Remove(i, 1);
                    index--;
                    i--;
                }
            }

            string str2 = sb.ToString();
            int index2 = str2.IndexOf(ch);
            for (int i = index2; i < sb.Length; i++)
            {
                sb = sb.Replace(' ', '_',i,1);
            }

            Console.WriteLine($"String after formating:\t{sb}");
        }
    }
}
