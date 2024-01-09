/*
 * Создать класс Currency (валюта), 
 * со свойством курс по отношению к доллару.
 * Создать наследников в виде классов (не менее 3х) различных типов валюты (рубли, гривны, леи).
 * Реализовать метод конвертор валют, принимающий на вход 
 * (валюту из которой хотим конвертировать, валюту в которую хотим конвертировать, сумма подлежащая конвертации).
 * В качестве результата конвертации, возвращается сумма в валюте в которую проводилась конвертация
*/
using System;
namespace Ex_3_Currency
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                byte currencyNumber1 = 0, currencyNumber2 = 0;
                double money = 0, moneyForWrite = 0;
                while (true)
                {
                    Console.WriteLine("Введите из какой валюты вы хотите перевести сумму (1-доллар 2-рубльПМР 3-лей 4-гривна):");
                    try
                    {
                        currencyNumber1 = Convert.ToByte(Console.ReadLine());
                        if (currencyNumber1 < 1 || currencyNumber1 > 4)
                        {
                            Console.WriteLine("Ошибка!(введите 1 или 2 или 3 или 4)");
                            continue;
                        }
                        break;
                    }
                    catch { Console.WriteLine("Ошибка!(введите 1 или 2 или 3 или 4)"); }
                }
                while (true)
                {
                    Console.WriteLine("Введите в какую валюту вы хотите перевести сумму (1-доллар 2-рубльПМР 3-лей 4-гривна):");
                    try
                    {
                        currencyNumber2 = Convert.ToByte(Console.ReadLine());
                        if (currencyNumber2 < 1 || currencyNumber2 > 4)
                        {
                            Console.WriteLine("Ошибка!(введите 1 или 2 или 3 или 4)");
                            continue;
                        }
                        break;
                    }
                    catch { Console.WriteLine("Ошибка!(введите 1 или 2 или 3 или 4)"); }
                }
                while (true)
                {
                    Console.WriteLine("Введите сумму:");
                    try
                    {
                        money = moneyForWrite = Convert.ToDouble(Console.ReadLine());
                        if (money < 0)
                        {
                            Console.WriteLine("Ошибка!(введите неотрицательное число)");
                            continue;
                        }
                        break;
                    }
                    catch { Console.WriteLine("Ошибка!(введите неотрицательное число)"); }
                }
                RublPMR ruble = new RublPMR();
                Lei lei = new Lei();
                Hryvnia hryvnia = new Hryvnia();
                Dollar dollar = new Dollar();
                Currency currency1 = dollar;
                switch (currencyNumber1)
                {
                    case 1:
                        currency1 = dollar;
                        break;
                    case 2:
                        currency1 = ruble;
                        break;
                    case 3:
                        currency1 = lei;
                        break;
                    case 4:
                        currency1 = hryvnia;
                        break;
                }
                Currency currency2 = dollar;
                switch (currencyNumber2)
                {
                    case 1:
                        currency2 = dollar;
                        break;
                    case 2:
                        currency2 = ruble;
                        break;
                    case 3:
                        currency2 = lei;
                        break;
                    case 4:
                        currency2 = hryvnia;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0} {1} = {2} {3}", moneyForWrite, currency1._name, Math.Round(currency1.Convert(currency2, money), 2), currency2._name);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Повторить?(да - нажмите 'enter'; нет - введите любой символ)");
                Console.ForegroundColor = ConsoleColor.White;
                string repeat = Convert.ToString(Console.ReadLine());
                if (repeat != "")
                    break;
            }
        }
    }
    abstract class Currency
    {
        public string _name { get; set; }
        public double ExchangeRate { get; set; }
        public double Convert(Currency currency2, double money)
        {
            return (money / ExchangeRate) * currency2.ExchangeRate;
        }
    }

    class Dollar : Currency
    {
        public Dollar()
        {
            _name = "USD";
            ExchangeRate = 1;
        }
    }
    class RublPMR : Currency
    {
        public RublPMR()
        {
            _name = "RUP";
            ExchangeRate = 16.1;
        }
    }
    class Lei : Currency
    {
        public Lei()
        {
            _name = "MLD";
            ExchangeRate = 17.48129;
        }
    }
    class Hryvnia : Currency
    {
        public Hryvnia()
        {
            _name = "UAH";
            ExchangeRate = 38.23021;
        }
    }
}