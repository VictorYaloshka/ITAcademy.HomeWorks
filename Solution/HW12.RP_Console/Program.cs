using HW12.RP_DAL;
using log4net;
using log4net.Config;

[assembly: XmlConfigurator(ConfigFile = "app.config", Watch = true)]

namespace HW12.RP_Console
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log.Info("Start of the programm");

            MotoStaticCollection motoStaticCollection = new MotoStaticCollection();

            motoStaticCollection.CreateMotorcycle(new Motorcycle()
            {
                Id = 05,
                Name = "Harley Davidson",
                Model = "Cosmic Starship",
                Year = 2000,
                Odometer = 2_000,
                Price = 2_000_000
            });

            motoStaticCollection.GetMotorcycleByID(05);

            motoStaticCollection.GetMotorcycles();

            motoStaticCollection.UpdateMotorcycle(new Motorcycle()
            {
                Id = 02,
                Name = "Dodge",
                Model = "Tomahawk",
                Year = 1995,
                Odometer = 300,
                Price = 550_000
            });

            motoStaticCollection.DeleteMotorcycle(04);

            motoStaticCollection.GetMotorcycles();

            log.Info("End of the programm");
        }
    }
}
