using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public enum Sorte { Coeur = 1, Pique = 2, Carreau = 3, Trèfle = 4 };
    class Program
    {

        public struct Carte
        {
            public Sorte sorte;
            public int valeur;
            public Carte(Sorte _sorte, int _valeur) : this()
            {
                sorte = _sorte;
                valeur = _valeur;
            }
        }

        static Random generateurNb = new Random();

        static int genererNB(int min, int max)
        {
            return (int)generateurNb.Next(min, max);
        }
        public struct Joueur
        {
            public Carte[] tabCarte;
            public int nbVie;
            public int id;
            public Joueur(int _nbVie, int _id) : this()
            {
                tabCarte = new Carte[3];
                tabCarte[0] = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));
                tabCarte[1] = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));
                tabCarte[2] = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));
                nbVie = _nbVie;
                id = _id;
            }
        }

        static string GetValeurCarte(int valeurCarte)
        {
            string valeurAffiche = "";
            switch (valeurCarte)
            {
                case 1: valeurAffiche = "As"; break;
                case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9: case 10: valeurAffiche = valeurCarte.ToString(); break;
                case 11: valeurAffiche = "Valet"; break;
                case 12: valeurAffiche = "Dame"; break;
                case 13: valeurAffiche = "Roi"; break;
            }
            return valeurAffiche;
        }

        static void AfficherMenu(ref Carte carteCentre)
        {
            Console.WriteLine("Veuillez choisir l'option qui vous interesse ");
            Console.WriteLine("1- Piger une carte ");
            Console.WriteLine("2- Prendre la carte au centre " + "     /     " + "La carte au centre est : " + GetValeurCarte(carteCentre.valeur) + " - " + carteCentre.sorte);
            Console.WriteLine("3- Knock ");


        }
        static void AfficherCarte(Carte[] tabCarte)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Voici vos cartes:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1- " + GetValeurCarte(tabCarte[0].valeur) + " - " + tabCarte[0].sorte);
            Console.WriteLine("2- " + GetValeurCarte(tabCarte[1].valeur) + " - " + tabCarte[1].sorte);
            Console.WriteLine("3- " + GetValeurCarte(tabCarte[2].valeur) + " - " + tabCarte[2].sorte + "\n");

        }

        static void PrendreCarteCentre(ref Carte carteCentre, ref Carte[] tabCarte)
        {
            int choix = 0;

            Console.WriteLine("La carte au centre est : " + GetValeurCarte(carteCentre.valeur) + " - " + carteCentre.sorte);

            Console.WriteLine("Quelle carte voulez vous remplacer la carte du centre?\n");
            AfficherCarte(tabCarte);
            choix = Convert.ToInt32(Console.ReadLine());

            Carte temp;
            temp = tabCarte[choix - 1];
            tabCarte[choix - 1] = carteCentre;
            carteCentre = temp;


        }

        static void PigerCarte(ref Carte[] tabCarte, ref Carte carteCentre, ref Joueur joueur)
        {
            int choix = 0;

            Carte cartePige = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));

            Console.WriteLine("La carte pigée est : " + GetValeurCarte(cartePige.valeur) + " - " + cartePige.sorte);

            AfficherCarte(tabCarte);

            Console.WriteLine("Quelle carte voulez vous remplacer pour la carte pigée? (Veuillez appuyer sur 4 si vous souhaitez discarter la carte pigée\n");


            choix = Convert.ToInt32(Console.ReadLine());


            switch (choix)
            {
                case 1:
                    carteCentre = joueur.tabCarte[0];
                    joueur.tabCarte[0] = cartePige;
                    break;
                case 2:
                    carteCentre = joueur.tabCarte[1];
                    joueur.tabCarte[1] = cartePige;
                    break;
                case 3:
                    cartePige = joueur.tabCarte[2];
                    joueur.tabCarte[2] = cartePige;
                    break;
                case 4:
                    carteCentre = cartePige;
                    break;
            }


        }

        static int AdditionnerPoints(Joueur joueur, ref bool finManche, ref bool dernierTour, ref bool showTotal, int total)
        {
            for (int i = 0; i < joueur.tabCarte.Length; i++)
            {
                switch (joueur.tabCarte[i].valeur)
                {
                    case 1: total += 11; ; break;
                    case 2: total += 2; ; break;
                    case 3: total += 3; ; break;
                    case 4: total += 4; ; break;
                    case 5: total += 5; ; break;
                    case 6: total += 6; ; break;
                    case 7: total += 7; ; break;
                    case 8: total += 8; ; break;
                    case 9: total += 9; ; break;
                    case 10: case 11: case 12: case 13: total += 10; ; break;
                }
            }
            if (showTotal == false)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Le total de vos points est de: " + total);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return total;
        }

        static void Main(string[] args)
        {
            Joueur joueur1 = new Joueur(3, 0);
            Joueur joueur2 = new Joueur(3, 1);
            Carte carteCentre = new Carte((Sorte)genererNB(1, 5), genererNB(1, 14));
            bool finManche = false;
            Joueur joueurActif = joueur1;
            int menu = 0;
            bool knock = false;
            int totalJoueur1 = 0;
            int totalJoueur2 = 0;
            bool dernierTour = false;
            bool showTotal = false;
            int total = 0;

            while (finManche == false)
            {
                if (knock == true)
                {
                    finManche = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("C'est votre dernier tour.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                AfficherCarte(joueurActif.tabCarte);
                AdditionnerPoints(joueurActif, ref finManche, ref dernierTour, ref showTotal, total);
                AfficherMenu(ref carteCentre);
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1: PigerCarte(ref joueurActif.tabCarte, ref carteCentre, ref joueurActif); break;
                    case 2: PrendreCarteCentre(ref carteCentre, ref joueurActif.tabCarte); break;
                    case 3: knock = true; break;
                    default: Console.WriteLine("Cette option n'est pas valide"); break;
                }
                if (finManche == false)
                {
                    if (joueurActif.id == joueur1.id)
                    {
                        joueurActif = joueur2;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("C'est maintenant le tour du joueur 2");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        joueurActif = joueur1;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("C'est maintenant le tour du joueur 1");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

            }

            dernierTour = false;
            finManche = false;
            showTotal = true;
            totalJoueur1 = AdditionnerPoints(joueur1, ref finManche, ref dernierTour, ref showTotal, total);
            totalJoueur2 = AdditionnerPoints(joueur2, ref finManche, ref dernierTour, ref showTotal, total);
            showTotal = false;
            if (totalJoueur1 > totalJoueur2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Le gagnant est le joueur 1!");
                Console.ForegroundColor = ConsoleColor.White;
                joueur2.nbVie -= 1;
            }
            else if (totalJoueur1 < totalJoueur2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Le grand gagnant est le joueur 2!");
                Console.ForegroundColor = ConsoleColor.White;
                joueur1.nbVie -= 1;
            }
            else if (totalJoueur1 == totalJoueur2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("C'est une égalité pour les deux joueurs!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ReadKey();



        }


    }
}
