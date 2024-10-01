using System.ComponentModel.DataAnnotations;

namespace TriDeNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tri de nombre ++");

            // Variable

            int numA;
            int numB;
            int numC;
            int[] nombres;
            string saisieUtilisateur;

            // Traitement 

            Console.WriteLine("Entrez votre premier nombre");
            saisieUtilisateur = Console.ReadLine(); // Récupération d'une saisie utilisateur
            numA = int.Parse(saisieUtilisateur); // Conversion de la saisie en nombre entier

            Console.WriteLine("Entrez votre second nombre");
            saisieUtilisateur = Console.ReadLine(); 
            numB = int.Parse(saisieUtilisateur);

            Console.WriteLine("Entrez votre troisième nombre");
            saisieUtilisateur = Console.ReadLine();
            numC = int.Parse(saisieUtilisateur);

            nombres = [numA,numB,numC];

            Array.Sort(nombres);

            // Affichage

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }

            Console.ReadLine();

        }
    }
}
