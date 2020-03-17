using System;

namespace HW03.Task2
{
    class Program
    {
        private static object hh;

        public static int Int32 { get; private set; }

        static void Main(string[] args)
        {
            sbyte a1 = 1;
            SByte a2 = 2;
            Console.WriteLine("{0}\n{1}", a1.GetType(), a2.GetType());
             
            short b1 = 3;
            Int16 b2 = 4;
            Console.WriteLine("{0}\n{1}", b1.GetType(), b2.GetType());

            int c1 = 5;
            Int32 c2 = 6;
            Console.WriteLine("{0}\n{1}", c1.GetType(), c2.GetType());

            long d1 = 7L;
            Int64 d2 = 8L;
            Console.WriteLine("{0}\n{1}", d1.GetType(), d2.GetType());

            byte e1 = 9;
            Byte e2 = 10;
            Console.WriteLine("{0}\n{1}", e1.GetType(), e2.GetType());

            ushort f1 = 11;
            UInt16 f2 = 12;
            Console.WriteLine("{0}\n{1}", f1.GetType(), f2.GetType());
            
            uint g1 = 13U;
            UInt32 g2 = 14U;
            Console.WriteLine("{0}\n{1}", g1.GetType(), g2.GetType());

            ulong h1 = 15Ul;
            UInt64 h2 = 16Ul;
            Console.WriteLine("{0}\n{1}", h1.GetType(), h2.GetType());

            char i1 = 'A';
            Char i2 = 'B';
            Console.WriteLine("{0}\n{1}", i1.GetType(), i2.GetType());

            float j1 = 17F;
            Single j2 = 18F;
            Console.WriteLine("{0}\n{1}", j1.GetType(), j2.GetType());

            double k1 = 18D;
            Double k2 = 19D;
            Console.WriteLine("{0}\n{1}", k1.GetType(), k2.GetType());

            decimal l1 = 19M;
            Decimal l2 = 20M;
            Console.WriteLine("{0}\n{1}", l1.GetType(), l2.GetType());

            bool m1 = true;
            Boolean m2 = false;
            Console.WriteLine("{0}\n{1}", m1.GetType(), m2.GetType());

            string n1 = "Hello";
            String n2 = "World!";
            Console.WriteLine("{0}\n{1}", n1.GetType(), n2.GetType());

            object o1 = i1;
            Object o2 = i2;
            Console.WriteLine();
            Console.WriteLine("{0}\n{1}", o1.GetType(), o2.GetType());
        }
    }
}
