namespace intervalleEntreDeuxNombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intervalle entre deux nombres");

            //Variable 

            int numA = 0;
            int numB = 0;
            int i = 0;
            string saisieUtilisateur;
            //Traitement

            Console.WriteLine("entrer votre premier nombre");
            saisieUtilisateur = Console.ReadLine();
            numA = int.Parse(saisieUtilisateur);

            Console.WriteLine("entrer votre second nombre");
            saisieUtilisateur = Console.ReadLine();
            numB = int.Parse(saisieUtilisateur);

            //Affichage

            if (numA < numB)

            {
                Console.Write("le résultat est : ");
                for (i = numA + 1; i < numB; i++) 
                {
                    Console.Write(i+" ");
                }
            }

           if (numA > numB)
            {
                Console.Write("le résultat est :");
                for (i = numA - 1; i > numB; i--)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
