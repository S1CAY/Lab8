using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Task3
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Оберіть тип продукту для створення:");
            Console.WriteLine("1. Смартфон");
            Console.WriteLine("2. Ноутбук");
            Console.WriteLine("3. Планшет");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();
            TechProductFactory factory = null;

            switch (choice)
            {
                case "1":
                    factory = new SmartphoneFactory();
                    break;
                case "2":
                    factory = new LaptopFactory();
                    break;
                default:
                    Console.WriteLine("Невірний вибір.");
                    return;
            }

            Screen screen = factory.CreateScreen();
            Processor processor = factory.CreateProcessor();
            Camera camera = factory.CreateCamera();

            Console.WriteLine("Створено технологічний продукт:");
            screen.DisplayInfo();
            processor.Process();
            camera.Capture();
        }
    }

}
