using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            // inaccesible due to its protection level:
                // short speed1 = Motorcycle.MaxSpeedDefault;
                // short speed2 = Motorcycle.MaxSpeedPrivate;
                // short speed3 = Motorcycle.MaxSpeedProtected;
                // short speed4 = Motorcycle.MaxSpeedProtectedPrivate;
                // moto.engineTypeDefault = "";
                // moto.engineTypePrivate = "";
                // moto.engineTypeProtected = "";
                // moto.engineTypeProtectedPrivate = "";

            short speed5 = Motorcycle.MaxSpeedInternal;
            short speed6 = Motorcycle.MaxSpeedProtectedIntrnal;
            short speed7 = Motorcycle.MaxSpeedPublic;
            
            moto.engineTypeInternal = "";
            moto.engineTypeProtectedIntrnal = "";
            moto.engineTypePublic = "";


            // inaccesible due to its protection level:
                // moto.PowerHPtoKwConversionDefault();
                // moto.PowerHPtoKwConversionPrivate();
                // PowerHPtoKwConversionProtected();
                // PowerHPtoKwConversionProtectedPrivate();

            moto.PowerHPtoKwConversionInternal();
            moto.PowerHPtoKwConversionProtectedInternal();
            moto.PowerHPtoKwConversionPublic();

        }
    }
}
