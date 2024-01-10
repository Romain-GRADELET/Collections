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

        public static void AfficherList(List<string> liste, bool ordreDescendant = false)
        {
            if (ordreDescendant == false) 
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine(liste[i]);
                }
            }
            else
            {
                for (int i = liste.Count-1; i >= 0 ; i--)
                {
                    Console.WriteLine(liste[i]);
                }
            }

            string nomLePlusLong = "";
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].Length > nomLePlusLong.Length) 
                {
                    nomLePlusLong = liste[i];
                }
            }

            Console.WriteLine("Le nom le plus long est: " + nomLePlusLong);

        }

        public static void AfficherElementsCommuns(List<string> liste1, List<string> liste2)
        {
            var nomsCommuns = new List<string>(); 
            for(int i = 0; i < liste1.Count; i++)
            {
                string nom1 = liste1[i];
                for (int j = 0; j < liste2.Count; j++)
                {
                    string nom2 = liste2[j];
                    if( nom1 == nom2)
                    {
                        nomsCommuns.Add(nom1);
                    }
                }
            }
            for (int i = 0;i < nomsCommuns.Count; i++)
            {
                Console.WriteLine(nomsCommuns[i]);
            }

        } 





    }
}
