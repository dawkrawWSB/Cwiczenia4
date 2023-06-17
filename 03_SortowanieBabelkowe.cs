namespace Cwiczenia4
{
    internal class SortowanieBabelkowe
    {
        public SortowanieBabelkowe()
        {
            int[] tablica = { 4, 6, 2, 1, 7, 9, 6, 10 };

            for (int i = 0; i < tablica.Length - 1; i++) 
            { 
                for (int j = 0; j < tablica.Length - i - 1; j++)
                {
                    if (tablica[j] > tablica[j+1])
                    {
                        int tymczasowa = tablica[j];
                        tablica[j] = tablica[j+1];
                        tablica[j+1] = tymczasowa;
                    }
                }
            }


            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }
    }
}
