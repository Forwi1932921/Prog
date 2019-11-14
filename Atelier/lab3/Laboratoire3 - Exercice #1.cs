using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static string EncoderPhrase(ref string maPhrase)
        {

            string tabLettre = "";
            for (int i = 0; i­ < maPhrase.Length; i++)
            {
                int valeurASCII = (int)maPhrase[i];
                tabLettre += Char.ConvertFromUtf32( (valeurASCII + 2) );
            }
            Console.WriteLine(tabLettre);


            return maPhrase;
        }
        static void AfficherMostUsedLetter(ref string maPhrase)
        {
            int[] tabLettres = CreerTableauOccurence(maPhrase);

            int mostUsedLetter = 0;
            int position = 0;
            for (int i = 0; i­ < tabLettres.Length; i++)
            {
                if (tabLettres[i] > mostUsedLetter)
                {
                    mostUsedLetter = tabLettres[i];
                    position = i;
                }
            }
            char lettre = Convert.ToChar(position + 97);
            Console.WriteLine("La lettre qui apparaît le plus souvent est le:" + lettre);
        }
        static int[] CreerTableauOccurence(string maPhrase)
        {
            string phraseMinuscule = maPhrase.ToLower();
            int[] tabAlphabet = new int[26];

            for (int i = 0; i < phraseMinuscule.Length; i++)
            {
                int indice = (int)phraseMinuscule[i] - 97;
                if (indice >= 0 && indice < 26)
                    tabAlphabet[indice]++;
            }
            return tabAlphabet;
        }
        static void CalculerNbLettres(ref string maPhrase)
        {
            int[] tabAlphabet = CreerTableauOccurence(maPhrase);

            for (int i = 0; i < tabAlphabet.Length; i++)
            {
                char lettre = Convert.ToChar(i + 97);
                Console.WriteLine("La lettre " + lettre + " apparaît " + tabAlphabet[i] + " fois");
            }


        }
        static void AfficherNbMots(ref string maPhrase)
        {
            string[] tabMots = maPhrase.Split(' ');
            Console.WriteLine(tabMots.Length);

        }
        static int ChoisirOption()
        {
            Console.WriteLine("Veuillez choisir l'option qui vous interesse ");
            Console.WriteLine("1 - Afficher le nombre de mots contenu dans la phrase");
            Console.WriteLine("2 - Afficher combien de fois chaque lettre apparaît");
            Console.WriteLine("3 - Afficher la lettre qui apparaît le plus souvent");
            Console.WriteLine("4 - Encoder la phrase");
            Console.WriteLine("5- Quitter le programme ");
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
                    case 1: AfficherNbMots(ref maPhrase); break;
                    case 2: CalculerNbLettres(ref maPhrase); break;
                    case 3: AfficherMostUsedLetter(ref maPhrase); break;
                    case 4: EncoderPhrase(ref maPhrase); break;
                    case 5: QuitterMenu(); continuer = false; break;
                    default: Console.WriteLine("Cette option n'est pas valide"); break;
                }
            }
        }
    }
}

