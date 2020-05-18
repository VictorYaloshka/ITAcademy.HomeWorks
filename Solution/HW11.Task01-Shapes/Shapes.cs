using log4net;
using System;

namespace HW11.Task01_Shapes
{
    class Shapes
    {
        internal int Side { get; set; }
        internal double Area { get; set; }
        internal string Name { get; set; }


        internal Shapes()
        {
            Random random = new Random();
            Side = random.Next(1, 10);
        }

        internal virtual void AreaCalculation()
        {
        }
    }
}
