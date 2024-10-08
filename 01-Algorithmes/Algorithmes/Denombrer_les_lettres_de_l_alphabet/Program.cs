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

            foreach (char c in saisieUtilisateur) //recherche pour chaque lettere 
            {
                if (c == letter)
                {
                    occurence += 1; //recherche l occurence une par une 
                }

            }
    }
}
