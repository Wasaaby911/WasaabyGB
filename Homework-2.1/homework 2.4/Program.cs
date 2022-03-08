using System;

namespace homework_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("{0,35}","НЬЮ ЙОРКЕР Ритейл РУС");
            Console.WriteLine("{0,39}", "г. Тамбов, ул. Советская, 99");
            Console.WriteLine("{0,30}", "КАССОВЫЙ ЧЕК");


            string firstposname = ("57438 АКСЕССУАРЫ, ОДЕЖДА *1                   ");
            double firstposprice = (399.00);
            double firstNds = firstposprice / 120 * 20;                                         // НДС первого товара
            Console.WriteLine(firstposname + firstposprice);
            Console.WriteLine("НДС                                          " + Math.Round(firstNds, 2));

            string secondposname = ("65658 ФУТБОЛКИ, ЖЕНСКИЕ *1                    ");
            double secondposprice = (299.00);
            double secondNds = secondposprice / 120 * 20;                                               // НДС второго товара
            Console.WriteLine(secondposname + secondposprice);
            Console.WriteLine("НДС                                         " + Math.Round(secondNds, 2));

            double fullPrice;                                               // Цена чека
            fullPrice = (firstposprice + secondposprice);
            Console.WriteLine("ИТОГ                                          " + fullPrice);

            double cache;                                                   // Получено наличных
            cache = 1000.00;
            Console.WriteLine("ПОЛУЧЕНО       РУБ                           " + cache);

            double change;                                                  // Переменная сдачи 
            change = cache - fullPrice;
            Console.WriteLine("СДАЧА          РУБ                            " + change);

            int POCID;                                                      // я так понял номер чека
            POCID = 3410;
            Console.WriteLine("POC-ID:" + POCID);

            Console.WriteLine("_________________________________________________");

            Console.WriteLine("НАЛИЧНЫМИ                                     " + fullPrice);
            Console.WriteLine("СУММА НДС 20%                              " + Math.Round(firstNds + secondNds, 2));

            int seller = 1;
            
            switch (seller)
            {
                case 1:
                    Console.WriteLine("КАССИР 1 - вт. зам Копцева");
                    break;
                case 2:
                    Console.WriteLine("КАССИР 2 - перв. зам Игнатьева");
                    break;
                case 3:
                    Console.WriteLine("КАССИР 3 - вт. мерч Филиппова");
                    break;
            }

            Console.WriteLine("ООО \"НЬЮ ЙОРКЕР Ритейл РУС\"");

            int index = 392000;
            Console.WriteLine(index + " г. Тамбов, ул. Советская, д. 99А, ТЦ \"РИО\"");

            bool placeSell = true;
             if (placeSell)
             { 
                    Console.WriteLine("МЕСТО РАСЧЕТОВ Торговый зал");
             }

            else
            {
                    Console.WriteLine("МЕСТО РАСЧЕТОВ Второй зал");
            }

            Console.WriteLine("САЙТ ФНС                             www.nalog.ru");

            Console.Write("ЗН ККТ 0254100104374");
            Console.WriteLine("      РН ККТ 0000716789055651");

            Console.Write("ФН 9289440300733761");
            Console.WriteLine("                ИНН 7705886905");

        }

    }
}
