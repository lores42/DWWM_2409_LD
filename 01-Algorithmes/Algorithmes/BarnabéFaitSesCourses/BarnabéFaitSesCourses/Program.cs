namespace BarnabéFaitSesCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barnabé fais ses courses !");

            //Variable
            double arg = 0;
            double dép = 0;
            int M=1;
            string saisieUtilisateur;


            //Traitement 
            Console.WriteLine("Saissez la somme dont dispose Barnabé pour faire ses coursses !");
            saisieUtilisateur = Console.ReadLine();
            arg = double.Parse(saisieUtilisateur);

            //Affichage

            while (arg > 2)
            {

                dép = (arg / 2.0 + 1.0);
                arg = arg - dép;
                Console.WriteLine("Barnabé à dépensé " + dép + " Euros et il lui reste " + arg+"E");

                M++;
                {
                    Console.WriteLine("Barnabé a fais " + M + " de magasin.");                
                }
            }

            Console.WriteLine("Barnabé à dépensé " + arg + " Euros dans le dernier magasin");
            Console.WriteLine(" ");
            Console.WriteLine("COMME DIRAIT CINDY IL AURAIT PU FAIRE UN DRIVE CE ... DE BARNABÉ !!! ");
        }
    }
}

 