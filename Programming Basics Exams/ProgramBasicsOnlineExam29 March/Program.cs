using System;

namespace Programming_Basics_Online_Exam___28_and_29_March_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberBitcoins = double.Parse(Console.ReadLine());
            double numberChineseYuans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double usd = 1.76;
            double euro = 1.95;

            double bgnValueBitcoins = numberBitcoins * 1168.00;
            double bgnValueChineseYuan = numberChineseYuans * 0.15 * usd;
            double totalBgnValue = bgnValueBitcoins + bgnValueChineseYuan;

            double totalEuro = totalBgnValue / euro;
            double totalAfterComission = totalEuro * commission / 100;
            double total = totalEuro - totalAfterComission;

            Console.WriteLine($"{total:f2}");
        }
    }
}
