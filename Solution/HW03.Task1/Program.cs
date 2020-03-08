using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Implicit conversion");

            Console.Write("Enter 'x' of the sbyte data type (–128..127): ");
            sbyte sb = Convert.ToSByte(Console.ReadLine());
            int i1 = sb;
            float f1 = sb;
            Console.WriteLine($"int x = {i1} \nfloat x = {f1}");

            Console.Write("Enter 'x' of the char data type (single character): ");
            char c = Convert.ToChar(Console.ReadLine());
            int i2 = c;
            float f2 = c;
            Console.WriteLine($"int x = {i2} \nfloat x = {f2}");

            Console.Write("Enter 'x' of the float data type (1.5e-45..3.4e38): ");
            float f = Convert.ToSingle(Console.ReadLine());
            double d3 = f;
            Console.WriteLine($"double x = {d3}");

            Console.WriteLine("\n2. Explicit conversions");

            Console.Write("Enter 'x' of the int data type (–2 147 483 648..2 147 483 647): ");
            int i = Convert.ToInt32(Console.ReadLine());
            byte b4 = (byte)i;
            sbyte sb4 = (sbyte)i;
            short s4 = (short)i;
            Console.WriteLine($"byte x = {b4} \nsbyte x = {sb4} \nshort x = {s4}");

            Console.Write("Enter 'x' of the float data type (1.5e-45..3.4e38): ");
            float fl = Convert.ToSingle(Console.ReadLine());
            sbyte sb5 = (sbyte)fl;
            int i5 = (int)fl;
            char c5 = (char)fl;
            Console.WriteLine($"sbyte x = {sb5} \nint x = {i5} \nchar x = {c5}");

            Console.Write("Enter 'x' of the decimal data type (1.0e-28..7.9e28): ");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            float f6 = (float)d;
            double d6 = (double)d;
            Console.WriteLine($"float x = {f6} \ndouble x = {d6}");

            Console.WriteLine("\n3. Boxing");

            Console.Write("Enter 'x' of the int data type (–2 147 483 648..2 147 483 647): ");
            int i7 = Convert.ToInt32(Console.ReadLine());
            object object1 = i7;
            Console.WriteLine($"boxing object1 = {object1}");
            ushort u7 = (ushort)(int)object1;
            Console.WriteLine($"unboxing object1 to ushort = {u7}");

            Console.Write("Enter 'x' of the bool data type ('true' or 'false'): ");
            bool b8 = Convert.ToBoolean(Console.ReadLine());
            object object2 = b8;
            Console.WriteLine($"boxing object2 = {object2}");
            byte by8 = Convert.ToByte(object2);
            Console.WriteLine($"unboxing object2 to byte = {by8}");

            Console.Write("Enter 'x' of the char data type (single character): ");
            char c9 = Convert.ToChar(Console.ReadLine());
            object object3 = c9;
            Console.WriteLine($"boxing object3 = {object3}");
            int i9 = (int)(char)object3;
            Console.WriteLine($"unboxing object3 to int = {i9}");
        }
    }
}
