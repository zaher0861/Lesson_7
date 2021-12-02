using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение стороны х первого треугольника: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение стороны y первого треугольника: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение стороны z первого треугольника: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double S1 = CalcSquare(x, y, z);
            // Здесь мы проверяем, можно ли построить первый трегольник с такими сторонами 
            if (S1 > 0 && x > 0 && y > 0 && z > 0)
            {
                Console.WriteLine("Площадь первого треугольника = {0:F2}", CalcSquare(x, y, z));
                Console.WriteLine();
                Console.Write("Введите значение стороны х второго треугольника: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение стороны y второго треугольника: ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение стороны z второго треугольника: ");
                z = Convert.ToDouble(Console.ReadLine());
                double S2 = CalcSquare(x, y, z);
                // Здесь мы проверяем, можно ли построить второй трегольник с такими сторонами 
                if (S2 > 0 && x > 0 && y > 0 && z > 0)
                {
                    Console.WriteLine("Площадь второго треугольника = {0:F2}", S2);
                    Console.WriteLine();
                    // Здесь мы проверяем на то, равны ли наши треугольники между собой
                    if (S1 == S2)
                    {
                        Console.WriteLine("Вы задали одинаковые треугольники!");
                    }
                    else
                    {
                        if (S1 > S2)
                        {
                            Console.WriteLine("Площадь первого треугольника больше чем площадь второго!");
                        }
                        else
                        {
                            Console.WriteLine("Площадь второго треугольника больше чем площадь первого!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Из таких сторон нельзя построить треугольник!");
                }
            }
            else
            {
                Console.WriteLine("Из таких сторон нельзя построить треугольник!");
            }
            Console.ReadKey();
        }
        static double CalcSquare(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
