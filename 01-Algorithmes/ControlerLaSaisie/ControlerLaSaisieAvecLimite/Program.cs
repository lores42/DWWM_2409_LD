using System.Reflection;

namespace ControlerLaSaisieAvecLimite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contrôler la saisie avec limite!");

            //Variable

            string motsDePasse = "";
            string motsDePasseverif = "formation";
            int i = 1;
            //Traitement

            while (i <= 3)

            {

                Console.WriteLine("veuillez saisir votre mot de passe");
                motsDePasse = Console.ReadLine();

                if(motsDePasse != motsDePasseverif) // si le mot de passe est incorrect
                {
                    i++;
                }
                else // sinon le mot de passe est correct
                {
                    i = 4;
                }

                
                // Console.WriteLine("votre compte est bloqué!!!");




            }

            if (motsDePasse == motsDePasseverif)
            {
                Console.WriteLine("Vous êtes connecté !!!");

            }
            else
            {
                Console.WriteLine("votre compte est bloqué!!!");
            }

        }
    }
}

