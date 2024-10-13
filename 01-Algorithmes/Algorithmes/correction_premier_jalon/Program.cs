namespace correction_premier_jalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Variable
            string saisieUtilisateur;
            string saisieNomPrenom;
            char saisieOuiNon;
            string[] tabTemporaire;
            string[] utilisateur;

            utilisateur = new string[] {"Dasylva Lores" };

            do
            {
                Console.WriteLine("Saisissez votre nom et prènom : ");
                saisieNomPrenom = Console.ReadLine() ?? " ";

                tabTemporaire = utilisateur;
                utilisateur = new string[utilisateur.Length+1];
                tabTemporaire.CopyTo(utilisateur, 0);
                utilisateur[utilisateur.Length-1] = saisieNomPrenom;
                Console.WriteLine("Souhaitez vous ajouter un autre utilisateur ?(N:O)");
                saisieOuiNon = Console.ReadKey().KeyChar;
            }

            while (saisieOuiNon == 'o' || saisieOuiNon == 'O');
            {

            }

            


        }
    }
}
