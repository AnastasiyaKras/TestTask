using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Реестр_тестовое%20задание1.html";

            var parser = new Parser();
            var ress = parser.GetInfo(path).Result;
            Console.WriteLine($"Номер платежа: {ress.NumberPay}");
            Console.WriteLine($"Дата платежа: {ress.DatePay}");
            Console.WriteLine();
            Console.WriteLine($"Номер документа");
            foreach (string item in ress.NumberDocum)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('=', 20));
            Console.WriteLine();

            Console.WriteLine($"Выплаченная сумма");
            foreach (string item in ress.Summa)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('=', 20));

            Console.ReadLine();
        }
    }
}
