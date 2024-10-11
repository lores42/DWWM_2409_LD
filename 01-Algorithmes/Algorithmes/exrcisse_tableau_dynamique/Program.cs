using System.Xml;

namespace exrcisse_tableau_dynamique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tableau dynamique !");

            //Variable
            string saisieUtilisateur;
            string nom;
            string pernom;
            string metier;
            string couleurPref;
            int saisieAge;
            int age;
            char saisieOuiNon;
            bool isMineur = false;
            DateTime aujourdHui = DateTime.Now;

            //Traitement
            List<string> utilisateurs = new List<string>(); // tableau

           // do
            { 
            Console.WriteLine("Veuillez saisire votre prènom. ");
            nom = Console.ReadLine() ?? ""; // saisie du nombre

                utilisateurs.Add(nom);

            Console.WriteLine("Veuillez saisir votre date de naissance. ");
            saisieUtilisateur = Console.ReadLine(); // saisie clavier de l'age
            saisieAge = int.Parse(Console.ReadLine()); // convertion de la saisie du nombre
                DateTime bDay = new DateTime(2000, 02, 05);   
                
                if (age < 0)
                {
                    Console.WriteLine("Vous n'êtes pas née !");
                }

                else if (age <= 18)
                {
                    isMineur = false;
                    Console.WriteLine("Vous êtes majeur !");
                    Console.WriteLine();
                    Console.WriteLine("Quel est votre métier ?");
                    metier = Console.ReadLine();
                }

                else
                { 
                    isMineur = true;
                    Console.WriteLine("Vous êtes mineur !");
                    Console.WriteLine();
                    Console.WriteLine("Quelle est votre couleur préférée ?");
                    couleurPref = Console.ReadLine();
                }

            }


            
        }
    }
}
