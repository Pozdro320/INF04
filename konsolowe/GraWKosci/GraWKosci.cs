using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeselPoprawnos
{
    internal class GraWKosci
    {
        public int[] rzuty;

        private Random losuj = new Random();

        public void RzucKostami(int liczbaKostek)
        {
            rzuty = new int[liczbaKostek];

            for(int i = 0; i < liczbaKostek; i++)
            {
                rzuty[i] = losuj.Next(1, 7);
            }
        }

        public int PoliczPunkty()
        {
            int[] zliczanie = new int[7];

            for (int i = 0; i < rzuty.Length; i++)
            {
                int oczko = rzuty[i];
                zliczanie[oczko]++;
            }

            int sumaPunktow = 0;

            for (int oczko = 0; oczko <= 6; oczko++)
            {
                if (zliczanie[oczko] >= 2)
                {
                    sumaPunktow += oczko * zliczanie[oczko];
                }
            }

            return sumaPunktow;
        }
    }
}
