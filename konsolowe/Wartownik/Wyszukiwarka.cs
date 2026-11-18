using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzykanieTablicyZWartownikiem
{
    internal class Wyszukiwarka
    {
        public const int RozmiarDanych = 50;
        public int[] tablica = new int[RozmiarDanych + 1];

        public void WypelnijTablice()
        {
            Random losuj = new Random();

            for(int i = 0; i < RozmiarDanych; i++)
            {
                tablica[i] = losuj.Next(1, 101);
            }
        }

        public int SzukajZWartownikiem(int szukane)
        {
            tablica[RozmiarDanych] = szukane;

            int i = 0;

            while (tablica[i] != szukane)
            {
                i++;
            }

            return i;
        }
    }
}
