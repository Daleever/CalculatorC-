using System;
using System.Collections.Generic;
using System.IO;

namespace Lb_5
{
    class Program
    {
        static public void Main()
        {

            
            Console.WriteLine("Вы запустили калькулятор");
            Console.WriteLine("Выберите режим:");
            Console.WriteLine("1.Обычный     |     2.Инженерный");
            bool isIngener = Console.Read() == '1' ? false : true ;
            AdvancedCalc calc = new AdvancedCalc();
































            while(true)
            {
                try
                {
                    List<string> operations = new List<string>();
                    operations.AddRange(new string[]{"+","-","*","/","&"});
                    Console.Write("Список доступних операцiй:\n\t+ - Додавання;\n\t- - Вiднiмання;\n\t* - Множення;" +
                              "\n\t/- Дiлення;\n\t& - переведення з байтiв в кiлобайти.\nОберiть операцiю: ");
                    string operation = Console.ReadLine();
                    while (!operation.Contains(operation))
                    {
                        Console.Write("Введіть коректне позначення операцiї (+,-,/,*,&): ");
                        operation = Console.ReadLine();
                    }
                    double n;
                    switch (operation)
                    {
                        case ("+"):
                            Console.Write("Будь ласка, введiть перше число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum1(n);
                            Console.Write("Будь ласка, введiть друге число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum2(n);
                            Console.WriteLine(calc.GetNum1()+operation+calc.GetNum2()+"="+calc.Add());
                            break;
                        case ("-"):
                            Console.Write("Будь ласка, введiть перше число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum1(n);
                            Console.Write("Будь ласка, введiть друге число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum2(n);
                            Console.WriteLine(calc.GetNum1()+operation+calc.GetNum2()+"="+calc.Sub());
                            break;
                        case ("*"):
                            Console.Write("Будь ласка, введiть перше число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum1(n);
                            Console.Write("Будь ласка, введiть друге число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum2(n);
                            Console.WriteLine(calc.GetNum1()+operation+calc.GetNum2()+"="+calc.Mul());
                            break;
                        case ("/"):
                            Console.Write("Будь ласка, введiть перше число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum1(n);
                            Console.Write("Будь ласка, введiть друге число:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum2(n);
                            Console.WriteLine(calc.GetNum1()+operation+calc.GetNum2()+"="+calc.Div());
                            break;
                        case ("&"):
                            if (!isIngener)
                            {
                                Console.WriteLine("Звичайний калькулятор не пiдтримує таку операцію");
                                break;
                            }
                            Console.Write("Будь ласка, введiть значення у байтах:");
                            while(!double.TryParse(Console.ReadLine(), out n))
                            {
                                Console.Write("Будь ласка, введiть коректне числове значення:");
                            }
                            calc.SetNum1(n);
                            Console.WriteLine(calc.GetNum1()+" B = "+calc.GetNum2()+" KB");
                            break;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}