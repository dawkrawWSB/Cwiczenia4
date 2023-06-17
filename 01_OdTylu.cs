namespace Cwiczenia4
{
    internal class OdTylu
    {
        public OdTylu()
        {
            int wielkoscTablicy = 10;
            int[] tablica = new int[wielkoscTablicy];
            for (int i = 0; i < wielkoscTablicy; i++) 
            {
                tablica[i] = Random.Shared.Next(0, 100);
            }

            for(int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }
        }
    }
}
