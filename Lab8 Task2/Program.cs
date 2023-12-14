using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Оберіть тип графіка: ");
            Console.WriteLine("1. Лінійний графік");
            Console.WriteLine("2. Стовпчиковий графік");
            Console.WriteLine("3. Кругова діаграма");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            GraphFactory factory = null;

            switch (choice)
            {
                case "1":
                    factory = new LineChartFactory();
                    break;
                case "2":
                    factory = new BarChartFactory();
                    break;
                case "3":
                    factory = new PieChartFactory();
                    break;
                default:
                    Console.WriteLine("Невірний вибір.");
                    return;
            }

            Chart chart = factory.CreateChart();
            chart.Draw();
        }
    }

}
