namespace MaBicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma bicyclette");
            // Variable

            bool ilFaitBeau;
            bool bicycletteEnBonneEtat;
            bool repartionRapide;
            bool GOTBibilotheque;
            bool GOTbibliothequeMunicipal;

            // Traitement 

            Console.WriteLine("Es ce qu'il fait beau aujourd'hui???");
            ilFaitBeau = bool.Parse(Console.ReadLine());
            if (ilFaitBeau)
            {
                Console.WriteLine("Est ce que le vélo est en bonne état?");
                bicycletteEnBonneEtat = bool.Parse(Console.ReadLine());
                if (bicycletteEnBonneEtat)
                {
                    Console.WriteLine("J irai me balader à vélo!");
                }

                else// if (!bicycletteEnBonneEtat)
                {
                    Console.WriteLine("Je passerai chez le garagiste!");
                    Console.WriteLine("Es ce que les réparation son immédiate???");
                    repartionRapide = bool.Parse(Console.ReadLine());
                    if (repartionRapide)
                    {
                        Console.WriteLine("J'irai me balader à vélo!");
                    }
                    else
                    {
                        Console.WriteLine("J'irai me balader à pied près du lac ceuillir dés joncs! ");
                    }



                }
            }
            else
            {
                Console.WriteLine("Je consacrerai ma journée à la lecture !");
                Console.WriteLine("Jaimerais relire le 1er tome de Game Of Thrones.");
                Console.WriteLine("Es ce que j'ai le livre à la maison?");
                GOTBibilotheque = bool.Parse(Console.ReadLine());
                if (GOTBibilotheque)
                {
                    Console.WriteLine("Je m'instale confortablement dans un fauteuil et je me plongerais dans la lecture!");
                }
                else if (!GOTBibilotheque)
                {
                    Console.WriteLine("J'irai à la bibliothèque municipale!");
                    Console.WriteLine("Es ce qu'ils ont le tome 1 de Game oh Throne?");
                    GOTbibliothequeMunicipal = bool.Parse(Console.ReadLine());
                    if (GOTbibliothequeMunicipal)
                    {
                        Console.WriteLine("Je rentre direct et je m'instale confortablement dans un fauteuil et je me plongerais dans la lecture!");
                    }
                    else
                    {
                        Console.WriteLine("J'emprunterai un roman policier et je rentrerais a la maison pour le lire!");
                    }   
                }
            }
        }

    }
}  