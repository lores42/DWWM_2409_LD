using ClassLibraryBouteille;

namespace ConsoleAppBouteille
{
    class Program
    {
        static void Main(string[] args)
        {

            Bouteille b = new Bouteille();

            Bouteille c = new Bouteille(3f, 2f, true);

            Bouteille d = new Bouteille(0.5f, 0.25f);

            Bouteille clone = new Bouteille(b);

            b.Vider();

        }

    }
}