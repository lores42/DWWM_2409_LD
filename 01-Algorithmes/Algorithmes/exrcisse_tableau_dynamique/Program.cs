using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exrcisse_tableau_dynamique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tableau dynamique !");

            //Variable
            DateTime saisieDate;
            string nom;
            string metier;
            string couleurPref;
            string saisieUtilisareur;
            DateTime newDay = DateTime.Now;
            int age;
            string saisieOuiNon;
            bool isMineur = false;
            string[] unUtilisateur;
            // DateTime dateOnly = DateOnly.FromDateTime(DateTime.Now); 
            int dateSaisie;    


            //Traitement
            List<string> utilisateurs = new List<string>(); // tableau

           // do
            { 
            Console.WriteLine("Veuillez saisire votre prènom. ");
            nom = Console.ReadLine() ?? ""; // saisie du nombre

                utilisateurs.Add(nom);

            Console.WriteLine("Veuillez saisir votre date de naissance, jour/mois/année .");
            saisieDate = DateTime.Parse(Console.ReadLine() ?? ""); // saisie clavier de l'age
                              age = newDay.Year - saisieDate.Year; // calculer age par rappor a la date de naissance 

               
               if (newDay.Month < saisieDate.Month || newDay.Day < saisieDate.Day && newDay.Month == saisieDate.Month)
                {
                    age = age -1;
                    
                }
                Console.WriteLine("Vous avez : " +age+ " ans.");

                //age = newDay - saisieDate;

                  if (age < 0)
                  {
                      Console.WriteLine("Vous n'êtes pas née !");
                  }

                  else if (age >= 18)
                  {
                      isMineur = false;
                      Console.WriteLine("Vous êtes majeur !");
                      Console.WriteLine();
                      Console.WriteLine("Quel est votre métier ?");
                      metier = Console.ReadLine() ?? "";
                  }

                  else
                  { 
                      isMineur = true;
                      Console.WriteLine("Vous êtes mineur !");
                      Console.WriteLine();
                      Console.WriteLine("Quelle est votre couleur préférée ?");
                      couleurPref = Console.ReadLine() ?? "";
                  }

                string[]  unUtlisateur = [nom, age, couleurPref,metier];

                /*Console.WriteLine("Voulez vous ajoutez une autre personne ?");
                saisieOuiNon = Console.ReadLine() ?? "";
                if (saisieOuiNon == "oui" )
                {

                }
                while (true)
                {

                }*/
                Console.ReadLine();
            }


            
        }
    }
}
