using System;
using System.Text.RegularExpressions;

namespace AirportApp
{
    public class Ticket
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FlightNumber { get; set; }
        public string Seat { get; set; }

        public Ticket()
        {
        }

        public void SeatGeneration()
        {
            Console.WriteLine();
            object[,] planeSeat = new object[5, 26];
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 25; j++)
                {
                    planeSeat[i, j] = 'F';
                }
            }

            Random random = new Random();
            int num = random.Next(0, 98);

            for (int a = 0; a < num; a++)
            {
                int i = random.Next(0, 3);
                int j = random.Next(1, 25);
                planeSeat[i, j] = 'x';
            }
            Console.WriteLine();

            for (int i = 4; i < 5; i++)
            {
                for (int j = 0; j <= 25; j++)
                {
                    planeSeat[i, j] = j;
                }
            }

            planeSeat[0, 0] = 'A';
            planeSeat[1, 0] = 'B';
            planeSeat[2, 0] = 'C';
            planeSeat[3, 0] = 'D';
            planeSeat[4, 0] = '\\';

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 25; j++)
                {
                    Console.Write("{0,4}", planeSeat[i, j]);
                }
                Console.WriteLine();
            }

            Console.Write("\nМесто №: ");

            placeNumber(planeSeat);
        }

        public void placeNumber(object[,] planeSeat)
        {
            string passengerSeat = Console.ReadLine();
            Regex regex = new Regex("^[A-D][0-9]{1,2}$");

            if (regex.IsMatch(passengerSeat))
            {
                placeCheck(passengerSeat, planeSeat);
            }
            else
            {
                Console.WriteLine("Введено неверное значение!");
                Console.Write("\nМесто №: ");

                placeNumber(planeSeat);
            }
        }

        public string placeCheck(string passengerSeat, object[,] planeSeat)
        {
            int indexX;
            switch (passengerSeat[0])
            {
                case 'A':
                    indexX = 0;
                    break;
                case 'B':
                    indexX = 1;
                    break;
                case 'C':
                    indexX = 2;
                    break;
                default:
                    indexX = 3;
                    break;
            }

            int indexY;
            string temp = passengerSeat.Remove(0, 1);
            indexY = Convert.ToInt32(temp);

            if (indexY <= 25)
            {
                if (planeSeat[indexX, indexY].Equals('x'))
                {
                    Console.WriteLine("Выбранное место занято!");
                    Console.Write("\nМесто №: ");

                    placeNumber(planeSeat);
                }
                else
                {
                    Console.WriteLine($"Отлично! Ваше место: {passengerSeat}\n");
                    Seat = passengerSeat;
                }
            }
            else
            {
                Console.WriteLine("Введено неверное значение!");
                placeCheck(passengerSeat, planeSeat);
            }
            return Seat;
        }
    }
}
