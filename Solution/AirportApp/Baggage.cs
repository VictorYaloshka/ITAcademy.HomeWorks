using System;

namespace AirportApp
{
    class Baggage
    {
        const int MaxBaggage = 25;
        const int SurchargeRatio = 3;

        public void BaggageCheck(string tempName, string tempSurname, string tempFlightNumber)
        {

            Console.WriteLine("\nЕсть ли у Вас багаж?");
            Console.WriteLine("1. Да\n2. Нет");
            string answer = Console.ReadLine();

            if (answer.Equals("1"))
            {
                Console.WriteLine("Поставьте багаж на ленту транспортера. Eго взвесят и наклеят багажную бирку.");
                Console.WriteLine("Нажмите на любую клавишу.");
                Console.ReadKey();
                Console.WriteLine();
                GetBaggageWeight();

            }
            else if (answer.Equals("2"))
            {
                return;
            }
            else
            {
                Console.WriteLine("Введено неверное значение!");
                BaggageCheck(tempName, tempSurname, tempFlightNumber);
            }
        }


        public void GetBaggageWeight()
        {
            Random random = new Random();
            int currentWeight = random.Next(15, 40);
            Console.WriteLine($"Вес вашего багажа составляет: {currentWeight} кг.");

            if (currentWeight <= MaxBaggage)
            {
                BaggageNumber();
            }
            else
            {
                Console.WriteLine($"Максимально допустимый вес багажа {MaxBaggage} кг.");

                int baggageDifference = currentWeight - MaxBaggage;
                int surcharge = baggageDifference * SurchargeRatio;

                Console.WriteLine($"Вам придётся доплатить {surcharge}$ за превышение нормы.");
                BaggageNumber();
            }
        }


        public void BaggageNumber()
        {
            Console.WriteLine("\nНажмите на любую клавишу, чтобы получить багажную бирку.\n");
            Console.ReadKey();
            Random random = new Random();
            int baggageNumber = random.Next(1000, 10000);

            Console.WriteLine("     *******************************");
            Console.WriteLine($"\tНомер багажа: BN{baggageNumber}");
            Console.WriteLine("     *******************************");
            Console.WriteLine();
        }
    }
}
