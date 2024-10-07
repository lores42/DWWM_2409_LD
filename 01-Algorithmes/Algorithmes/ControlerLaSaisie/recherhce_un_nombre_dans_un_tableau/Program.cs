namespace recherhce_un_nombre_dans_un_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recheche un npmbre dans un tableau !");

            //Variable
            int N;
            string saisieUtilisateur;
            int[] chiffre = {8, 16, 32, 64, 128, 256, 512 };
            bool nombre = false;
  
            //Traitement 
            Console.WriteLine("saisir votre nombre ");
            saisieUtilisateur = Console.ReadLine();
            N = int.Parse(saisieUtilisateur);

            for (int i = 0; i < chiffre.Length ; i++)
            {
                if (N == chiffre[i])
                {
                    Console.WriteLine("votre chiffre :" + N + " est a l indice : " + i);
                    nombre = true;
                }

            }
            if ( !nombre )
            {
                 Console.WriteLine("nombre non trouvé");
                
            }
        }
    }
}
