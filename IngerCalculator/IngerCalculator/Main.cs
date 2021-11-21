using System;
using System.Collections.Generic;
using System.IO;

namespace Lb_5
{
    class Program
    {
        static public void Main()
        {
            Console.WriteLine("Ви запустили калькулятор!");
            Console.WriteLine("Оберiть режим:");
            Console.WriteLine("1.Звичайний     |     2.Iнженерний");
            string mode = Console.ReadLine();
            OrdinaryCalc calc;
            while (mode != "1" && mode != "2")
            {
                Console.Write("Будь ласка, введiть 1 або 2: ");
                mode = Console.ReadLine();
            }
            bool isIngener = mode == "1" ? false : true ;
            if (isIngener)
            {
                calc = new AdvancedCalc();
            }
            else
            {
                calc = new OrdinaryCalc();
            }
                
            while(true)
            {
                Console.Write("Список доступних операцiй:\n\t+ - Додавання;\n\t- - Вiднiмання;\n\t* - Множення;" +
                                  "\n\t/ - Дiлення;\n\t& - Переведення з байтiв в кiлобайти;\n\tq- Вихiд iз программи.\nОберiть операцiю: ");
                    string operation = Console.ReadLine();
                    while (operation!="+" && operation!="-" && operation!="*" && operation!="/" && operation!="&" && operation!="q")
                    {
                        Console.Write("Введiть коректне позначення операцiї (+,-,/,*,&,q): ");
                        operation = Console.ReadLine();
                    }

                    if (operation == "q")
                    {
                        break;
                    }
                    double n;
                    try
                    {
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
                            calc.Div();
                            Console.WriteLine(calc.GetNum1()+operation+calc.GetNum2()+"="+calc.Div());
                            break;
                        case ("&"):
                            if (!isIngener)
                            {
                                Console.WriteLine("Звичайний калькулятор не пiдтримує таку операцiю");
                                break;
                            }
                            else
                            {
                                Console.Write("Будь ласка, введiть значення у байтах:");
                                while (!double.TryParse(Console.ReadLine(), out n))
                                {
                                    Console.Write("Будь ласка, введiть коректне числове значення:");
                                }

                                AdvancedCalc calc1 = new AdvancedCalc();
                                calc1.SetNum1(n);
                                Console.WriteLine(calc1.GetNum1() + " B = " + calc1.TranslateToKByte() + " KB");
                                break;
                            }
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}