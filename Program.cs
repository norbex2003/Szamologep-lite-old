using System;

namespace Szamologep_lite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot!");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérek még egy számot!");
            double b = Convert.ToInt32(Console.ReadLine());
            double osszeadas = Math.Round(a + b, 4);
            double kivonas = Math.Round(a - b, 4);
            double szorzas = Math.Round(a * b, 4);
            double osztas = Math.Round(a / b, 4);
            
            if (osztas == 0 && szorzas == 0)
            {
                Console.WriteLine("A nullával való osztásnak nincs értelme");
                Console.WriteLine("A nullával való szorzásnak nincs értelme");
            }


            if (osztas !=0 && szorzas !=0)
            {
                Console.WriteLine($"Az osztásának eredménye: {osztas}");
                Console.WriteLine($"A szorzásának eredménye: {szorzas}");
            }

            

            //Változókkal való müveletek eredményének a kiiratása!
            Console.WriteLine($"Az összeadásának eredménye: {osszeadas}");
            Console.WriteLine($"A kivonásának eredménye: {kivonas}");
            Console.ReadKey();
        }
    }
}