using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public static Ore[] tabOres = new Ore[5];
        public struct Ore
        {
            public string nom;
            public double resistance;
            public double pointFusion;
            public double poids;
            public double conductivite;

            public Ore(string _nom, double _resistance, double _pointFusion, double _poids, double _conductivite) : this()
            {
                nom = _nom;
                resistance = _resistance;
                pointFusion = _pointFusion;
                poids = _poids;
                conductivite = _conductivite;
            }
        }
        static void Main(string[] args)
        {

            tabOres[0] = new Ore("Fer", 7, 9, 4, 3);
            tabOres[1] = new Ore("Cuivre", 4, 8, 8, 2);
            tabOres[2] = new Ore("Plomb", 1, 3, 7, 2);
            tabOres[3] = new Ore("Zinc", 2, 5, 3, 6);

            int menu = 0;
            bool continuer = true;

            while (continuer == true)
            {

                AfficherMenu();
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1: ConnaitrePireResistance(); Console.ReadKey(); break;
                    case 2: AfficherMoyenneCote(); Console.ReadKey(); break;
                    case 3: AfficherPointFusionPlusGrandQue8(); Console.ReadKey(); break;
                    case 4: CreateAlloy(); Console.ReadKey(); break;
                    case 5: QuitterMenu(); continuer = false; break;
                    default: Console.WriteLine("Cette option n'est pas valide"); break;
                }
            }
        }
        static void AfficherMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Veuillez choisir l'une des options suivantes : \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1- Connaître le métal avec la pire résistance");
            Console.WriteLine("2- Connaître le métal avec le meilleur score (moyenne de tous les cotes, doit être le plus près de 5)");
            Console.WriteLine("3- Savoir si un métal avec un point de fusion supérieur de plus de 8 existe");
            Console.WriteLine("4- Créer un nouvel alliage");
            Console.WriteLine("5- Quitter le programme");


        }
        static void QuitterMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Merci d'Avoir utilisé le programme!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(true);
        }
        static void ConnaitrePireResistance()
        {
            double pireResistance = 10000;
            string nom = "";
            for (int i = 0; i­ < tabOres.Length; i++)
            {
                if (tabOres[i].resistance < pireResistance)
                {
                    pireResistance = tabOres[i].resistance;
                    nom = tabOres[i].nom;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Le métal ayant la pire resistance est le : " + nom + " et sa résistance est de : " + pireResistance);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void AfficherMoyenneCote()
        {
            
            string nom = "";
            double moyenne = 0;
            double[] tabMoyenne = new double[4];
            for (int i = 0; i­ < tabOres.Length; i++)
            {
                tabMoyenne[0] = tabOres[0].resistance + tabOres[0].pointFusion + tabOres[0].poids + tabOres[0].conductivite;
                tabMoyenne[1] = tabOres[1].resistance + tabOres[1].pointFusion + tabOres[1].poids + tabOres[1].conductivite;
                tabMoyenne[2] = tabOres[2].resistance + tabOres[2].pointFusion + tabOres[2].poids + tabOres[2].conductivite;
                tabMoyenne[3] = tabOres[3].resistance + tabOres[3].pointFusion + tabOres[3].poids + tabOres[3].conductivite;
            }

            double plusGrandNb = 0;
            for (int i = 0; i­ < tabMoyenne.Length; i++)
            {
                if (tabMoyenne[i] > plusGrandNb)
                {
                    plusGrandNb = tabMoyenne[i];
                    nom = tabOres[i].nom;
                }
            }

            moyenne = plusGrandNb / 4;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Le métal ayant le meilleur score est le : " + nom + " et sa cote est de : " + moyenne);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void AfficherPointFusionPlusGrandQue8()
        {

            int cpt = 0;

            bool pointFusionPlusGrandQue8 = false;
            while (pointFusionPlusGrandQue8 == false && cpt < tabOres.Length)
            {
                for (int i = 0; i­ < tabOres.Length; i++)
                    if (tabOres[i].pointFusion > 8)
                    {
                        pointFusionPlusGrandQue8 = true;
                    }
                    else
                    {
                        cpt++;
                    }

            }

            if (pointFusionPlusGrandQue8 == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Il y a bel et bien un métal ayant un point de fusion plus grand que 8");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Il n'y a pas de métal ayant un point de fusion plus grand que 8");
                Console.ForegroundColor = ConsoleColor.White;
            }


        }
        static void CreateAlloyMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Veuillez choisir deux métaux dans la liste ci-dessous\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1- Fer");
            Console.WriteLine("2- Cuivre");
            Console.WriteLine("3- Plomb");
            Console.WriteLine("4- Zinc");


        }
        static void CreateAlloy()
        {
            string stringMetal1 = "";
            string stringMetal2 = "";
            int metal1, metal2 = 0;
            double pourcentage1, pourcentage2 = 0;

            CreateAlloyMenu();
            metal1 = Convert.ToInt32(Console.ReadLine());
            CreateAlloyMenu();
            metal2 = Convert.ToInt32(Console.ReadLine());

            if (metal1 == metal2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Veuillez ne pas choisir deux fois les mêmes métaux");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (metal1 == 1)
            {
                stringMetal1 = metal1.ToString();
                stringMetal1 = "fer";
            }
            else if (metal1 == 2)
            {
                stringMetal1 = metal1.ToString();
                stringMetal1 = "cuivre";
            }
            else if (metal1 == 2)
            {
                stringMetal1 = metal1.ToString();
                stringMetal1 = "plomb";
            }
            else
            {
                stringMetal1 = metal1.ToString();
                stringMetal1 = "zinc";
            }

            if (metal2 == 1)
            {
                stringMetal2 = metal2.ToString();
                stringMetal2 = "fer";
            }
            else if (metal2 == 2)
            {
                stringMetal2 = metal2.ToString();
                stringMetal2 = "cuivre";
            }
            else if (metal2 == 2)
            {
                stringMetal2 = metal2.ToString();
                stringMetal2 = "plomb";
            }
            else
            {
                stringMetal2 = metal2.ToString();
                stringMetal2 = "zinc";
            }


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Quel pourcentage de l'alliage voudriez-vous donner au premier metal choisi ?");
            Console.ForegroundColor = ConsoleColor.White;
            pourcentage1 = Convert.ToInt32(Console.ReadLine());

            if(pourcentage1 > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Veuillez ne pas choisir un pourcentage plus grand que 100");
                Console.ForegroundColor = ConsoleColor.White;
            }

            pourcentage2 = 100 - pourcentage1;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Votre alliage est composé de " + pourcentage1 + "% de " + stringMetal1 + " et " + pourcentage2 + "% de " + stringMetal2);
            Console.ForegroundColor = ConsoleColor.White;

            string nomAlloy = "";

            if(pourcentage1>pourcentage2)
                nomAlloy = tabOres[metal1 - 1].nom + tabOres[metal2 - 1].nom[0];
            else
                nomAlloy = tabOres[metal2 - 1].nom + tabOres[metal1 - 1].nom[0];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVotre alliage se nomme : " + nomAlloy);
            Console.ForegroundColor = ConsoleColor.White;


            double resistanceAlloy1, resistanceAlloy2, resistanceAlloyFinal = 0;
            if (metal1 == 1)
            {
                resistanceAlloy1 = tabOres[0].resistance * (pourcentage1 / 100);
            }
            else if (metal1 == 2)
            {
                resistanceAlloy1 = tabOres[1].resistance * (pourcentage1 / 100);
            }
            else if (metal1 == 3)
            {
                resistanceAlloy1 = tabOres[2].resistance * (pourcentage1 / 100);
            }
            else
            {
                resistanceAlloy1 = tabOres[3].resistance * (pourcentage1 / 100);
            }

            if (metal2 == 1)
            {
                resistanceAlloy2 = tabOres[0].resistance * (pourcentage2 / 100);
            }
            else if (metal2 == 2)
            {
                resistanceAlloy2 = tabOres[1].resistance * (pourcentage2 / 100);
            }
            else if (metal2 == 3)
            {
                resistanceAlloy2 = tabOres[2].resistance * (pourcentage2 / 100);
            }
            else
            {
                resistanceAlloy2 = tabOres[3].resistance * (pourcentage2 / 100);
            }

            resistanceAlloyFinal = resistanceAlloy1 + resistanceAlloy2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nLa résistance de votre alliage est de " + resistanceAlloyFinal);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
