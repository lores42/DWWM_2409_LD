namespace carte_de_restauration
{
    internal class Program
    {
        public static string Dasylva { get; private set; }
        public static string Lores { get; private set; }

        static void Main(string[] args)
        {
            /*
            //Variable 
                string Nom, Prenom, saisieUtilisateurN, saisieUtilisateurP;
                int credit, solde, Nsolde, debit=4;
                boléan recharhger = true;

            //traitement
                 saisire votre nom
                lire Nom;
                 saiire votre prenom
                lire Prnom
                tantque
                {
                     si (nom == Nom && prenom == Prenom)
                    {
                         afficher idntité valide

                        lire solde
                         si (solde> 4€)
                        {
                            afficher voulez vous prendre un repas
                            si ( oui)
                            {
                               solde-debit == Nsolde
                            }
                        }
                      
                          sinon 
                           {
                            lire solde insufisant veuillez recharger
                                booléan recharger 
                                   si true = veuiilez inséré votre somme
                                    
                           }
                }

                }

                else 
                {
                    afficher identité non valide
                }

            */
            Console.WriteLine("Self du CRM !");

            //Variable
            string Nom ;
            int solde = 3;
            int debit = 4;
            int achat;
            int credit = (solde - debit);
            string saisieUtilisateurN;
            string saisieUtilisateur;
            string saisieSolde;
            bool repas = true;
            bool recharge = true;

            // Traitement 
            string[] NomUtlisateur = new string[5];
            Nom[0] = "Dasylva";
            Nom[1] = "Dupond";
            Nom[2] = "Mendy";
            Nom[3] = "Gomis";
            Nom[4] = "Flin";
                
            Console.WriteLine("Veuillez insérez votre carte !");
            Console.WriteLine(" Entrez votre nom");
            saisieUtilisateurN = Console.ReadLine();

            do
            {

                if (saisieUtilisateurN == Nom)
                {
                    Console.WriteLine("Identité validé");
                    Console.WriteLine();
                    Console.WriteLine("Prendre un repas");

                    repas = true;
                    if (solde >= 4)
                    {
                        Console.WriteLine("vous pouvez prendre votre repas!");
                        Console.WriteLine("votre solde est de : " + credit + "€");

                        credit = solde;
                    }
                }
            }
            
            while (solde < 4)
                {
                    if (!recharge) Console.WriteLine("Solde insufisant veuillez rechargez votre compte !");
                    {

                        Console.WriteLine();
                        Console.WriteLine("Voulez vous rehchargez votre compte");
                        //Console.ReadLine(saisieUtilisateur);
                        ;
                        if (recharge = true) ;
                        {
                            saisieSolde = Console.ReadLine();
                            achat = int.Parse(saisieSolde);
                            achat = solde;
                            Console.WriteLine("votre solde est de : " + solde + "€");
                        }

                    }


                }



                 if (!saisieUtilisateurN == Nom)
            {
                        Console.WriteLine("identité nom valide");
                    }


                
                
        }
    }
}
