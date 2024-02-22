using System;

namespace Module_4
{
    internal class Application_4_5
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 3; k++)
            {
                (string Name, string LastName, string Login, int LongLogin, bool Pet, int Age, string[] Favcolors) Anketa;

                Console.Write("Введите имя: ");
                Anketa.Name = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                Anketa.LastName = Console.ReadLine();

                Console.Write("Введите логин: ");
                Anketa.Login = Console.ReadLine();
                Anketa.LongLogin = Anketa.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var otvet = Console.ReadLine();

                if (otvet == "Да")
                {
                    Anketa.Pet = true;
                }

                else
                {
                    Anketa.Pet = false;
                }

                Console.Write("Введите Ваш возраст: ");
                Anketa.Age = Convert.ToInt32(Console.ReadLine());

                Anketa.Favcolors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < Anketa.Favcolors.Length; ++i)
                {
                    Anketa.Favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}
