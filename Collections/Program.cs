using System;
using System.Collections;
using Microsoft.VisualBasic;
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

        static void ArrayList()
        {
            // ArrayList est très peu utilisé car ce n'est pas une bonne pratique de mixer les types
            ArrayList a = new ArrayList();
            a.Add("toto"); // nom
            a.Add(49); // age
            a.Add(true); // homme

            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            // Object
            var nom = a[0];
            int age = (int)a[1]; // cast => consiste à force le typage
            age++;

            Console.WriteLine("nom de la personne : " + nom);
            Console.WriteLine("age de la personne : " + age);
        }

        static void ListeDeListes()
        {
            /*var villes = new List<string>();
            villes.Add("France : Paris, Toulouse, Nice, Bordeaux, Lille");
            villes.Add("Etats-unis: New-York, Chicago, Los Angeles, San Fransisco");
            villes.Add("Espagne : Madrid, Barcelone, Séville");
            villes.Add("Italie : Venise, Florence, Milan, Pise");*/

            var pays = new List<List<string>>();

            pays.Add(new List<string>() { "France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" });
            pays.Add(new List<string>() { "Etats-unis", "New-York", "Chicago", "Los Angeles", "San Fransisco" });
            pays.Add(new List<string>() { "Espagne", "Madrid", "Barcelone", "Séville" });
            pays.Add(new List<string>() { "Italie", "Venise", "Florence", "Milan", "Pise" });

            for(int i = 0;i < pays.Count; i++)
            {
                var p = pays[i];
                Console.WriteLine(p[0] + " - " + (p.Count-1) + " villes");
                for(int j = 1; j < p.Count; j++)
                {
                    Console.WriteLine("  "+ p[j]);
                }
                Console.WriteLine();
            }
        }

        static void Dictionnaire()
        {

            string personneAChercher = "Martin";
            //Dictionary
            // Clef -> valeur
            // Nom -> Numéro de téléphone "+33"

            var d = new Dictionary<string, string>();
            d.Add("Jean", "0679864591");
            d.Add("Marie", "0688252625");
            d["Martin"] = "0679894565";

            if (d.ContainsKey(personneAChercher))
            {
                Console.WriteLine(d[personneAChercher]);
            }
            else
            {
                Console.WriteLine("Cette personne n'a pas été trouvée");
            }

            // ----------------------------------------------------------
            // Déprécié car ne sera pas optimisé pour des grosses recherche
            // ----------------------------------------------------------
            /*var l = new List<string[]>();
            l.Add(new string[] { "Jean", "0679864591" });
            l.Add(new string[] { "Marie", "0688252625" });
            l.Add(new string[] { "Martin", "0679894565" });

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i][0] == personneAChercher)
                {
                    Console.WriteLine(l[i][1]);
                    break;
                }
            }*/
            // -----------------------------------------------------------

        }

        static void BoucleForEach()
        {
            //var noms = new string[] { "Toto", "Jean", "Pierre" };
            //var noms = new List<string> { "Toto", "Jean", "Pierre" };

            // Boucle For
            /*for(int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine(noms[i]);
            }*/

            var d = new Dictionary<string, string>();
            d.Add("Jean", "0679864591");
            d.Add("Marie", "0688252625");
            d["Martin"] = "0679894565";

            foreach (var nom in d)
            {
                Console.WriteLine(nom.Key + " -> " + nom.Value);
            }

        }

        static void TrisEtLinq()
        {
            var noms = new List<string> { "Toto", "Jean", "Pierre", "Vincent", "Anne", "Romain" };
            // Tris dans l'ordre alphabétique croissant
            //noms.Sort();

            // Tris dans l'ordre alphabétique croissant
            //var nomsTries = noms.OrderBy(nom => nom);

            // Tris dans l'ordre alphabétique décroissant
            //var nomsTries = noms.OrderByDescending(nom => nom);

            // Tris en fonction du nombre de caractère
            //var nomsTries = noms.OrderBy(nom => nom.Length);

            //noms = noms.OrderBy(nom => nom).ToList(); // Tri par ordre alphabétique
            //noms = noms.Where(nom => nom[nom.Length -1] == 'e').ToList(); // Sélectionne uniquement les chaines se terminant par un e


            /*foreach (var nom in noms)
            {
                Console.WriteLine(nom);
            }*/

            var notes = new List<int>() {4, 6, 8, 2, 3, 7, 12, 11, 20 };
            notes = notes.OrderBy(note => note).ToList(); // Tris ordre croissant
            notes = notes.Where(note => note >= 10).ToList(); // Affiche les notes >= 10

            foreach (var note in notes)
            {
                Console.WriteLine(note);
            }

        }

        static void MaFonction(int p)
        {
            p = 10;
        }

        static void MaFonction2(List<int> p)
        {
            p[0] = 10;
        }

        static void PassageValeurOuRef()
        {
            /*int a = 5;
            MaFonction(a);*/

            var l = new List<int> { 5 };
            MaFonction2(l); 

            Console.WriteLine(l);
        }

        static void Main(string[] args)
        {
            //Tableaux();
            //Listes();
            //ListesCommunes();
            //ArrayList();
            //ListeDeListes();
            //Dictionnaire();
            //BoucleForEach();
            //TrisEtLinq();
            PassageValeurOuRef();
        }
    }
}