using System;

namespace ДЗ_1__5
{
    class Program
    {
        static void Main(string[] args)
        {
            int form;
            double x, y,T,l,g;
            const double PI = 3.14159265358979;
            Console.WriteLine("Выберете нужную формулу:");
            Console.WriteLine("1.Период колебания математического маятника");
            Console.WriteLine("2.y = log((x^2)-4)");
            Console.WriteLine("3.y = Sqrt(Sin(Sqrt(x)))");
            Console.WriteLine("4.y = (Sqrt(x))/(Sin(PI*x))");
            form = Convert.ToInt32(Console.ReadLine());
            switch (form)
            {
                case 1 :
                    {
                        Console.WriteLine("Введите значения переменных");
                        Console.Write("l=");
                        l = Convert.ToDouble(Console.ReadLine());
                        Console.Write("g=");
                        g = Convert.ToDouble(Console.ReadLine());
                        T = 2 * PI * Math.Sqrt(l / g);
                        Console.Write("T=");
                        Console.WriteLine(T);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите значения переменной");
                        Console.Write("x=");
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Math.Log10(Math.Pow(x, 2) - 4);
                        Console.Write("y=");
                        Console.WriteLine(y);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Введите значения переменной");
                        Console.Write("x=");
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Math.Sqrt(Math.Sin(Math.Sqrt(x)));
                        Console.Write("y=");
                        Console.WriteLine(y);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Введите значения переменных");
                        Console.Write("x=");
                        x = Convert.ToDouble(Console.ReadLine());
                        y = (Math.Sqrt(x)) / (Math.Sin(PI * x));
                        Console.Write("y=");
                        Console.WriteLine(y);
                        break;
                    }
            }
            return;
        }
    }
}
