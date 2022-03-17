using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Запросить имя пользователя. Вывести Hello, [имя пользователя].
            // 2.Запросить у пользователя два целых числа и сохранить в двух переменных. Вывести значения.
            // Обменять значения переменных: например, если в переменной x было записано число 3, а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5.Вывести значения после обмена.
            // 3.Запросить у пользователя целое число. Вывести количество цифр числа. Например, в числе 156 - 3 цифры.

            
            Console.WriteLine($"Введите имя пользователя:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Привет, {name}");
            Console.WriteLine("Введите первое число:");
            int pervoe = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int vtoroe = int.Parse(Console.ReadLine());
            Console.WriteLine($"Первое число : {pervoe}");
            Console.WriteLine($"Второе число : {vtoroe}");
            Console.ReadLine();

            (pervoe, vtoroe) = (vtoroe, pervoe);
            Console.WriteLine(pervoe);
            Console.WriteLine(vtoroe);
            Console.ReadLine();

            Console.WriteLine("Введите целое число: ");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int celoe))
            {
                int final = s.Length;
                Console.WriteLine($"В вашем числе {final} циф(ер)ры");
                Console.ReadLine();
                
            }
             



            


        }
    }
}
