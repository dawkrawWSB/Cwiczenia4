using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    internal class SortowanieWybieranie
    {
        public SortowanieWybieranie()
        {
            int[] tablica = { 4, 6, 2, 1, 7, 9, 6, 10 };
            for(int i = 0; i < tablica.Length - 1; i++) 
            {
                int indeksMinimalnej = i;
                for(int j = i +1; j < tablica.Length; j++)
                {
                    if (tablica[j] < tablica[indeksMinimalnej])
                    {
                        indeksMinimalnej = j;
                    }

                }

                int tymczasowa = tablica[indeksMinimalnej];
                tablica[indeksMinimalnej] = tablica[i];
                tablica[i] = tymczasowa;
            }

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }
    }
}
