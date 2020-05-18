using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            TouringBike tbike = new TouringBike();

            // inaccesible due to its protection level:
                // short speed1 = TouringBike.MaxSpeedDefault;
                // short speed2 = TouringBike.MaxSpeedPrivate;
                // short speed3 = TouringBike.MaxSpeedProtected;
                // short speed4 = TouringBike.MaxSpeedProtectedPrivate;
                // short speed5 = Motorcycle.MaxSpeedInternal;
                // short speed6 = Motorcycle.MaxSpeedProtectedIntrnal;

            short speed7 = TouringBike.MaxSpeedPublic;


            // inaccesible due to its protection level:
                // tbike.DisplacementDefault();
                // tbike.DisplacementPrivate();
                // tbike.DisplacementProtected();
                // tbike.DisplacementProtectedPrivate();
                // tbike.DisplacementInternal();
                // tbike.DisplacementProtectedInternal();

            tbike.DisplacementPublic();
        }

    }
}
