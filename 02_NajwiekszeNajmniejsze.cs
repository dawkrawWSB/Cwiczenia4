using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia4
{
    internal class NajwiekszeNajmniejsze
    {
        public NajwiekszeNajmniejsze()
        {
            int[] tablica = { 4, 6, 2, 1, 7, 9, 6, 10 };
            int najmniejszaLiczba = int.MaxValue;
            int najwiekszaLiczba = int.MinValue;
            for(int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > najwiekszaLiczba)
                {
                    najwiekszaLiczba = tablica[i];
                }

                if (tablica[i] < najmniejszaLiczba)
                {
                    najmniejszaLiczba = tablica[i];
                }
            }

            Console.WriteLine($"Najmniejsza: {najmniejszaLiczba} najwieksza: {najwiekszaLiczba}");
        }
    }
}
