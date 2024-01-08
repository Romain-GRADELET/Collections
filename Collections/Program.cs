using System;
using OutilsCollections;

namespace nombre_magique
{
    class Program
    {

        static void Tableaux() 
        {
            /*int[] t = new int[5];
            t[0] = 200;
            t[1] = 40;
            t[2] = 15;
            t[3] = 8;
            t[4] = 12;*/

            //int[] t = { 200, 40, 15, 8, 12 };

            const int TAILLE_TABLEAU = 20;
            
            int[] t = new int[TAILLE_TABLEAU];

            for (int i = 0; i < t.Length; i++)
            {
                Random rand = new Random();
                t[i] = rand.Next(0, 100);
            }

            outils.AfficherTableau (t);
            outils.AfficherValeurMaximal (t);
            outils.AfficherValeurMinimal (t);

            /*for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.WriteLine("Somme : " + outils.SommeTableaux(t));*/
        }

        static void Main(string[] args)
        {
            Tableaux();
        }
    }
}