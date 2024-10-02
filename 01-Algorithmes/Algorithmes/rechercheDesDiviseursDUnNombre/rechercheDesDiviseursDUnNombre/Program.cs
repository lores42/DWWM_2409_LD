namespace rechercheDesDiviseursDUnNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recherche des diviseurs d'un nombre!");

            //Variable
            int num;
            string saisieUtilisateur;

            //traitement 
            Console.WriteLine("saisir votre nombre");
            saisieUtilisateur=Console.ReadLine();
            num=int.Parse(saisieUtilisateur);

            //Affichage
            Console.Write(num+" est divisible par ");
            for (int i=2 ; i < num ; i++)
            {
                if(num%i==0)
                {
                    Console.Write(i+"; ");
                }
            }

           

        }
    }
}
