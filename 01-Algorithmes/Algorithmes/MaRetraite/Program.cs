namespace MaRetraite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ma retraite");

            //variable

            int numA;

            int[] nombre;
            string saisieUtilisateur;

            // Traitement 

            Console.WriteLine("Écrivez votre age !!!");
            saisieUtilisateur = Console.ReadLine(); // Récupération d'une saisie utilisateur
            numA = int.Parse(saisieUtilisateur); // Conversion de la saisie en nombre entier

            // Affichage
            if (numA < 0)
  
            {
                Console.WriteLine("La valeur fournie n'est pas un age valide !!!");
            }

            else if (numA == 60)
            {
                Console.WriteLine("C'est le moment de prendre sa retraite !");
            }

            else if (numA < 60)
            {
                Console.WriteLine("Il vous reste " + (60 - numA) + " d'année(s) avant la retraite !");
            }

            else if (numA > 60)
            {
                Console.WriteLine("Vous êtes à la retraite depuis " + (numA - 60) + " d'année(s)!");
            }
            
        }
        

    }
}
