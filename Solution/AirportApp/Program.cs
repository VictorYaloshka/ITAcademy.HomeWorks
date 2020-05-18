using System;
using System.Diagnostics;

namespace AirportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 12)
            {
                Console.Write("Доброе утро, ");
            }
            else if (DateTime.Now.Hour >= 12 & DateTime.Now.Hour < 15)
            {
                Console.Write("Добрый день, ");
            }
            else if (DateTime.Now.Hour >= 15 & DateTime.Now.Hour < 22)
            {
                Console.Write("Добрый вечер, ");
            }
            else
            {
                Console.Write("Доброй ночи, ");
            }


            Console.WriteLine("Вас приветствует аэропорт 'Minsk-1331'!");
            Console.WriteLine("\nЭто приложение поможет Вам виртуально пройти все процедуры,\nсвязанные с регистрацией на рейс и прохождением точек контроля в аэропорту.\n");

            Checkin checkin = new Checkin();
            checkin.Check(out string tempName, out string tempSurname, out string tempFlightNumber);
            checkin.GetRegistrationInfo(tempName, tempSurname, tempFlightNumber);

            Baggage baggage = new Baggage();
            baggage.BaggageCheck(tempName, tempSurname, tempFlightNumber);

            CustomsBorderControl customsBorderControl = new CustomsBorderControl();
            customsBorderControl.СustomsСontrol();
            customsBorderControl.SecurityCheck();

            Console.WriteLine();
            Console.WriteLine("На этом программа завершена. Если желаете повторно запусить приложение, нажмите '1', иначе нажмите любую клавишу");
            string repeat = Console.ReadLine();

            if (repeat.Equals("1"))
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
