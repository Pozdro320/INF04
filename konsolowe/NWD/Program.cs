using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmEuklidesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euklides euklides = new Euklides();

            int a = 0;
            int b = 0;

            Console.WriteLine("Program obliczający Największy Wspólny Dzielnik NWD(a, b)");

            while (a <= 0)
            {
                Console.Write("Podaj pierwsza liczę cakowitą dodatnią (a)");
                a = int.Parse(Console.ReadLine());

                if (a <= 0)
                {
                    Console.WriteLine("Liczba musi być większa od zera!");
                }
            }

            while (b <= 0)
            {
                Console.Write("Podaj pierwsza liczę cakowitą dodatnią (b)");
                a = int.Parse(Console.ReadLine());

                if (a <= 0)
                {
                    Console.WriteLine("Liczba musi być większa od zera!");
                }
            }

            int wynik = euklides.ObliczNWD(a, b);

            Console.WriteLine($"\nNajwiększy wspólny dzielnik NWD({a}, {b}) = {wynik}");

            Console.ReadKey();
        }
    }
}
