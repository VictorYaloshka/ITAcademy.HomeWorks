using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Чтение файла по пути "C:\Temp\image.txt".
            //2. Считвание всего текста из файла и создание объекта 'textReaderResult'.
            //3. Разделение текста 'textReaderResult' на строки (в каждой по 8 символов) с помощью функции 'Split(' ')'.
            //4. Создание массива 'imageBytes', в который будут собираться строки преобразованные в байты.
            //5. Конвертация каждого элемента массива 'arrayOfTextResult.Length - 1' с помощью цикла в байты и сборка их в массив 'imageBytes'.
            //6. Вызов метода 'Dispose' для освобождения от неуправляемых ресурсов 'textReader'.
            //7. Создание нового файла по пути "C:\Temp\image.png" с помощью метода 'WriteAllBytes'.
        }
    }
}
