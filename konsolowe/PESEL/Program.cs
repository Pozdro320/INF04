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
            string pesel = "55030101193";

            Pesel peselSprawdz = new Pesel();

            Console.Write($"Sprawdzany pesel: {pesel}");

            char plec = peselSprawdz.SprawdzPlec(pesel);

            if(plec == 'K')
            {
                Console.Write($"Pesel należy do kobiety!");
            } else
            {
                Console.Write($"Pesel należy do męzczyzny!");
            }

            bool sumaKonroli = peselSprawdz.SprawdzSumeKontrolna(pesel);

            if (sumaKonroli)
            {
                Console.Write($"Pesel jest poprawny!");
            }
            else
            {
                Console.Write($"Pesel jest niepoprawny!");
            }
        }
    }
}
