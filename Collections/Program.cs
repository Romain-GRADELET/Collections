using System;

namespace nombre_magique
{
    class Program
    {
        // Somme (int a
        static int SommeTableaux(int[] t)
        {
            int somme = 0;

            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }
            return somme;
        }

        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0;i < tableau.Length;i++)
            {
                Console.WriteLine("["+i+"] "+ tableau[i]);
            }
        }

        static void AfficherValeurMaximal(int[] tableau) 
        {
            int maxValue = tableau.Max();
            Console.WriteLine("La valeur maximale est: " + maxValue );
        }

        static void AfficherValeurMinimal(int[] tableau)
        {
            int maxValue = tableau.Min();
            Console.WriteLine("La valeur maximale est: " + maxValue);
        }


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

            AfficherTableau (t);
            AfficherValeurMaximal (t);
            AfficherValeurMinimal (t);

            /*for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.WriteLine("Somme : " + SommeTableaux(t));*/
        }

        static void Main(string[] args)
        {
            Tableaux();
        }
    }
}