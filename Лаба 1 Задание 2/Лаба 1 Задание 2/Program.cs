using System;

namespace Лаба_1_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x = 0, y = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите x=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y=");
                y = Convert.ToDouble(Console.ReadLine());

                if (y <= x & x >= -2 & x <= 0 & y <= 0 & y >= -2 /* Нижний треугольник */| y >= -x & y <= 2 & y >= 0 & x >= -2 & x <= 0 /* Верхний треугольник */| x * x + y * y <= 4 & x >= 0 /* Полукруг */) 
                    Console.WriteLine("Точка (" + x + "," + y + ") попадает в область");
                else
                Console.WriteLine("Точка (" + x + "," + y + ") не попадает в область");
        }
        Console.ReadKey();
        }
    }
}
