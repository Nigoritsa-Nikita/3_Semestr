using System;
using System.Diagnostics;
namespace Ex_4_Upokovki_Raspokovki
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            int a = 1327565;
            stopwatch.Start();
            object o = a;
            stopwatch.Stop();
            long time = stopwatch.ElapsedTicks;
            string packagingTime = String.Format("{0} тиков", time);
            Console.WriteLine("Время упаковки: " + packagingTime);
            stopwatch.Reset();
            stopwatch.Start();
            int b = (int)o;
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks;
            string unpackagingTime = String.Format("{0} тиков", time);
            Console.WriteLine("Время распаковки: " + unpackagingTime);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Нажмите любую клавишу для закрытия окна");
            Console.ReadKey();
        }
    }
}
