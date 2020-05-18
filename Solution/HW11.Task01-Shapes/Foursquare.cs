using log4net;
using System;

namespace HW11.Task01_Shapes
{
    class Foursquare : Shapes
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Foursquare));

        internal Foursquare()
        {
            Name = "foursquare";
        }

        internal override void AreaCalculation()
        {
            Area = Math.Pow(Side, 2);
            log.Info($"Area calculation. Figure: {Name}");
        }
    }
}
