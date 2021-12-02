using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Чтобы найти площадь и объем куба введите длину его ребра: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a>0)
            {
                double V, S;
                CalcCube(a, out V, out S);
                Console.Write("Площадь куба равна {0:F2}, а объем куба равен {1:F2}", S, V);
            }
            else
            {
                Console.WriteLine("Нельзя построить куб со стороной <=0!");
            }
            Console.ReadKey();
        }
        static void CalcCube(double a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = Math.Pow(a, 2) * 6;
        }

    }
}
