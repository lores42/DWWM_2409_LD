namespace nombrePremier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre premier !");

            //Variable
            int num;
            string saisieUtilisateur;

            //Traitement
            Console.WriteLine("saisir votre nombre");
            saisieUtilisateur = Console.ReadLine();
            num = int.Parse(saisieUtilisateur);

            //Affichage

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) // nombre classique
                {
                    Console.WriteLine("Ce n'est pas un nombre premier!");
                }

                else // nombre premier 
                {
                    Console.WriteLine("C'est un nombre premier!");
                }

            }

        }

    }
}
