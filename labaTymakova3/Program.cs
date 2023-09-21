using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class Program
    {
            enum Account_type
        {
            Текущий,
            Сберегательный
        }
        struct Bank_account
        {
            public uint Account_id;
            public Account_type Account_type;
            public decimal Account_balance;
        }
        struct User
        {
            public string Name;
            public VUZ VUZ;
        }
        enum VUZ
        {
            КГУ,
            КАИ,
            КХТИ
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            Account_type account = Account_type.Сберегательный;
            Console.WriteLine($"Ваш вид банковского счета - {account}");

            Console.WriteLine("Упражение 3.2");
            Bank_account user = new Bank_account();
            user.Account_id = 1;
            user.Account_type = Account_type.Сберегательный;
            user.Account_balance = 80000;

            Console.WriteLine($"Ваш номер банковского счета - {user.Account_id}\n");
            Console.WriteLine($" Ваш вид банковского счета - {user.Account_type}\n");
             Console.WriteLine($"Ваш баланс банковского счета - {user.Account_balance}\n");

            Console.WriteLine("Домашнее задание 3.1");
            User user1 = new User();
            user1.Name = "Ильнур";
            user1.VUZ = VUZ.КХТИ;
            Console.WriteLine($"Работник ВУЗа: {user1.Name}\n");
            Console.WriteLine($"Название ВУЗа: {user1.VUZ}");
            Console.ReadKey();
        }
        
    }
}
    

    

