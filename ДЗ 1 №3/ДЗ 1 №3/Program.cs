using System;

namespace ДЗ_1__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте минимальный элемент");
            int MIN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте максимальный элемент");
            int MAX = Convert.ToInt32(Console.ReadLine());
            int[] Mas = new int[length];
            Random rand = new Random();
            Console.WriteLine("Массив");
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rand.Next(MIN, MAX);
                Console.WriteLine(Mas[i]);
            }
            Array.Sort(Mas);
            Console.WriteLine("Сортированный массив");
            for (int i = 0; i < Mas.Length; i++)
            {
                Console.WriteLine(Mas[i]);
            }
        }
    }
}
