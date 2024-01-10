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

            outils.AfficherTableau(t);
            outils.AfficherValeurMaximal(t);
            outils.AfficherValeurMinimal(t);

            /*for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.WriteLine("Somme : " + outils.SommeTableaux(t));*/
        }

        static void Listes()
        {
            /*List<int> liste = new List<int>();
            liste.Add(5);
            liste.Add(8);
            liste.Add(2);
            liste.Add(2);
            liste.Add(2);

            // Ajoute 1 à la valeur ayant pour index 2
            liste[2]++;

            // Supprime la première occurence avec valeur 8:
            liste.Remove(8);

            // Supprime la valeur avec l'index 2:
            liste.RemoveAt(2);


            outils.AfficherList(liste);*/

            //List<string> noms = new List<string>();
            var noms = new List<string>() { "jean", "Paul" };

            while (true)
            {
                Console.Write("Rentrez un nom (ENTRER pour valider)");
                string nom = Console.ReadLine();

                if (nom == "")
                {
                    break;
                }

                if (noms.Contains(nom))
                {
                    Console.WriteLine("ERREUR: Le nom est déjà dans la liste");
                    Console.WriteLine();
                }
                else
                {
                    noms.Add(nom);
                }


                // filtrer : Supprimer tout les noms qui se termine par "e"
                // remove At / Longueur de la liste altéré
                // Boucler en partant de la fin

                /*for (int i = noms.Count - 1; i >= 0; i--)
                {
                    string nom = noms[i];
                    if (nom[nom.Length-1] == 'e')
                    {
                        noms.RemoveAt(i);
                    }
                }

                outils.AfficherList(noms, true);*/

                // GetRange(0, 3) permet de récupéré les 3 noms à partir du nom ayant l'index 0
                List<string> lesPremiersNoms = noms.GetRange(0, 3);
                outils.AfficherList(lesPremiersNoms);
            }
            
        }
        static void ListesCommunes()
        {
            var liste1 = new List<string>() { "Paul", "Jean", "Pierre", "Emilie", "Martin" };
            var liste2 = new List<string>() { "Sophie", "Jean", "Martin", "toto" };

            outils.AfficherElementsCommuns(liste1, liste2);
        }

        static void Main(string[] args)
        {
            //Tableaux();
            //Listes();
            //ListesCommunes();
        }
    }
}