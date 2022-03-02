using System;

namespace homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет {name}, сегодня {DateTime.Now}");
        }
    }
}
