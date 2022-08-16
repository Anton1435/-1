using System;

namespace Новая_папка
{
    class Program
    {
        static void Main(string[] arg)
        {
            /// && - и
            /// || - или
           // int a = 15;
            //int b = 11;
           // int c = 12;
           // int x = 0;
           // bool flag = a > b;
           // int index = flag ? 1:2; // если а>b то мы передаем 1, если не то 2
            // "?" - это мы вызываем if, ":" - это else
            //if (a <= b || a <= c)  /// спомощью команды && всега должно быть положительное знак
            //{ }
            //if ( (a > b && a > c ) || (a == x) )  ///     || - всегда после &&
            //{}

          /// дз.
          int number = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine( Math.Abs(number)) ;     ////модуль - значение не звисимо от знаков

          Console.WriteLine( Math.Sqrt(number)) ;  //// модуль вычисления корень

          Console.WriteLine( Math.Round(Math.Sqrt(number),1)) ;   ////округление чисел, 
            /// цифра после запятой показывает до кого знака округлить после запятой
          Console.WriteLine( Math.Pow(number,10)) ;    /// степень/цифра указание степени
          
          

        }
    }
}