using System;

namespace homework_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a;
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }

            else
            {
                Console.WriteLine("Число не четное");
            }

        }
    }
}
