using System;

namespace homework_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("НЬЮ ЙОРКЕР Ритейл РУС");
            Console.WriteLine("г. Тамбов, ул. Советская, 99");
            Console.WriteLine("КАССОВЫЙ ЧЕК");

            string firstposname = ("57438 АКСЕССУАРЫ, ОДЕЖДА *1...");
            double firstposprice = (399.00);
            Console.WriteLine(firstposname + firstposprice);

            string secondposname = ("65658 ФУТБОЛКИ, ЖЕНСКИЕ *1...");
            double secondposprice = (299.00);
            Console.WriteLine(secondposname + secondposprice);

            double fullPrice;
            fullPrice = (firstposprice + secondposprice);
            Console.WriteLine("ИТОГ................" + fullPrice);

            double cache;
            cache = 1000.00;





        }
    }
}
