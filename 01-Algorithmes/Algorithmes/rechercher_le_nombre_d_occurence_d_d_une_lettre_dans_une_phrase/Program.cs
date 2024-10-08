using System.Text.RegularExpressions;

namespace rechercher_le_nombre_d_occurence_d_d_une_lettre_dans_une_phrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rechercher le nombre d'occurences d'une lettre dans une phrase !");

            //Variable
            
            string saisieUtilisateur;
            string regexLettre;
            string regexPoint;
            var occurence = 0;

            //Traitement
            Console.WriteLine("Saisir votre phrase !");
            saisieUtilisateur = Console.ReadLine();// lire la saisie que l'utilisateur a tappé
            //saisieUtilisateur = "toto .";

           

            // Affichage
            
            

            regexLettre = @"^[a-zA-Z. ]+$"; // controle si la saisie ne contient que des lettres, espaces et point
            regexPoint = @"[.]$"; // controle si la saisie contient un point a la fin

                                    
            if (
                saisieUtilisateur.Length > 0 &&
                saisieUtilisateur != "." &&
                Regex.IsMatch(saisieUtilisateur, regexPoint) &&
                Regex.IsMatch(saisieUtilisateur, regexLettre)
                )
            {

                Console.WriteLine("Quelle lettre voulez vous compter ? ");
                char letter = Console.ReadKey().KeyChar; // sert a lire sur la quelle l utilisateur
                                                         // vas taper et grace au (.Keychar) on réccupère un char 

                foreach (char c in saisieUtilisateur) //recherche pour chaque lettere 
                {
                    if (c == letter)
                    {
                        occurence += 1; //recherche l occurence une par une 
                    }
                }


                Console.WriteLine();
                Console.WriteLine("Votre message contient " + occurence + " de la lettre " + letter + ".");
            } 
            
            else
            {
                    Console.WriteLine("La chaine est vide !");
            }
            
        
           
            Console.ReadLine();


        }
    }
}
