namespace Cwiczenia4
{
    internal class SortowanieWstawianie
    {
        public SortowanieWstawianie()
        {
            int[] tablica = { 4, 6, 2, 1, 7, 9, 6, 10 };
            for (int i = 1; i < tablica.Length - 1; i++)
            {
                int aktualna = tablica[i];
                int wartoscDrugiejPetli = i - 1;

                while(wartoscDrugiejPetli >= 0 && tablica[wartoscDrugiejPetli] > aktualna)
                {
                    tablica[wartoscDrugiejPetli + 1] = tablica[wartoscDrugiejPetli];
                    wartoscDrugiejPetli--;
                }


                tablica[wartoscDrugiejPetli + 1] = aktualna;
            }

            for(int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }
    }
}
