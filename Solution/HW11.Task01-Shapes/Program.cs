using log4net;
using log4net.Config;
using System;

[assembly: XmlConfigurator(ConfigFile = "app.config.xml", Watch = true)]


namespace HW11.Task01_Shapes
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log.Info("Program start");

            Foursquare foursquare = new Foursquare();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            Shapes[] shapes = new Shapes[3];

            shapes[0] = foursquare;
            shapes[1] = circle;
            shapes[2] = triangle;

            foreach (var item in shapes)
            {
                item.AreaCalculation();
                Console.WriteLine($"This is {item.Name}.\tCLR Type is {item.GetType()}.\tSquare is {Math.Round((item.Area), 2)}");
                log.Info($"Output to the console. Figure: {item.Name}");
            }

            log.Info("Program completed successfully");
        }
    }
}
