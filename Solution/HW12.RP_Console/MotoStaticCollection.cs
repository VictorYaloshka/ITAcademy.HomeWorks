using HW12.RP_Console;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW12.RP_DAL
{
    public class MotoStaticCollection : IMotoRepository
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MotoStaticCollection));

        private static List<Motorcycle> _motorcycles = new List<Motorcycle>()
        {
        new Motorcycle(01, "Neiman Marcus", "Limited Edition Fighter", 2000, 1_000, 11_000_000),
        new Motorcycle(02, "AJS", "E90 Porcupine", 1949, 3_000, 6_000_000),
        new Motorcycle(03, "Ecosse", "Spirit ES1", 2010, 6_000, 4_000_000),
        new Motorcycle(04, "Yamaha", "Roadstar BMS Chopper", 2006, 1_000, 3_000_000),
        };

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            log.Info("Create new motorcycle");

            _motorcycles.Add(motorcycle);
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            log.Info("Get motorcycle by ID");

            return _motorcycles.FirstOrDefault(moto => moto.Id.Equals(id));
        }

        public void GetMotorcycles()
        {
            log.Info("Print all motorcycles");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0,-6}{1,-20}{2,-27}{3,-10}{4,-12}{5}", nameof(Motorcycle.Id), nameof(Motorcycle.Name), nameof(Motorcycle.Model), nameof(Motorcycle.Year), nameof(Motorcycle.Odometer), nameof(Motorcycle.Price));
            Console.ResetColor();
            foreach (Motorcycle item in _motorcycles)
            {
                Console.WriteLine("{0,-6}{1,-20}{2,-27}{3,-10}{4,-12}{5} $",item.Id, item.Name, item.Model, item.Year, item.Odometer, item.Price);
            }
            Console.WriteLine();
        }

  
        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            log.Info("Update motorcycle");

            var newMoto = _motorcycles.FirstOrDefault(moto => moto.Id.Equals(motorcycle.Id));
            newMoto.Name = motorcycle.Name;
            newMoto.Model = motorcycle.Model;
            newMoto.Odometer = motorcycle.Odometer;
            newMoto.Year = motorcycle.Year;
            newMoto.Price = motorcycle.Price;
        }

        public void DeleteMotorcycle(int id)
        {
            log.Info("Delete motorcycle");

            var deletedMotorcycle = _motorcycles.FirstOrDefault(moto => moto.Id.Equals(id));
            _motorcycles.Remove(deletedMotorcycle);
        }
    }
}
