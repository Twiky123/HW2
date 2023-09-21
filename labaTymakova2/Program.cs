using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1:\nВведите свое имя:");
            Console.WriteLine($"Здраствуй,{Console.ReadLine()}!");
            Console.WriteLine("Упражнение 2.2:\nВведите два значения:");
            double value1 = Convert.ToDouble(Console.ReadLine()), value2 = Convert.ToDouble(Console.ReadLine());
            if (value2 == 0)
            {
                Console.WriteLine("НА НолЬ ДелИтЬ НеЛьзЯ");
            }
            else
            {
                Console.WriteLine($"Ответ:{value1 / value2}");
            }
            Console.WriteLine("Домашнее задание 2.1\nВведите букву:");
            char value = Console.ReadKey().KeyChar;
            if (char.IsLetter(value))
            {
                if (value != 'z' & value != 'Z' & value != 'я' & value != 'Я')
                {
                    Console.WriteLine($"\nСледующая буква: {(char)(value + 1)}\n");
                }
                else if (char.IsLower(value))
                {
                    Console.WriteLine("\nСледующая буква: а");
                }
                else
                {
                    Console.WriteLine("\nСледующая буква: А");
                }
            }
            else
            {
                Console.WriteLine("Введите букву");
            }
            Console.WriteLine("Домашнее задание 2.2\n Введите коэффициенты");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double discriminant = (b * b - 4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("Уравнение с данными коэффициентами не имеет корней");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"Уравнение с данными коэффициентами имеет один корень = {(-b + Math.Sqrt(discriminant)) / (2 * a)}!\n");
            }
            else
            {
                Console.WriteLine($"Ууравнение с данными коэффициентами имеет два корня = {(-b + Math.Sqrt(discriminant)) / (2 * a)}, {(-b - Math.Sqrt(discriminant)) / (2 * a)}");
            }
        }

    }
    
}