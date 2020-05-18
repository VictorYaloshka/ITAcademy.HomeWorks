using System;
using System.Collections.Generic;

namespace AirportApp
{
    class CustomsBorderControl
    {
        const int DeclarationRatio = 40;

        List<string> declarationList = new List<string>
            {
            "15 000$",
            "драгоценные металлы",
            "банковские чеки",
            "векселя",
            "акции Microsoft",
            "акции SamSolutions",
            "культурные ценности",
            "оружие",
            "высокочастотные устройства",
            "документы, содержащие государственную тайну",
            "растения, которым грозит вымирание"
            };


        public void СustomsСontrol()
        {
            Console.WriteLine("Есть ли у Вас вещи для декларированя? Выберите нужный вариант:");
            Console.WriteLine("1. Вещей для декларирования нет.");
            Console.WriteLine("2. Eсть вещи для декларирования.");
            string choiseDeclare = Console.ReadLine();
            if (choiseDeclare.Equals("1"))
            {
                Console.WriteLine("Проходите через зелёный коридор на предполётный досмотр");
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.WriteLine();
                return;
            }
            else if (choiseDeclare.Equals("2"))
            {
                Console.WriteLine("Проходите через красный коридор.");
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                СustomsDeclaration(declarationList);
            }
            else
            {
                Console.WriteLine("Введено неверное значение!");
                СustomsСontrol();
            }
        }


        public void СustomsDeclaration(List<string> declarationList)
        {
            Random random = new Random();
            int removeNumberOfThings = random.Next(declarationList.Count - 5, declarationList.Count - 1);

            for (int i = 0; i < removeNumberOfThings; i++)
            {
                int removeElement = random.Next(0, declarationList.Count);
                declarationList.RemoveAt(removeElement);
            }

            int surcharge = DeclarationRatio * declarationList.Count;

            Console.WriteLine("\nВы задекларировали:");
            foreach (var item in declarationList)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine($"Вам необходимо доплатить: {surcharge}$");
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine("\nПроходите на предполётный досмотр");
            Console.WriteLine();
        }

        public void SecurityCheck()
        {
            Console.WriteLine("Положите, пожалуйста, ручную кладь на конвейер рентгена-сканера.");
            Console.WriteLine("Мелкие вещи из карманов положите рядом с рамкой.");
            Console.WriteLine("Пройдите через рамку металлодетектора.");
            Console.WriteLine("Нажмите любую клавишу.");
            Console.ReadKey();
            Console.WriteLine("\nВсё в порядке, Вы можете проходить на посадку на рейс. Хорошего полёта и мягкой посадки.");
        }
    }
}
