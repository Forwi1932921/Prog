using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class Program
    {
        static Random generateurNb = new Random();
        static void Main(string[] args)
        {
            string live6 = @"
                                  +---+
                                  |   |
                                  O   |
                                      |
                                      |
                                      |
                                =========";

            string live5 = @"
                                  +---+
                                  |   |
                                  O   |
                                  |   |
                                      |
                                      |
                                =========";

            string live4 = @"
                                  +---+
                                  |   |
                                  O   |
                                 /|   |
                                      |
                                      |
                                =========";

            string live3 = @"
                                  +---+
                                  |   |
                                  O   |
                                 /|\  |
                                      |
                                      |
                                =========";

            string live2 = @"
                                  +---+
                                  |   |
                                  O   |
                                 /|\  |
                                 /    |
                                      |
                                =========";

            string live1 = @"
                                  +---+
                                  |   |
                                  O   |
                                 /|\  |
                                 / \  |
                                      |
                                =========";

            string gameOver = @"
                                    ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
                                    ███▀▀▀██┼███▀▀▀███┼███▀█▄█▀███┼██▀▀▀
                                    ██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼█┼┼┼██┼██┼┼┼
                                    ██┼┼┼▄▄▄┼██▄▄▄▄▄██┼██┼┼┼▀┼┼┼██┼██▀▀▀
                                    ██┼┼┼┼██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██┼┼┼
                                    ███▄▄▄██┼██┼┼┼┼┼██┼██┼┼┼┼┼┼┼██┼██▄▄▄
                                    ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
                                    ███▀▀▀███┼▀███┼┼██▀┼██▀▀▀┼██▀▀▀▀██▄┼
                                    ██┼┼┼┼┼██┼┼┼██┼┼██┼┼██┼┼┼┼██┼┼┼┼┼██┼
                                    ██┼┼┼┼┼██┼┼┼██┼┼██┼┼██▀▀▀┼██▄▄▄▄▄▀▀┼
                                    ██┼┼┼┼┼██┼┼┼██┼┼█▀┼┼██┼┼┼┼██┼┼┼┼┼██┼
                                    ███▄▄▄███┼┼┼─▀█▀┼┼─┼██▄▄▄┼██┼┼┼┼┼██▄
                                    ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼██┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼████▄┼┼┼▄▄▄▄▄▄▄┼┼┼▄████┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼▀▀█▄█████████▄█▀▀┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼┼┼█████████████┼┼┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼┼┼██▀▀▀███▀▀▀██┼┼┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼┼┼██┼┼┼███┼┼┼██┼┼┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼┼┼█████▀▄▀█████┼┼┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼┼┼┼███████████┼┼┼┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼▄▄▄██┼┼█▀█▀█┼┼██▄▄▄┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼▀▀██┼┼┼┼┼┼┼┼┼┼┼██▀▀┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼▀▀┼┼┼┼┼┼┼┼┼┼┼
                                    ┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼";

            string[] tabMots = { "poney", "triangle", "arbre", "arcade", "monstre", "surpreme", "diamant", "alcool", "anticonstitutionnellement", "yeet" };
            string motATrouver = tabMots[generateurNb.Next(0, 10)];

            char[] tabJeu = new char[motATrouver.Length];

            for(int i = 0; i < tabJeu.Length; i++)
            {
                tabJeu[i] = ('_');
            }


            int lives = 7;
            
            bool wordFound = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Hangman Game");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The word to guess has " + motATrouver.Length + " letters");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have " + lives + " lives");

            while (lives > 0 && wordFound == false)
            {
                bool underscore = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nPlease guess a letter to start the game");
                Console.ForegroundColor = ConsoleColor.White;

                for ( int i = 0; i < tabJeu.Length; i++)
                {
                    Console.Write(tabJeu[i] + " ");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                char lettre = Convert.ToChar(Console.ReadLine());
                bool letterFound = false;

                for (int i = 0; i < tabJeu.Length; i++)
                {
                    if ( motATrouver[i] == lettre)
                    {
                        tabJeu[i] = lettre;
                        letterFound = true;
                    }
                }
                if (letterFound == false)
                {
                    lives--;
                    switch (lives)
                    {
                        case 6: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You have " + lives + " lives"); Console.WriteLine(live6); break;
                        case 5: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You have " + lives + " lives"); Console.WriteLine(live5); break;
                        case 4: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You have " + lives + " lives"); Console.WriteLine(live4); break;
                        case 3: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You have " + lives + " lives"); Console.WriteLine(live3); break;
                        case 2: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You have " + lives + " lives"); Console.WriteLine(live2); break;
                        case 1: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You have " + lives + " lives"); Console.WriteLine(live1); break;
                        case 0: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You lost"); Console.WriteLine(gameOver); break;
                    }

                }
                else
                {
                    for (int i = 0; i < tabJeu.Length; i++)
                    {
                        if ( tabJeu[i] == '_')
                        {
                            underscore = true;
                        }
                    }
                    if (underscore == false)
                    {
                        wordFound = true;
                    }
                    
                }                   
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congrats you have found the hidden word");

            Console.ReadKey();
        }
    }
}
