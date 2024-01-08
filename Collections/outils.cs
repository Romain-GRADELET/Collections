using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutilsCollections
{
    static class outils
    {

        public static int SommeTableaux(int[] t)
        {
            int somme = 0;

            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }
            return somme;
        }

        public static void AfficherTableau(int[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }

        public static void AfficherValeurMaximal(int[] tableau)
        {
            int maxValue = tableau.Max();
            Console.WriteLine("La valeur maximale est: " + maxValue);
        }

        public static void AfficherValeurMinimal(int[] tableau)
        {
            int maxValue = tableau.Min();
            Console.WriteLine("La valeur maximale est: " + maxValue);
        }

    }
}
