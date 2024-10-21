namespace exercice_collections
{
    internal class Utilisateur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donner son métier ou sa couleur préférée !");

            //Variable
            string saisieNomPrenom;
            string saisieDate;
            string? metierCouleur = null;
            ConsoleKey continuerO_N;
            List<Utilisateur> utilisateurs = new();

            //Traitement
            do
            {

                try
                {
                    Console.WriteLine("Saisissez le nom et Prénom.");
                    saisieNomPrenom = Console.ReadLine();

                    Console.WriteLine("Saisisez la date de naissance, jour / mois / année.");
                    saisieDate = Console.ReadLine();

                    Utilisateur unUtilisateur = new Utilisateur(saisieNomPrenom, saisieDate);

                    if (unUtilisateur.isMajeur())
                    {
                        Console.WriteLine("Quel votre métier ?");
                        metierCouleur = Console.ReadLine();
                        unUtilisateur.SetMetier(metierCouleur);
                    }

                    else
                    {
                        Console.WriteLine(" quelle est votre coleur préférée ?");
                        metierCouleur = Console.ReadLine();
                        unUtilisateur.SetCouleurPreveree(metierCouleur);
                    }

                    utilisateurs.Add(unUtilisateur);
                }

                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Voulez vous saisir un autre utilisateur : N:O ?");

                continuerO_N = ConsoleKey(true).key;
            }

            while (continuerO_N == ConsoleKey.O);

            //Affichage 
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                Console.WriteLine("Nom et Prénom : " + utilisateur.GetNomComplet() + "-");

                Console.WriteLine("Date de naissance (âge): " + "(" + utilisateur.GetAge() + ") - ");

                Console.WriteLine(utilisateur.GetCouleurOuMetier());
            }
                    
        }
    }
}
