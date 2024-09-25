namespace EsTuMajeur_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Es tu majeur ?");
            // Variable

            int numA;


            string saisieUtilisateur;

            // traitement 

            Console.WriteLine("entrer votre age");
            saisieUtilisateur = Console.ReadLine(); // Récupération d'une saisie utilisateur
            numA = int.Parse(saisieUtilisateur); // Conversion de la saisie en nombre entier


            //Affichage

            if (numA <= 0)
            {
                Console.WriteLine("Vous n'ets pas encore né!!!");
            }

            else if (numA >= 0 && numA < 18)
            {
                Console.WriteLine("Vous êtes mineur !!!");
            }
            else //if (numA >= 18)
            {
                Console.WriteLine("Vous êtes majeur !!!");
            }

            Console.ReadLine();
        }
    }
}
