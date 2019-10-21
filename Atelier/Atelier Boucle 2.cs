using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static int ChoisirOption()
        {
            Console.WriteLine("Veuillez choisir l'option qui vous interesse ");
            Console.WriteLine("1- Trouver le plus grand nombre ");
            Console.WriteLine("2- Trouver le plus petit nombre ");
            Console.WriteLine("3- Verifier si le nombre saisi existe dans le tableau ");
            Console.WriteLine("4- Faire la moyenne ");
            Console.WriteLine("5- Vérifier s'il y a un nombre plus grand que 9995 dans le tableau");
            Console.WriteLine("6- Vérifier si un nombre existe plus de 3 fois dans le tableau ");
            Console.WriteLine("7- (Jeu) Guess the number");
            Console.WriteLine("8- Quitter le menu ");
            return Convert.ToInt32(Console.ReadLine());

        }

        static void AfficherPlusGrandNb(ref int[] tab)
        {
            int plusGrandNb = 0;
            for (int i = 0; i­ < tab.Length; i++)
            {
                if (tab[i] > plusGrandNb)
                    plusGrandNb = tab[i];
            }
            Console.WriteLine(plusGrandNb);
        }

        static void AfficherPlusPetitNb(ref int[] tab)
        {
            int plusPetitNb = 10000;
            for (int i = 0; i­ < tab.Length; i++)
            {
                if (tab[i] < plusPetitNb)
                    plusPetitNb = tab[i];
            }
            Console.WriteLine(plusPetitNb);
        }

        static void AfficherNbExiste(ref int[] tab)
        {
            Console.WriteLine("Veuillez entrer votre nombre entier à vérifier");

            int cpt = 0;

            bool nbExistant = false;
            int nbSaisi = Convert.ToInt32(Console.ReadLine());
            while (nbExistant == false && cpt < tab.Length)
            {
                if (nbSaisi == tab[cpt])
                {
                    nbExistant = true;
                }
                else
                {
                    cpt++;
                }

            }

            if (nbExistant == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Le nombre que vous avez saisi existe bel et bien dans le tableau");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Le nombre que vous avez saisi n'existe pas dans le tableau");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }

        static void AfficherNbPlusGrandQue9995(ref int[] tab)
        {

            int cpt = 0;

            bool nbPlusGrandQue9995 = false;
            while (nbPlusGrandQue9995 == false && cpt < tab.Length)
            {
                for (int i = 0; i­ < tab.Length; i++)
                    if (tab[i] <= 10000 && tab[i] >= 9996)
                    {
                        nbPlusGrandQue9995 = true;
                    }
                    else
                    {
                        cpt++;
                    }

            }

            if (nbPlusGrandQue9995 == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Il y a bel et bien un nombre plus grand que 9995 dans le tableau");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Il n'existe pas de nombre plus grand que 9995 dans le tableau");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }

        static void AfficherMoyenne(ref int[] tab)
        {
            int moyenne = 0;
            for (int i = 0; i­ < tab.Length; i++)
            {
                moyenne = moyenne + tab[i];

            }
            moyenne = moyenne / tab.Length;
            Console.WriteLine("La moyenne est de " + moyenne);
        }

        static void QuitterMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Merci d'avoir utiliser le programme ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void AfficherSiNbExistePlusQueTroisFois(ref int[] tab)
        {
            Console.WriteLine("Veuillez entrer votre nombre entier à vérifier (pour savoir s'il existe plus de 3x dans le tableau)");

            int nbVerif = 0;
            int nbSaisi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i­ < tab.Length; i++)
            {
                if (tab[i] == nbSaisi)
                    nbVerif = nbVerif + 1;

            }
            if (nbVerif >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ce nombre existe bel et bien plus de 3 fois dans le tableau");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ce nombre n'existe pas plus de 3 fois dans le tableau");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }
        static void ChoisirDifficulteJeu(ref int choix)
        {
            Console.WriteLine("Choissisez votre difficulté  \n 1 - Facile (1 à 100) \n 2 - Moyen (1 à 1000) \n 3 - Difficile (1 à 10 000)");
            choix = Convert.ToInt32(Console.ReadLine());
        }

        static void GenererNbAleatoire(ref int choixNb, ref int choix, ref Random random)
        {
            if (choix == 1)
            {
                choixNb = random.Next(1, 100);
            }
            else if (choix == 2)
            {
                choixNb = random.Next(1, 1000);
            }
            else if (choix == 3)
            {
                choixNb = random.Next(1, 10000);
            }
        }
        static void DeclarerPrécision(ref int nbIntervalePlus5, ref int nbIntervaleMoins5, ref int choixNb)
        {
            nbIntervalePlus5 = choixNb + 5;
            nbIntervaleMoins5 = choixNb - 5;
        }
        static void TrouverNb(ref int choixNb, ref int nbIntervaleMoins5, ref int nbIntervalePlus5, ref bool check, ref int nbSaisi)
        {

            while (check == false)
            {
                Console.WriteLine("Veuillez entrer votre nombre");
                nbSaisi = Convert.ToInt32(Console.ReadLine());
                if (nbSaisi == choixNb)
                {
                    check = true;
                }
                else if (nbSaisi > choixNb && nbSaisi < nbIntervalePlus5)
                {
                    Console.WriteLine("Vous y êtes presque, mais vous avez viser trop haut");
                }
                else if (nbSaisi < choixNb && nbSaisi > nbIntervaleMoins5)
                {
                    Console.WriteLine("Vous y êtes presque, mais vous avez viser trop bas");
                }
                else if (nbSaisi > choixNb && nbSaisi > nbIntervalePlus5)
                {
                    Console.WriteLine("Vous avez viser trop haut");
                }
                else if (nbSaisi < choixNb && nbSaisi < nbIntervaleMoins5)
                {
                    Console.WriteLine("Vous avez viser trop bas");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Félicitations! Vous êtes parvenu à trouver le nombre!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            int choixNb =0;
            int nbIntervaleMoins5 =1;
            int nbIntervalePlus5 =1;
            bool check =false;
            int nbSaisi =1;
            int choix =1;
            



            Random generateurNb = new Random();
            int[] tab = new int[300];

            for (int i = 0; i­ < tab.Length; i++)
            {
                tab[i] = (int)generateurNb.Next(1, 10001);
            }

            int menu = 0;
            bool continuer = true;

            while (continuer == true)
            {

                menu = ChoisirOption();

                switch (menu)
                {
                    case 1: AfficherPlusGrandNb(ref tab); break;
                    case 2: AfficherPlusPetitNb(ref tab); break;
                    case 3: AfficherNbExiste(ref tab); break;
                    case 4: AfficherMoyenne(ref tab); break;
                    case 5: AfficherNbPlusGrandQue9995(ref tab); break;
                    case 6: AfficherSiNbExistePlusQueTroisFois(ref tab); break;
                    case 7: ChoisirDifficulteJeu(ref choix);
                            GenererNbAleatoire(ref choixNb, ref choix, ref generateurNb);
                            TrouverNb(ref choixNb, ref nbIntervaleMoins5, ref nbIntervalePlus5, ref check, ref nbSaisi);                           
                            DeclarerPrécision(ref nbIntervalePlus5, ref nbIntervaleMoins5, ref choixNb); break;
                    case 8: QuitterMenu(); continuer = false; break;
                    default: Console.WriteLine("Cette option n'est pas valide"); break;
                }
            }
        }
    }
}
