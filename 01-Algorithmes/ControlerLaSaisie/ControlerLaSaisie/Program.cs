using System.ComponentModel.DataAnnotations;

namespace ControlerLaSaisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contrôler la saisie !");

            //Variable 

            string Prenom;

            //traitement

            Console.WriteLine(" saisissez vitre prènom!");
            Prenom = Console.ReadLine();

            //Affichage

            while (Prenom.Length < 2)
            {
                Console.WriteLine("saisie trop courte veuilliez saisir au minimum 2 caractère");
                Prenom = Console.ReadLine(); 

            }


            Console.WriteLine("Bonjour "+Prenom+"]");

        }
    }
}
