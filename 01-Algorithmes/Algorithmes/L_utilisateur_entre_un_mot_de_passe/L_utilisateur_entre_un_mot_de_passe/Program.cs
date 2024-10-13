using System.Text.RegularExpressions;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("L'utilisateur entre un mot de passe !");

        //Variable

        string motDePasse;
        string regexMinuscules;
        string regexMajuscules;
        string regexChiffres;
        string regexCaracteresSpeciaux;
        string regexCarateresMinimum;
        string regexCaracteresMaximum;

        Console.WriteLine("Saissez un mot de passe : ");

        motDePasse = Console.ReadLine() ?? "";

        regexMinuscules = "[a-z]{1,}";

        regexMajuscules = "[A-Z]+";

        regexChiffres = "[0-9]+";

        regexCaracteresSpeciaux = "[^a-zA-Z0-9]+";

        //Traitement

        if (
            Regex.IsMatch(motDePasse, regexMinuscules) &&
            Regex.IsMatch(motDePasse, regexMajuscules) &&
            Regex.IsMatch(motDePasse, regexChiffres) &&
            (Regex.IsMatch(motDePasse, regexCaracteresSpeciaux) && motDePasse.Length < 20)  &&
            motDePasse.Length >= 12
            )
        {
            Console.WriteLine("mot de passe ok ");
        }

        else if (motDePasse.Length >= 20 )
        {
            Console.WriteLine("mot de passe ok ");
        }

        else
        {
            Console.WriteLine("mot de passe trop faible !");
        }

        Console.ReadLine();
    }
}
