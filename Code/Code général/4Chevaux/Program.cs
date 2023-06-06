using System;
using System.Security;
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
            pixelart mpp = new pixelart();
            ConsoleKeyInfo keyLetter;
            bool verif;
            int gagnant;
            int nbrJoueur;
            int[,] plateau;
            string plateauVisuel;
            plateauVisuel = "";
            string deVisuel;
            int de;
            int pion;
            int player;




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////                                                                         /////////////////////////
            /////////////////////////                          INTRODUCTION                                   /////////////////////////
            /////////////////////////                                                                         /////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            mp.animation();
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
                Console.WriteLine("Et votre but consiste à ce que vos 4 chevaux qui se retrouvent au début à l'écurie");
                Console.WriteLine("font le tour du plateau en suivant le chemin et finir sur la dernière case.");
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
            Console.WriteLine("Combien de joueurs êtes-vous en tout? (2 à 4 joueurs):");
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




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////                                                                         /////////////////////////
            /////////////////////////            LANCEMENT DU JEU                                             /////////////////////////
            /////////////////////////                                                                         /////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            do
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                /////////////////////////                                                                         /////////////////////////
                /////////////////////////            Joueur 1                                                     /////////////////////////
                /////////////////////////                                                                         /////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                player = 1;
                Console.WriteLine(plateauVisuel);
                Thread.Sleep(500);
                Console.WriteLine("\n\n\nAppuyez sur Enter pour que le joueur 1 lance le dé");
                do
                {
                    keyLetter = Console.ReadKey();
                } while (keyLetter.Key != ConsoleKey.Enter);
                Thread.Sleep(100);
                Console.Clear();
                Console.Write("Lancement du dé en cours");
                Thread.Sleep(100);
                Console.Write(".");
                Thread.Sleep(100);
                Console.Write(".");
                Thread.Sleep(100);
                Console.WriteLine(".");
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Red;
                mp.De(out deVisuel, out de);
                Console.WriteLine(deVisuel);
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(500);
                Console.WriteLine("Quel est le numéro de pions que vous souhaitez déplacer? (1 - 2 - 3 - 4):");
                Console.WriteLine(plateauVisuel + "|\n\n\n");
                do
                {
                    keyLetter = Console.ReadKey();
                } while (keyLetter.Key != ConsoleKey.D1 && keyLetter.Key != ConsoleKey.NumPad1 && keyLetter.Key != ConsoleKey.D2 && keyLetter.Key != ConsoleKey.NumPad2 && keyLetter.Key != ConsoleKey.D3 && keyLetter.Key != ConsoleKey.NumPad3 && keyLetter.Key != ConsoleKey.D4 && keyLetter.Key != ConsoleKey.NumPad4);
                if (keyLetter.Key == ConsoleKey.D1 || keyLetter.Key == ConsoleKey.NumPad1)
                {
                    pion = 1;
                } else if (keyLetter.Key == ConsoleKey.D2 || keyLetter.Key == ConsoleKey.NumPad2)
                {
                    pion = 2;
                } else if (keyLetter.Key == ConsoleKey.D3 || keyLetter.Key == ConsoleKey.NumPad3)
                {
                    pion = 3;
                } else
                {
                    pion = 4;
                }

                mp.DeplacementPion(ref plateau, nbrJoueur, pion, player, de);

                Console.Clear();
                
                mp.VerifWin(plateau, nbrJoueur, out verif, out gagnant);
                mp.ConvertirPlateauEnString(nbrJoueur, plateau, out plateauVisuel);

                if (verif == false)
                {
                    player = 2;
                    Console.WriteLine(plateauVisuel);
                    Thread.Sleep(500);
                    Console.WriteLine("\n\n\nAppuyez sur Enter pour que le joueur 2 lance le dé");
                    do
                    {
                        keyLetter = Console.ReadKey();
                    } while (keyLetter.Key != ConsoleKey.Enter);
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.Write("Lancement du dé en cours");
                    Thread.Sleep(100);
                    Console.Write(".");
                    Thread.Sleep(100);
                    Console.Write(".");
                    Thread.Sleep(100);
                    Console.WriteLine(".");
                    Thread.Sleep(500);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    mp.De(out deVisuel, out de);
                    Console.WriteLine(deVisuel);
                    Thread.Sleep(1000);
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.WriteLine("Quel est le numéro de pions que vous souhaitez déplacer? (1 - 2 - 3 - 4):");
                    Console.WriteLine(plateauVisuel + "|\n\n\n");
                    do
                    {
                        keyLetter = Console.ReadKey();
                    } while (keyLetter.Key != ConsoleKey.D1 && keyLetter.Key != ConsoleKey.NumPad1 && keyLetter.Key != ConsoleKey.D2 && keyLetter.Key != ConsoleKey.NumPad2 && keyLetter.Key != ConsoleKey.D3 && keyLetter.Key != ConsoleKey.NumPad3 && keyLetter.Key != ConsoleKey.D4 && keyLetter.Key != ConsoleKey.NumPad4);
                    if (keyLetter.Key == ConsoleKey.D1 || keyLetter.Key == ConsoleKey.NumPad1)
                    {
                        pion = 1;
                    }
                    else if (keyLetter.Key == ConsoleKey.D2 || keyLetter.Key == ConsoleKey.NumPad2)
                    {
                        pion = 2;
                    }
                    else if (keyLetter.Key == ConsoleKey.D3 || keyLetter.Key == ConsoleKey.NumPad3)
                    {
                        pion = 3;
                    }
                    else
                    {
                        pion = 4;
                    }

                    mp.DeplacementPion(ref plateau, nbrJoueur, pion, player, de);

                    Console.Clear();

                    mp.VerifWin(plateau, nbrJoueur, out verif, out gagnant);
                    mp.ConvertirPlateauEnString(nbrJoueur, plateau, out plateauVisuel);

                    if (verif == false)
                    {
                        if(nbrJoueur == 3 || nbrJoueur == 4) {
                            player = 3;
                            Console.WriteLine(plateauVisuel);
                            Thread.Sleep(500);
                            Console.WriteLine("\n\n\nAppuyez sur Enter pour que le joueur 3 lance le dé");
                            do
                            {
                                keyLetter = Console.ReadKey();
                            } while (keyLetter.Key != ConsoleKey.Enter);
                            Thread.Sleep(100);
                            Console.Clear();
                            Console.Write("Lancement du dé en cours");
                            Thread.Sleep(100);
                            Console.Write(".");
                            Thread.Sleep(100);
                            Console.Write(".");
                            Thread.Sleep(100);
                            Console.WriteLine(".");
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.Green;
                            mp.De(out deVisuel, out de);
                            Console.WriteLine(deVisuel);
                            Thread.Sleep(1000);
                            Console.Clear();
                            Thread.Sleep(500);
                            Console.WriteLine("Quel est le numéro de pions que vous souhaitez déplacer? (1 - 2 - 3 - 4):");
                            Console.WriteLine(plateauVisuel + "|\n\n\n");
                            do
                            {
                                keyLetter = Console.ReadKey();
                            } while (keyLetter.Key != ConsoleKey.D1 && keyLetter.Key != ConsoleKey.NumPad1 && keyLetter.Key != ConsoleKey.D2 && keyLetter.Key != ConsoleKey.NumPad2 && keyLetter.Key != ConsoleKey.D3 && keyLetter.Key != ConsoleKey.NumPad3 && keyLetter.Key != ConsoleKey.D4 && keyLetter.Key != ConsoleKey.NumPad4);
                            if (keyLetter.Key == ConsoleKey.D1 || keyLetter.Key == ConsoleKey.NumPad1)
                            {
                                pion = 1;
                            }
                            else if (keyLetter.Key == ConsoleKey.D2 || keyLetter.Key == ConsoleKey.NumPad2)
                            {
                                pion = 2;
                            }
                            else if (keyLetter.Key == ConsoleKey.D3 || keyLetter.Key == ConsoleKey.NumPad3)
                            {
                                pion = 3;
                            }
                            else
                            {
                                pion = 4;
                            }

                            mp.DeplacementPion(ref plateau, nbrJoueur, pion, player, de);

                            Console.Clear();

                            mp.VerifWin(plateau, nbrJoueur, out verif, out gagnant);
                            mp.ConvertirPlateauEnString(nbrJoueur, plateau, out plateauVisuel);

                            if (verif == false) {
                                if(nbrJoueur == 4)
                                {
                                    player = 4;
                                    Console.WriteLine(plateauVisuel);
                                    Thread.Sleep(500);
                                    Console.WriteLine("\n\n\nAppuyez sur Enter pour que le joueur 4 lance le dé");
                                    do
                                    {
                                        keyLetter = Console.ReadKey();
                                    } while (keyLetter.Key != ConsoleKey.Enter);
                                    Thread.Sleep(100);
                                    Console.Clear();
                                    Console.Write("Lancement du dé en cours");
                                    Thread.Sleep(100);
                                    Console.Write(".");
                                    Thread.Sleep(100);
                                    Console.Write(".");
                                    Thread.Sleep(100);
                                    Console.WriteLine(".");
                                    Thread.Sleep(500);
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    mp.De(out deVisuel, out de);
                                    Console.WriteLine(deVisuel);
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Thread.Sleep(500);
                                    Console.WriteLine("Quel est le numéro de pions que vous souhaitez déplacer? (1 - 2 - 3 - 4):");
                                    Console.WriteLine(plateauVisuel + "|\n\n\n");
                                    do
                                    {
                                        keyLetter = Console.ReadKey();
                                    } while (keyLetter.Key != ConsoleKey.D1 && keyLetter.Key != ConsoleKey.NumPad1 && keyLetter.Key != ConsoleKey.D2 && keyLetter.Key != ConsoleKey.NumPad2 && keyLetter.Key != ConsoleKey.D3 && keyLetter.Key != ConsoleKey.NumPad3 && keyLetter.Key != ConsoleKey.D4 && keyLetter.Key != ConsoleKey.NumPad4);
                                    if (keyLetter.Key == ConsoleKey.D1 || keyLetter.Key == ConsoleKey.NumPad1)
                                    {
                                        pion = 1;
                                    }
                                    else if (keyLetter.Key == ConsoleKey.D2 || keyLetter.Key == ConsoleKey.NumPad2)
                                    {
                                        pion = 2;
                                    }
                                    else if (keyLetter.Key == ConsoleKey.D3 || keyLetter.Key == ConsoleKey.NumPad3)
                                    {
                                        pion = 3;
                                    }
                                    else
                                    {
                                        pion = 4;
                                    }

                                    mp.DeplacementPion(ref plateau, nbrJoueur, pion, player, de);

                                    Console.Clear();

                                    mp.VerifWin(plateau, nbrJoueur, out verif, out gagnant);
                                    mp.ConvertirPlateauEnString(nbrJoueur, plateau, out plateauVisuel);
                                }
                            }
                        }
                    }
                }



            } while (verif == false);

            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nous avons un gagnant!");
            Thread.Sleep(200);
            Console.WriteLine("Il s'agit du joueur numéro: \n\n");
            Thread.Sleep(1000);
            if(gagnant == 1)
            {
                mpp.de1(ref deVisuel);
                Console.WriteLine(deVisuel);
            } else if (gagnant == 2)
            {
                mpp.de2(ref deVisuel);
                Console.WriteLine(deVisuel);
            } else if(gagnant == 3) 
            {
                mpp.de3(ref deVisuel);
                Console.WriteLine(deVisuel);
            } else
            {
                mpp.de4(ref deVisuel);
                Console.WriteLine(deVisuel);
            }













        }
    }
}
