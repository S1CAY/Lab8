using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab8
{
    class Program
    {
        static void Main()
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            while (true)
            {
                Console.WriteLine("1. Переглянути налаштування");
                Console.WriteLine("2. Змінити налаштування");
                Console.WriteLine("3. Вийти");
                Console.Write("Виберіть опцію: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Поточні налаштування:");
                        configManager.PrintSettings();
                        break;
                    case "2":
                        Console.Write("Введіть ключ параметра: ");
                        string key = Console.ReadLine();
                        Console.Write("Введіть нове значення параметра: ");
                        string value = Console.ReadLine();
                        configManager.SetSetting(key, value);
                        Console.WriteLine("Зміни збережено.");
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }

}
