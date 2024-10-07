namespace LDasylvaTool
{
    public class ConsoleTools
    {
        public static int DemenderNombreEntier(string _question)
        {
            string saisiUtilisateur;

            int valeurRetour;

            bool saiseOk;
            do
            {
                Console.WriteLine(_question);

                saisiUtilisateur = Console.ReadLine() ?? "";

                saiseOk = int.TryParse(saisiUtilisateur, out valeurRetour);

                if (saiseOk)
                {
                    Console.WriteLine("Saisie invalide, recommencez !");
                }

            }
            while (saiseOk);

            return valeurRetour;




        }
public static float DemanderFloatPositive(string _question)
    {
        string nombrePositive;

        float valeurRetour;

        bool saiseOk;
        do
        {
            Console.WriteLine(_question);
            nombrePositive = Console.ReadLine() ?? "";

            saiseOk = float.TryParse(nombrePositive, out valeurRetour);

            if (saiseOk)
            {
                Console.WriteLine("saisie invalide, rcommencez");
            }
        }
        while (saiseOk);
        return valeurRetour;

    }
    }
    
}



  
