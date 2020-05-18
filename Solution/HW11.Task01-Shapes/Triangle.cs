using log4net;
using System;

namespace HW11.Task01_Shapes
{
    class Triangle : Shapes
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Triangle));
        internal int Base { get; set; }

        internal Triangle()
        {
            Random random = new Random();
            Base = random.Next(1, 10);

            Name = "triangle";
        }

        internal override void AreaCalculation()
        {
            Area = (Base / 4) * Math.Sqrt(4 * Math.Pow(Base, 2) - Math.Pow(Base, 2));
            log.Info($"Area calculation. Figure: {Name}");
        }
    }
}
