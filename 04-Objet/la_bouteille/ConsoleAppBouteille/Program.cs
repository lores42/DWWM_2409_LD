using ClassLibraryBouteille;

public class Program
    {
static void Main(string[] args)
    {
        Bouteille b;
        b = new Bouteille();

        b = new Bouteille(2f, 0.8f, true, "Oasis");

        b = new Bouteille(1.25f, 0.85f, "jus");

        b = new Bouteille(1.5f, 0.5f, false, "eau gazeuse");
        Bouteille clone = new Bouteille(b);

    }
}
