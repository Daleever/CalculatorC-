using System;
using System.Collections.Generic;
using System.IO;

namespace Lb_4
{
    class Program
    {
        static void Main()
        {































            List<string> operations = new List<string>();
            Console.Write("Список доступних операцiй:\n\t+ - Додавання;\n\t- - Вiднiмання;\n\t* - Множення;" +
                              "\n\t/- Дiлення;\n\t& - переведення з байтiв в кiлобайти.\nОберiть операцiю: ");
            string operation = Console.ReadLine();
            while (operation.Contains(operation))
            {
                Console.WriteLine("Введіть коректне позначення операцiї (+,-,/,*,&): ");
            }
            switch (operation)
            {
                case("+"):
                    break;
                case("-"):
                    break;
                case("*"):
                    break;
                case("/"):
                    break;
                case("&"):
                    break;
            }
        }
    }
}