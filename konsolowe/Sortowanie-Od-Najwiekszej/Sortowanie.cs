using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class Sortowanie
    {

        public int[] tablica = new int[10];

        private int SzukajMaksymalnej(int startIndex)
        {
            int indexMaximum = startIndex;

            for(int i = startIndex; i < tablica.Length; i++)
            {
                if (tablica[i] > tablica[indexMaximum])
                {
                    indexMaximum = i;
                }
            }

            return indexMaximum;
        }

        public void SortujMalejaco()
        {
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                int indexNajwieksza = SzukajMaksymalnej(i);

                int temp = tablica[i];
                tablica[i] = tablica[indexNajwieksza];
                tablica[indexNajwieksza] = temp;
            }
        }
    }
}
