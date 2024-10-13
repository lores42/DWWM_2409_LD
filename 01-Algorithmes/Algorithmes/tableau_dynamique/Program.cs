namespace tableau_dynamique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Variable
            
            string saisieNomPrenom;
            char saisieOuiNon;
            
            string personne;

            //Traitement
            Console.WriteLine("Enregistrement de nouveau utilisateur");
             
            List<string> utilisateurs = new List<string>();

            utilisateurs.Add("toto");
            utilisateurs.Add("toto2");

            utilisateurs.AddRange(["toto3, toto4"]);
            utilisateurs.Insert(2, "titi");

            utilisateurs.InsertRange(1, ["tata, tutu"]);


            do
            {
                Console.WriteLine("Saisissez votre nom et prènom : ");
                saisieNomPrenom = Console.ReadLine() ?? "";

                utilisateurs.Add(saisieNomPrenom);

                Console.WriteLine("Souhaitez vius ajouter un autre utilisateur ? (N/O)");
                saisieOuiNon = Console.ReadKey(true).KeyChar;
            }
            while (saisieOuiNon == "o" || saisieOuiNon == "O");

            for (int i = 0; i < utilisateurs.Count; i++)
            {
                Console.WriteLine(utilisateurs[i]);
                {

                    foreach (string s in utilisateurs)
                    {
                        Console.WriteLine(personne);
                    }
                }
            }
        }
    }
}
