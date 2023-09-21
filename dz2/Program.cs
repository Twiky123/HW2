using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражение 1");
            string tab = "{0,5} | {1,5} | {2}";
            Console.WriteLine(string.Format(tab, "Тип", "Макс.знач", "Мин.знач\n"));
            Console.WriteLine(string.Format(tab, "byte", byte.MaxValue, byte.MinValue));
            Console.WriteLine(string.Format(tab, "sbyte", sbyte.MaxValue, sbyte.MinValue));
            Console.WriteLine(string.Format(tab, "short", short.MaxValue, short.MinValue));
            Console.WriteLine(string.Format(tab, "ushort", ushort.MaxValue, ushort.MinValue));
            Console.WriteLine(string.Format(tab, "int", int.MaxValue, int.MinValue));
            Console.WriteLine(string.Format(tab, "uint", uint.MaxValue, uint.MinValue));
            Console.WriteLine(string.Format(tab, "long", long.MaxValue, long.MinValue));
            Console.WriteLine(string.Format(tab, "ulong", ulong.MaxValue, ulong.MinValue));
            Console.WriteLine(string.Format(tab, "float", float.MaxValue, float.MinValue));
            Console.WriteLine(string.Format(tab, "double", double.MaxValue, double.MinValue));
            Console.WriteLine(string.Format(tab, "decimal", decimal.MaxValue, decimal.MinValue));
            Console.WriteLine(string.Format(tab, "char", char.MaxValue, char.MinValue));
            Console.WriteLine(string.Format(tab, "string", "N/A", "N/A"));
            Console.WriteLine(string.Format(tab, "bool", "True", "False"));
            Console.WriteLine(string.Format(tab, "object", "N/A", "N/A"));
            Console.WriteLine(string.Format(tab, "dynamic", "N/A", "N/A\n"));

            Console.WriteLine("Упражнение 2");
            Console.WriteLine("Задание 2\nВведите ваше имя, город, возраст и PIN-код");
            string Name = Console.ReadLine();
            string Town = Console.ReadLine();
            int Age = Convert.ToInt32(Console.ReadLine());
            int Pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ваше имя: {Name}\n" +
                $"Вы проживаете в городе: {Town}\n" +
                $"Ваш возраст: {Age}\n" +
                $"Ваш PIN-код: {Pin}\n");

            Console.WriteLine("Упражнение 3:\nВведите буквы:");
            string input = Console.ReadLine();
            string result = "";
            for (int x = 0; x < input.Length; x++)
            {
                if (char.IsLetter(input[x]))
                {
                    if (char.IsUpper(input[x]))
                    {
                        result += input.ToLower()[x];
                    }
                    else
                    {
                        result += input.ToUpper()[x];
                    }
                }
                else 
                {
                    Console.WriteLine("Строка не состоит из букв\n"); 
                }
            }
            Console.WriteLine($"Строка с измененными буквами - {result}\n");

            Console.WriteLine("Упражнение 4");
            string String = Console.ReadLine(); 
            string subString = Console.ReadLine();
            int count = 0;
            if (String.Length > 0 & subString.Length > 0)
            {
                for (int x = 0; x <= String.Length - subString.Length; x++)
                {
                    if (String.Substring(x, subString.Length) == subString)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Количество подстрок в строке - {count}\n");
            }
            else
            {
                Console.WriteLine($"Введены недопустимые символы\n");
            }
            Console.WriteLine("Упражнение 5\n Введите стоимость бутылки виски, скидку(только число) и стоимость отпуска");
            double normPrice = Convert.ToDouble(Console.ReadLine());
            double salePrice = Convert.ToDouble(Console.ReadLine());
            double holidayPrice = Convert.ToDouble(Console.ReadLine());
            if (salePrice > 0 & salePrice < 100)
            {
                Console.WriteLine($"Чтобы заработать на отпуск, вам нужно продать {(int)(holidayPrice / (normPrice * ((double)salePrice / 100)))} бутылок");
            }
            else
            {
                Console.WriteLine("Процент долже быть от 1 до 99");
            }
            Console.WriteLine("Задание 6:\nКак Вас зовут?");
            Console.WriteLine($"Привет, {Console.ReadLine()}");
            string secretroom = Console.ReadLine();
            if (secretroom.ToLower() == "знаешь ли ты что-то о тайной комнате")
            {
                Console.WriteLine("Да");
                string secretroom1 = Console.ReadLine();
                if (secretroom1.ToLower() == "можешь ли рассказать о ней")
                {
                    Console.WriteLine("Нет");
                    Thread.Sleep(5000);
                    Console.WriteLine("Но могу показать!");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
            }

        }
    }
}
