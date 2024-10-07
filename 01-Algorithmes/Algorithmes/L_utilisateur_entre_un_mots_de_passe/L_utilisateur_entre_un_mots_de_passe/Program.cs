using System.Text.RegularExpressions;

namespace L_utilisateur_entre_un_mots_de_passe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L'utilisateur entre un mot de passe !");

            //Variable 
            string motDePasse;
            string regexMinuscules;
            string regexMajuscules;
            string regexChiffres;
            string regexCaractereSpeciaux;
            string regexLongueurMax;
            string regexLongueurMin;

            //Traitement
            Console.WriteLine("Saisir un mots de passe : ");

            motDePasse = Console.ReadLine() ?? "";

            regexMinuscules = "[a-z]{1,}"; // {1,} = 1 ou plusieurs

            regexMajuscules = "[A-Z]+"; // + = 1 ou plusieurs

            regexChiffres = "[0-9]+";

            regexCaractereSpeciaux = "[^a-zA-Z0-9]+";

            //Affichage
            if (
                Regex.IsMatch(motDePasse, regexMinuscules) &&
                Regex.IsMatch(motDePasse, regexMajuscules) &&
                Regex.IsMatch(motDePasse, regexChiffres) &&
               (Regex.IsMatch(motDePasse, regexCaractereSpeciaux) || motDePasse.Length >= 20) &&

                motDePasse.Length >= 12
                )
            {
                Console.WriteLine("mot de passe valide");
            }

            else
            {
                Console.WriteLine("mot de passe trop faible");
            }
        }
    }
}
