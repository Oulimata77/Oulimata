using System;
using System.Collections.Generic;

namespace Tpnote
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bienvenue dans l'appli de gestion des villes");
            Console.WriteLine("Que voulez vous faire");
            Console.WriteLine("1.Créer une nouvelle ville");
            Console.WriteLine("2.Afficher l'ensemble des villes");
            Console.WriteLine("Comment t'appelles-tu ?");


            List<string> listeNom= new List<string>();
            List<int > listeCodePostal = new List<int>();
            List<int> listeNbhabitant = new List<int>();


            // demande de ville
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Quel est votre choix?");
                string choix;
                choix = Console.ReadLine();
                
                Ville v = new Ville();
                v.Nom = Console.ReadLine();

                listeNom.Add(v.Nom);
                
                string message;
                message = CreerMessage(v.Nom, v.CodePostal, v.Nbhabitant);
                
                // demande de le code postal
                v.CodePostal = DemandeEntier("Quel est votre code postal?");
                v.Nbhabitant = DemandeEntie("Combien d'habitant?");
                // construction du message
                
                
                // affichage du message
                Console.WriteLine(message);
            }
            // afficher tous les Nom saisis
            foreach (string Nom in listeNom)
            {
                Console.WriteLine(Nom);
            }

            // pour laisser la fenetre ouverte et attendre 
            // que l'utilisateur ferme
            Console.ReadKey();
        }

        public static string CreerMessage(string Nom, int CodePostal ,int Nbhabitant)
        {
            string message;
           

            message = Nom + CodePostal + Nbhabitant;
            return message;
        }


        public string Choix(string Nom , int CodePostal,string Nbhabitant)
        {
            string message;
            message = Console.ReadLine();

            if (message=="1")
            {

                Console.WriteLine( Nom + CodePostal + Nbhabitant);
            }
            else if
                (message=="2")
            {
                Console.WriteLine("Ensemble des villes");
            }
            return message;
        }

        public static int DemandeEntier(string message)
        {
            Console.WriteLine(message);
            string CodePostal;
            CodePostal = Console.ReadLine();
            int intValue;
            while (!int.TryParse(CodePostal, out intValue))
            {
                Console.WriteLine("la saisie est invalide");
                CodePostal = Console.ReadLine();
            }
            return intValue;
        }
        public static int DemandeEntie(string message)
        {
            Console.WriteLine(message);
            string NbHabitant;
            NbHabitant = Console.ReadLine();
            int intValue;
            while (!int.TryParse(NbHabitant, out intValue))
            {
                Console.WriteLine("la saisie est invalide");
                NbHabitant= Console.ReadLine();
            }
            return intValue;
        }

    }
}
//J'ai fait mais je ne sais pas si c'est bon ou pas mais j'ai fait de mon mieux