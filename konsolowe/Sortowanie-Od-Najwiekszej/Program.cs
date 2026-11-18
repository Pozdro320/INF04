using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sortowanie sorter = new Sortowanie();

            Console.WriteLine("Podaj 10 liczb calkowitych do posortowania");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Podaj liczbe nr {i + 1}: ");

                sorter.tablica[i] = int.Parse(Console.ReadLine());
            }

            sorter.SortujMalejaco();

            Console.WriteLine("\nPosortowane liczby (malejace)");

            for(int i = 0; i < 10; i++)
            {
                Console.Write(sorter.tablica[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
