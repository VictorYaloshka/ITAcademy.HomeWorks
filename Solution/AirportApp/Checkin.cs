using System;

namespace AirportApp
{
    public class Checkin
    {
        public void Check(out string tempName, out string tempSurname, out string tempFlightNumber)
        {
            Console.Write("Введите пожалуйста Ваше имя: ");
            tempName = Console.ReadLine();

            Console.Write("Введите пожалуйста Вашу фамилию: ");
            tempSurname = Console.ReadLine();

            Console.Write($"Введите пожалуйста номер Вашего рейса: ");
            tempFlightNumber = Console.ReadLine();

            Console.WriteLine($"\nСпасибо. Регистрация на рейс №:{tempFlightNumber} началась.\n");
            Console.WriteLine($"Вылет рейса №:{tempFlightNumber} состоится {DateTime.Now.AddHours(2)}");
            Console.WriteLine($"Проходили ли вы заранее самостоятельную регистрацию?");
        }


        public void GetRegistrationInfo(string tempName, string tempSurname, string tempFlightNumber)
        {
            Console.WriteLine("Выберите один из вариантов и нажмите соответствующую цифру.\n");
            Console.WriteLine("1. Вы проходили регистрацию и у Вас есть посадочный талон");
            Console.WriteLine("2. Вам нужно зарегестрироваться на рейс");

            string temp = Console.ReadLine();
            if (temp.Equals("1"))
            {
                return;
            }
            else if (temp.Equals("2"))
            {
                Console.WriteLine("Предлагаем Вам несколько вариантов регистрации.");
                ChooseRegMethod(tempName, tempSurname, tempFlightNumber);
            }
            else
            {
                Console.WriteLine("\nВведенные данные неверны!");
                GetRegistrationInfo(tempName, tempSurname, tempFlightNumber);
            }
        }


        public void ChooseRegMethod(string tempName, string tempSurname, string tempFlightNumber)
        {
            Console.WriteLine("Выберите один из вариантов и нажмите соответствующую цифру.\n");

            Console.WriteLine("1. Регистрация на стойке регистрации");
            Console.WriteLine("2. Регистрация с помощью киоска самостоятельной регистрации");
            Console.WriteLine("3. Вы можете прямо сейчас зарегистрироваться через наше приложение");

            string temp = Console.ReadLine();
            if (temp.Equals("1"))
            {
                AirportRegistration(tempName, tempSurname, tempFlightNumber);
            }
            else if (temp.Equals("2"))
            {
                Console.WriteLine("Подойдите, пожалуйста, к киоску самостоятельной регистрации");
                SelfCheckInKiosk(tempName, tempSurname, tempFlightNumber);
            }
            else if (temp.Equals("3"))
            {
                Console.WriteLine("Отлично! Просто введите Вашу фамилию ещё раз, чтобы зарегистрироваться на рейс");
                AppRegistration(tempName, tempSurname, tempFlightNumber);
            }
            else
            {
                Console.WriteLine("\nВведенные данные неверны!");
                ChooseRegMethod(tempName, tempSurname, tempFlightNumber);
            }
        }


        public void AirportRegistration(string tempName, string tempSurname, string tempFlightNumber)
        {
            Random random = new Random();
            int terminal = random.Next(1, 100);

            Console.WriteLine($"Пожалуйста, пройдите к стойке регистрации № {terminal}.");
            Console.WriteLine("Предъявите, пожалуйста, паспосрт.");
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine("\nВсё хорошо! Выберите свободное место (с индексом 'F'):");
            GetTicket(tempName, tempSurname, tempFlightNumber);
        }


        public void SelfCheckInKiosk(string tempName, string tempSurname, string tempFlightNumber)
        {
            Console.WriteLine("Введите фамилию в терминал:");
            string surnameCheck = Console.ReadLine();

            if (surnameCheck.Equals(tempSurname))
            {
                Console.WriteLine("Введите номер билета");
                Console.ReadLine();
                Console.WriteLine("\nВсё хорошо! Выберите свободное место (с индексом 'F'):");
                GetTicket(tempName, tempSurname, tempFlightNumber);
            }
            else
            {
                Console.WriteLine("Введены неверные данные!");
                SelfCheckInKiosk(tempName, tempSurname, tempFlightNumber);
            }
        }


        public void AppRegistration(string tempName, string tempSurname, string tempFlightNumber)
        {
            string surnameCheck = Console.ReadLine();

            if (surnameCheck.Equals(tempSurname))
            {
                Console.WriteLine("\nВыберите свободное место (с индексом 'F'):");
                GetTicket(tempName, tempSurname, tempFlightNumber);
            }
            else
            {
                Console.WriteLine("Введены неверные данные!");
                AppRegistration(tempName, tempSurname, tempFlightNumber);
            }
        }


        public void GetTicket(string tempName, string tempSurname, string tempFlightNumber)
        {
            Ticket ticket = new Ticket();
            ticket.SeatGeneration();

            ticket.Name = tempName;
            ticket.Surname = tempSurname;
            ticket.FlightNumber = tempFlightNumber;
            Console.WriteLine("     *******************************");
            Console.WriteLine($"\tИмя: {ticket.Name}\n\tФамилия: {ticket.Surname}\n\tРейс №: {ticket.FlightNumber}\n\tВылет: {DateTime.Now.AddHours(2)}\n\tМесто №: {ticket.Seat}");
            Console.WriteLine("     *******************************");
        }
    }
}
