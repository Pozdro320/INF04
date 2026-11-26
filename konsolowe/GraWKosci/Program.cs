using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeselPoprawnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraWKosci gra = new GraWKosci();

            int liczbaKostek = 0;

            while (liczbaKostek < 3 || liczbaKostek > 10)
            {
                Console.WriteLine("Ile kostek chcesz rzucić? (3 - 10)");
                liczbaKostek = int.Parse(Console.ReadLine());
            }

            string decyzja;

            do
            {
                gra.RzucKostami(liczbaKostek);

                for (int i = 0; i < gra.rzuty.Length; i++)
                {
                    Console.WriteLine($"Kostka {i + 1}: {gra.rzuty[i]}");
                }

                Console.WriteLine($"Liczba uzyskanych punktów: {gra.PoliczPunkty()}");

                Console.WriteLine("Jeszcze raz? (t/n)");
                decyzja = Console.ReadLine();
            }
            while (decyzja == "t");

        }
    }
}
