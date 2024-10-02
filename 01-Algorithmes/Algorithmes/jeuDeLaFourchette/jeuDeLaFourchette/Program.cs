namespace jeuDeLaFourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeu de la fourchette!");

            //Variable
            int num;
            int numMin=0;
            int numMax=100;
            int Essai = 1;
            string saisiUtilisateur;
            Random rand = new Random(); // Crée un nombre aléatoire 
            int N =rand.Next(0,100);    // Nombre aléatoire compris entre ( 0 et 100 )

            //Traitement 
            Console.WriteLine("Saisir un chiffre entre " + numMin + " et " + numMax);
            saisiUtilisateur = Console.ReadLine();  
            num=int.Parse(saisiUtilisateur);

            //Affichage
            while (num != N)
            {
                if (num < N)
                {
                    Console.WriteLine("C'est plus!");
                   numMin = num;
                }
                else
                {
                    Console.WriteLine("C'est moins!");
                    numMax = num;
                }
                Essai++;
                Console.WriteLine("Veuillez saisir un nouveau chiffre entre: "+ numMin +" et "+numMax );
                
                saisiUtilisateur = Console.ReadLine();
                num = int.Parse(saisiUtilisateur);

               
            }

            if (num == N)
            {
                Console.WriteLine("Vous avez trouvez le bon nombre!");
            }

            Console.WriteLine("vous avez essayé " + Essai + " fois");
                
           
        }
    }
}
