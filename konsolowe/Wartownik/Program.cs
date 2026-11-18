using System;
using SzykanieTablicyZWartownikiem;

namespace PrzeszukiwanieZWartownikiem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wyszukiwarka wyszukiwarka = new Wyszukiwarka();

            wyszukiwarka.WypelnijTablice();

            Console.WriteLine("Podaj liczbe z przedzialu 1 - 100: ");
            int szukanaLiczna = int.Parse(Console.ReadLine());

            if (szukanaLiczna >= 0 && szukanaLiczna <= 100) {
                int znalezionyIndex = wyszukiwarka.SzukajZWartownikiem(szukanaLiczna);

                Console.WriteLine("Zawartość tablicy:");
                for(int i = 0; i < Wyszukiwarka.RozmiarDanych; i++)
                {
                    if(i < Wyszukiwarka.RozmiarDanych -1)
                    {
                        Console.WriteLine(wyszukiwarka.tablica[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(wyszukiwarka.tablica[i]);
                    }
                }

                Console.WriteLine("\n");

                if(znalezionyIndex == Wyszukiwarka.RozmiarDanych)
                {
                    Console.WriteLine($"Nie odnaleziono liczby {szukanaLiczna} w tablicy");
                }
                else
                {
                    Console.WriteLine($"Znaleziono liczbę {szukanaLiczna} w tablicy pod indexem {znalezionyIndex}");
                }

            }
            else
            {
                Console.WriteLine("Podaj poprawną wartość");
            }


        }
    }
}