using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static int ChoisirOption()
        {
            Console.WriteLine("Veuillez choisir l'option qui vous interesse ");
            Console.WriteLine("1- Décrypter le message ");
            Console.WriteLine("2- Encrypter un message ");
            Console.WriteLine("3- Quitter le menu ");
            return Convert.ToInt32(Console.ReadLine());

        }
        static string Krypt()
        {
            Console.WriteLine("Veuillez saisir votre message à encrypter");
            string messageEncrypt = Console.ReadLine();

            string tabLettre = "";
            for (int i = 0; i­ < messageEncrypt.Length; i++)
            {
                int valeurASCII = (int)messageEncrypt[i];
                tabLettre += Char.ConvertFromUtf32( (valeurASCII + 1) );
            }
            Console.WriteLine(tabLettre);


            return messageEncrypt;
        }
        static void Dekrypt()
        {
            string message = "Mb`qsph`d`ftu`m(gvo";
            string[] tabLettre = new string[message.Length];
            for (int i = 0; i­ < message.Length; i++)
            {
                int valeurASCII = (int)message[i];
                tabLettre[i] += Char.ConvertFromUtf32(valeurASCII - 1);
            }

            for (int i = 0; i­ < message.Length; i++)
            {
                Console.WriteLine(tabLettre[i]);
            }
        }

        static void QuitterMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Merci d'avoir utiliser le programme ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            int menu = 0;
            bool continuer = true;

            while (continuer == true)
            {

                menu = ChoisirOption();

                switch (menu)
                {
                    case 1: Dekrypt(); break;
                    case 2: string messageEncrypt = Krypt(); break;
                    case 3: QuitterMenu(); continuer = false; break;
                    default:
                        Console.WriteLine("Cette option n'est pas valide"); break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
