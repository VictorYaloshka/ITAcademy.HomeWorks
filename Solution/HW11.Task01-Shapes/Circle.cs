using log4net;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task01_Shapes
{
    class Circle : Shapes
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Circle));

        internal int Radius { get; set; }

        internal Circle()
        {
            Random random = new Random();
            Radius = random.Next(1, 10);
            Name = "circle";
        }

        internal override void AreaCalculation()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            log.Info($"Area calculation. Figure: {Name}");

        }
    }
}
