using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonction2
{
    class Program
    {
        static void TransformToLowerCase(ref string maPhrase)
        {
            string maPhraseEnMinuscule = maPhrase.ToLower();
            Console.WriteLine(maPhraseEnMinuscule);
        }
        static void TransformToUpperCase(ref string maPhrase)
        {
            string maPhraseEnMajuscule = maPhrase.ToUpper();
            Console.WriteLine(maPhraseEnMajuscule);
        }
        static void AfficherSousPhrase(ref string maPhrase)
        {
            int positionDernierEspace = maPhrase.LastIndexOf(" ");
            string dernierMot = maPhrase.Substring(positionDernierEspace + 1);
            Console.WriteLine(dernierMot);   
        }
        static void CheckLetterEPosition(ref string maPhrase)
        {
            int lettreEPosition = maPhrase.IndexOf("e");
            Console.WriteLine(lettreEPosition);
        }
        static void CheckIfContained(ref string maPhrase)
        {
            if (maPhrase.Contains("octopus") == true)
            {
                Console.WriteLine("La phrase contient bel et bien cet élément");
            }
            else
            {
                Console.WriteLine("La phrase ne contient pas cet élément");
            }
        }
        static void AfficherCharLength(ref string maPhrase)
        {
            Console.WriteLine(maPhrase.Length);
        }
        
        static int ChoisirOption()
        {            
            Console.WriteLine("Veuillez choisir l'option qui vous interesse ");
            Console.WriteLine("1- Afficher la longueur de la chaîne de charactères");
            Console.WriteLine("2- Vérifier si la phrase contient le mot << octopus >>");
            Console.WriteLine("3- Connaître la position de la première lettre E dans la phrase ");
            Console.WriteLine("4- Afficher le dernier mot de la phrase ( sous phrase ) ");
            Console.WriteLine("5- Transformer la phrase en majuscules ");
            Console.WriteLine("6- Transformer la phrase en minisucules ");
            Console.WriteLine("7- Quitter le programme ");
            return Convert.ToInt32(Console.ReadLine());

        }

        static void QuitterMenu()
        {
            Console.WriteLine("Merci d avoir utiliser le programme ");
        }

        static void Main(string[] args)
        {
            string maPhrase = ("The greatest glory in living lies not in never falling, but in rising every time we fall.");
            int choix = 0;
            bool continuer = true;

            while (continuer == true)
            {
                choix = ChoisirOption();

                switch (choix)
                {
                    case 1: AfficherCharLength(ref maPhrase); break;
                    case 2: CheckIfContained(ref maPhrase); break;
                    case 3: CheckLetterEPosition(ref maPhrase); break;
                    case 4: AfficherSousPhrase(ref maPhrase); break;
                    case 5: TransformToUpperCase(ref maPhrase); break;
                    case 6: TransformToLowerCase(ref maPhrase); break;
                    case 7: QuitterMenu(); continuer = false; break;
                    default: Console.WriteLine("Cette option n'est pas valide"); break;
                }
            }




            Console.ReadKey();
        }


    }
}
