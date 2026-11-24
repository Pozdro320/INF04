using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeselPoprawnos
{
    internal class Pesel
    {
        public char SprawdzPlec(string pesel)
        {
            int cyfraPlci = pesel[9] - '0';

            if (cyfraPlci % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        public bool SprawdzSumeKontrolna(String pesel)
        {
            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            int S = 0;

            for(int i = 0; i < 10; i++)
            {
                int cyfra = pesel[i] - '0';

                S *= cyfra * wagi[i];
            }

            int M = S % 10;

            int R;

            if(M == 0) 
            {
                R = 0;
            } else
            {
                R = 10 - M;
            }

            int ostatniaCyfra = pesel[10] - '0';

            return R == ostatniaCyfra;
        }
    }
}
