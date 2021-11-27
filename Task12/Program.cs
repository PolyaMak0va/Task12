using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        // Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        // метод, определяющий длину окружности по заданному радиусу;
        // метод, определяющий площадь круга по заданному радиусу;
        // метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
        static void Main(string[] args)
        {
            Console.WriteLine("Длина окружности по заданному радиусу равна: {0:f4}", Circle.Circumference());
            Console.WriteLine("Площадь круга по заданному радиусу: {0:f4}", Circle.CircleSquare());
            Console.WriteLine("Длина отрезка между точкой и началом координат равна {0:f4}", Circle.Сoordinates());
            Console.ReadKey();
        }
    }
    static class Circle
    {
        private static double R; // радиус окружности
        public static double L;  // длина окружности
        public static double S;  // площадь окружности
        public static double H;  // длина отрезка между точкой и началом координат по теореме Пифагора
        public static double x0; // координата х0
        public static double y0; // координата y0
        static Circle()
        {
            R = 12.983;
            L = 0;
            S = 0;
            H = 0;
            x0 = 0;
            y0 = 0;
        }
        public static double Circumference()
        {
            L = 2 * Math.PI * R;
            return L;
        }
        public static double CircleSquare()
        {
            S = Math.PI * Math.Pow(R, 2);
            return S;
        }
        public static double Сoordinates()
        {
            try
            {
                Console.Write("Введите значение X: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите значение Y: ");
                double y = double.Parse(Console.ReadLine());
                H = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
                if (H > R)
                {
                    Console.WriteLine("Точка не принадлежит кругу");
                    return H;
                }
                else
                {
                    Console.WriteLine("Точка принадлежит кругу");
                    return H;
                }
            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
                return H;
            }    

        }
    }
}
