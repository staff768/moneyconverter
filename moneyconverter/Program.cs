using System;

namespace CurrencyApp   
{
    internal class Program
    {
        const double UsdToRub = 90.0;
        const double EurToRub = 98.5;
        const double GbpToRub = 115.2;
        const double CnyToRub = 12.7;

        static void Main(string[] args)
        {
            

            bool isopen = true;
            while (isopen) 
            {
                Console.WriteLine("Конвертировать В рубль (TO) или ИЗ рубля (FROM)?");
                string mode = Console.ReadLine();
               if (mode.ToLower() == "to")
               {
                    Console.WriteLine("Выберите номер исходной валюты:\n1. USD\n2. EUR\n3. GBP\n4. CNY");
                    string currency = Console.ReadLine();
 
                    Console.WriteLine("Введите исходную сумму:");
                    int sum;
                    if (!int.TryParse(Console.ReadLine(), out sum))
                    {
                        Console.WriteLine("Ошибка: введите целое число!");
                        continue;
                    }

                    ConverToRub(currency, sum);
                } else if (mode.ToLower() == "from")
                {
                    Console.WriteLine("Выберите номер в какую валюту конвертировать:\n1. USD\n2. EUR\n3. GBP\n4. CNY");
                    string currency = Console.ReadLine();

                    Console.WriteLine("Введите исходную сумму:");
                    int sum;
                    if (!int.TryParse(Console.ReadLine(), out sum))
                    {
                        Console.WriteLine("Ошибка: введите целое число!");
                        continue;
                    }

                    ConverFromRub(currency, sum);

                } 
                else
                {
                    Console.WriteLine("Ошибка! Попробуйте еще раз");
                } 
                isopen = false;
            }
        }
        static void ConverToRub(string currency, int sum)
        {
            switch (currency)
            {
                case "1":
                    Console.WriteLine($"{sum} USD = " + sum * UsdToRub + " RUB");
                    break;
                case "2":
                    Console.WriteLine($"{sum} EUR = " + sum * EurToRub + " RUB");
                    break;
                case "3":
                    Console.WriteLine($"{sum} GBP = " + sum * GbpToRub + " RUB");
                    break;
                case "4":
                    Console.WriteLine($"{sum} CNY = " + sum * CnyToRub + " RUB");
                    break;
            }
        }
        static void ConverFromRub(string currency, int sum) 
        {
            switch (currency)
            {
                case "1":
                    Console.WriteLine($"{sum} RUB = " +  sum / UsdToRub + " USD");
                    break;
                case "2":
                    Console.WriteLine($"{sum} RUB = " + sum / EurToRub + " EUR");
                    break;
                case "3":
                    Console.WriteLine($"{sum} RUB = " + sum / GbpToRub + " GBP");
                    break;
                case "4":
                    Console.WriteLine($"{sum} RUB = " + sum / CnyToRub + " CNY");
                    break;
            }
        }
    }

}