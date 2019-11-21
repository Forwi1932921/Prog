using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static char[] tabJeu = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int joueur = 1; 

        static int choix;

        static int verificateur;

        static int VerifWin()
        {
            if (tabJeu[1] == tabJeu[2] && tabJeu[2] == tabJeu[3])

            {
                return 1;
            }
            else if (tabJeu[4] == tabJeu[5] && tabJeu[5] == tabJeu[6])
            {
                return 1;
            }
            else if (tabJeu[6] == tabJeu[7] && tabJeu[7] == tabJeu[8])
            {
                return 1;
            }
            else if (tabJeu[1] == tabJeu[4] && tabJeu[4] == tabJeu[7])
            {           
                return 1;
            }
            else if (tabJeu[2] == tabJeu[5] && tabJeu[5] == tabJeu[8])
            {
                return 1;
            }
            else if (tabJeu[3] == tabJeu[6] && tabJeu[6] == tabJeu[9])
            {
                return 1;
            }
            else if (tabJeu[1] == tabJeu[5] && tabJeu[5] == tabJeu[9])
            {
                return 1;
            }
            else if (tabJeu[3] == tabJeu[5] && tabJeu[5] == tabJeu[7])
            {
                return 1;
            }
            else if (tab[1] == tab[5] && tab[5] == tab[9])
            {
                return 1;
            }
            else if (tab[3] == tab[5] && tab[5] == tab[7])
            {
                return 1;
            }
            else if (tabJeu[1] != '1' && tabJeu[2] != '2' && tabJeu[3] != '3' && tabJeu[4] != '4' && tabJeu[5] != '5' && tabJeu[6] != '6' && tabJeu[7] != '7' && tabJeu[8] != '8' && tabJeu[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            AfficherTableau();
            bool finPartie = false;
            bool alreadyUsed = false;
            
            while (finPartie == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Joueur 1: X   |   Joueur 2: O");
                Console.ForegroundColor = ConsoleColor.White;

                if ( joueur == 1)
                {
                    Console.WriteLine("C'est au tour du joueur 1");
                    while (alreadyUsed == false)
                    {
                        Console.WriteLine("Choisissez votre case");
                        choix = Convert.ToInt32(Console.ReadLine());
                        if (tabJeu[choix] != 'X' && tabJeu[choix] != 'O')
                        {
                            tabJeu[choix] = 'X';
                            joueur = joueur + 1;
                            alreadyUsed = true;
                        }
                        else
                        {
                            Console.WriteLine("\n Cette case est déjà utilisée, veuillez en choisir une autre!");
                        }
                    }
                    alreadyUsed = false;

                    Console.Clear();
                    AfficherTableau();

                    verificateur = VerifWin();
                    if ( verificateur == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Félicitations, vous avez gagné la partie!");
                        Console.ForegroundColor = ConsoleColor.White;

                        finPartie = true;
                    }
                    else if ( verificateur == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("C'est une égalité pour les deux joueurs!");
                        Console.ForegroundColor = ConsoleColor.White;

                        finPartie = true;
                    }

                }
                else
                {
                    Console.WriteLine("C'est au tour du joueur 2");
                    while (alreadyUsed == false)
                    {
                        Console.WriteLine("Choisissez votre case");
                        choix = Convert.ToInt32(Console.ReadLine());
                        if (tabJeu[choix] != 'X' && tabJeu[choix] != 'O')
                        {
                            tabJeu[choix] = 'O';
                            joueur = joueur - 1;
                            alreadyUsed = true;
                        }
                        else
                        {
                            Console.WriteLine("\n Cette case est déjà utilisée, veuillez en choisir une autre!");
                        }
                    }
                    alreadyUsed = false;

                    Console.Clear();
                    AfficherTableau();

                    if (verificateur == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Félicitations, vous avez gagné la partie!");
                        Console.ForegroundColor = ConsoleColor.White;

                        finPartie = true;
                    }
                    else if (verificateur == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("C'est une égalité pour les deux joueurs!");
                        Console.ForegroundColor = ConsoleColor.White;

                        finPartie = true;
                    }
                }

            }
        }

        static void AfficherTableau()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("     |     |      ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  {0}  |  {1}  |  {2}", tabJeu[1], tabJeu[2], tabJeu[3]);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  {0}  |  {1}  |  {2}", tabJeu[4], tabJeu[5], tabJeu[6]);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  {0}  |  {1}  |  {2}", tabJeu[7], tabJeu[8], tabJeu[9]);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("     |     |      ");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
