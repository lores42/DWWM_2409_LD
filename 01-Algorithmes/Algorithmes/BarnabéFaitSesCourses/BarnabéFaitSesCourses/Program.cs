namespace BarnabéFaitSesCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barnabé fais ses courses !");

            //Variable
            int arg;
            int dép=0;
            int S=0;
            string saisieUtilisateur;


            //Traitement 
            Console.WriteLine("Saissez la somme dont dispose pose Barnabé pour faire ses coursses !");
            saisieUtilisateur = Console.ReadLine();
            arg = int.Parse(Console.ReadLine());

            //Affichage

            while (arg != 2)
            {
                if (arg / 2 == dép)
                {
                    Console.WriteLine("Barnabé à dépensé " + dép + "€ ");
                }

                else if (dép / 2 + 1 == S)
                {
                    Console.WriteLine("Barnabé à dépensé "+S+"€ dans le magasin suivant.");
                }
            }
        }
    }
}
