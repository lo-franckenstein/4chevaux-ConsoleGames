using System;
using System.Threading;

namespace _4Chevaux
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////                                                                         /////////////////////////
            /////////////////////////                          ZONE VARIABLE                                  /////////////////////////
            /////////////////////////                                                                         /////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            appel mp = new appel();
            ConsoleKeyInfo keyLetter;
            int nbrJoueur;
            int[,] plateau;
            string plateauVisuel;
            plateauVisuel = "";




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////                                                                         /////////////////////////
            /////////////////////////                          INTRODUCTION                                   /////////////////////////
            /////////////////////////                                                                         /////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //mp.animation();
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(500);
            Console.WriteLine("WHAT'S UP!");
            Thread.Sleep(250);
            Console.WriteLine("Vous êtes ici pour jouer aux 4 chevaux, alors allons directement au but et commençons donc!\n");
            Thread.Sleep(250);
            Console.WriteLine("Connaissez-vous les règles du jeu ? (O = Oui | N = Non");
            do
            {
                keyLetter = Console.ReadKey();
            } while (keyLetter.Key != ConsoleKey.N && keyLetter.Key != ConsoleKey.O);

            Console.Clear();
            
            if (keyLetter.Key == ConsoleKey.N)
            {
                Console.WriteLine("Les règles sont très simples ! \n");
                Thread.Sleep(500);
                Console.WriteLine("Chaque joueur (Jusque 4 joueurs) possède une écurie (Bleu - Rouge - Vert - Jaune). ");
                Console.WriteLine("Et votre but consiste à ce que vos 4 chevaux qui se retrouvent au début à l'écurie (Il faut faire 6 pour les faire sortir de l'écurie et les placer au début du long chemin)");
                Console.WriteLine("font le tour du plateau en suivant les chemins et en arrivant dans votre couloir et finir sur la dernière case.");
                Console.WriteLine("Quand un cheval arrive sur une case déja occupée par un de ses chevaux,");
                Console.WriteLine("alors il gagne une case en plus tandis que si c'est un cheval qui ne vous appartient pas, vous pouvez renvoyer le cheval dans son écurie et désormais votre cheval vole sa place.");
                Thread.Sleep(500);
                Console.WriteLine("Appuyez sur enter pour continuer...");
                do
                {
                    keyLetter = Console.ReadKey();
                } while (keyLetter.Key != ConsoleKey.Enter && keyLetter.Key != ConsoleKey.D0 && keyLetter.Key != ConsoleKey.NumPad0);
            }


            Thread.Sleep(250);
            Console.Clear();
            Thread.Sleep(250);
            Console.WriteLine("Combien de joueurs êtes-vous en tout? (2 à 4 joueurs");
            do
            {
                keyLetter = Console.ReadKey();
            } while (keyLetter.Key != ConsoleKey.D2 && keyLetter.Key != ConsoleKey.NumPad2 && keyLetter.Key != ConsoleKey.D3 && keyLetter.Key != ConsoleKey.NumPad3 && keyLetter.Key != ConsoleKey.D4 && keyLetter.Key != ConsoleKey.NumPad4);
            Console.Clear();
            Thread.Sleep(500);
            if(keyLetter.Key == ConsoleKey.D2 || keyLetter.Key == ConsoleKey.NumPad2)
            {
                nbrJoueur = 2;
                Console.WriteLine("Voici les joueurs: \n");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[+] Joueur 1: Ecurie Rouge   XXX");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[+] Joueur 2: Ecurie Jaune   HHH");
                plateau = new int[8, 27];
            } else if(keyLetter.Key == ConsoleKey.D3 || keyLetter.Key == ConsoleKey.NumPad3) {
                nbrJoueur = 3;
                Console.WriteLine("Voici les joueurs: \n");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[+] Joueur 1: Ecurie Rouge   XXX");
                Thread.Sleep(200);
                plateau = new int[12, 27];
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[+] Joueur 2: Ecurie Jaune   HHH");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Joueur 3: Ecurie Verte   OOO");

            } else
            {
                nbrJoueur = 4;
                Console.WriteLine("Voici les joueurs: \n");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[+] Joueur 1: Ecurie Rouge   XXX");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[+] Joueur 2: Ecurie Jaune   HHH");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Joueur 3: Ecurie Verte   OOO");
                Thread.Sleep(200);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[+] Joueur 4: Ecurie Bleu    GGG");
                plateau = new int[16, 27];
            }
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voici le plateau:\n");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////                                                                         /////////////////////////
            /////////////////////////            ZONE DEFINITION PREMIERE DES PREMIERES PLACES                /////////////////////////
            /////////////////////////                                                                         /////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            mp.AttributionStart(nbrJoueur, ref plateau);
            mp.ConvertirPlateauEnString(nbrJoueur, plateau, out plateauVisuel);
            Console.WriteLine(plateauVisuel);









            //mp.GenerationPlateau(nbrJoueur, ref plateau, out plateauVisuel);
            //mp.ConvertirPlateauEnString(plateau, out plateauVisuel);
            //Console.WriteLine(plateauVisuel);










        }
    }
}
