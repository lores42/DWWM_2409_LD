using System.Diagnostics.Metrics;

namespace Denombrer_les_lettres_de_l_alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dénombrer les lettres de l'alphabet dans un tableau !");

            //Variable
            string saisieUtilisateur;
            var occurence = 0;
            
            //Traitement
            Console.WriteLine("Saisire un texte de 120 cartères minimum !");
            saisieUtilisateur = Console.ReadLine();
            char [] letter = { 'A', 'a', 'À', 'à', 'Â', 'â', 'Ä', 'ä', 'Ã', 'ã', 'B', 'b', 'C', 'c', 'ç', 'D', 'd', 'E', 'e', 'é', 'È', 'è', 'Ê', 'ê', 'Ë', 'ë', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'Ì', 'ì', 'Î', 'î', 'Ï',
             'ï', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'Ñ', 'ñ', 'O', 'o', 'Ò', 'ò', 'Ô', 'ô', 'Ö', 'ö', 'Õ', 'õ', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'Ù', 'ù', 'û', 'Ü', 'ü', 'V', 'v',
                'W', 'w', 'X', 'x', 'Y', 'y', 'ÿ', 'Z', 'z' }; // Lire la touche utilisé pour écrire 

            foreach (char c in saisieUtilisateur) //recherche pour chaque lettere 
            {
                if (c == letter[])
                {
                    occurence += 1; //recherche l occurence une par une 
                }

                Console.WriteLine();
                Console.WriteLine("Votre texte contient : "+occurence+" de lettre : "+letter);
            }
        }
    }
}
