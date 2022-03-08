using System;

namespace Homework_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double mintemperature, maxtemperature;


            Console.WriteLine("Введите значение минимальной температуры за сутки");

            mintemperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение максимальной температуры за сутки");

            maxtemperature = double.Parse(Console.ReadLine());

            double result = (mintemperature + maxtemperature) / 2;
            Console.WriteLine("Средняя температура за сутки = " + result);

        }
    }
}
