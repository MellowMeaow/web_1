using System;

namespace ДЗ_1__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,res = 0;
            char s;
            Console.WriteLine("Enter the operation");
            s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the numbers a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers b");
            b = Convert.ToInt32(Console.ReadLine());
            if (s == '+'|| s == '-'|| s == '*'|| s == '/') 
            {
                if (s == '+')
                {
                    res = a + b;
                }
                if (s == '-')
                {
                    res = a - b;
                }
                if (s == '*')
                {
                    res = a * b;
                }
                if (s == '/' && b != 0)
                {
                    res = a / b;
                }
                else
                {
                    Console.WriteLine("cannot be divided by 0");
                }
                Console.WriteLine(res);
            }
            else 
            {
                Console.WriteLine("Error. Enter the correct data!");
                return;
            }
        }
    }
}
