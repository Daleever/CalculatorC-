using System;
using System.Collections.Generic;

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
            Console.WriteLine(isIngener);

            while(true)
            {
                try
                {


                }catch(DivideByZeroException e)
                {
                    Console.WriteLine(e);
                }
                


















            }
        }
    }
}