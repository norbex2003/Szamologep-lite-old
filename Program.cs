using System;

namespace Szamologep_lite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.0 verzió esetében angol nyelv eltávolításra került! Később másik app lesz az angol nyelv");
            Console.WriteLine("Kérek egy számot!");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            double b = Convert.ToInt32(Console.ReadLine());
            double osszeadas = Math.Round(a + b, 4);
            double kivonas = Math.Round(a - b, 4);
            double szorzas = Math.Round(a * b, 4);
            double osztas = Math.Round(a / b, 4);

            //Változókkal való müveletek eredményének a kiiratása!
            Console.WriteLine($"Az összeadásának eredménye: {osszeadas}");
            Console.WriteLine($"A kivonásának eredménye: {kivonas}");
            Console.WriteLine($"A szorzásának eredménye: {szorzas}");
            Console.WriteLine($"Az osztásának eredménye: {osztas}");
            Console.ReadKey();
        }
    }
}
