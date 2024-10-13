// See https://aka.ms/new-console-template for more information
Console.WriteLine("Recherche un nombre dans un tableau !");

//Variable
int N=0;
string saisiUtilisateure;

//Traitement
Console.WriteLine("saisir votre nombre");
saisiUtilisateure=Console.RideLine();
N = int.Parse(saisiUtilisateure);
 
int[] nombres = new int[7];
nombres[0] = 8;
nombres[1] = 16;
nombres[2] = 32;
nombres[3] = 64;
nombres[4] = 128;
nombres[5] = 256;
nombres[6] = 512;

//Affichage

if (N == nombres[0])
{
    Console.WriteLine("le ciffre " + N + " est a la position" + nombres [0] );
}
//Console.WriteLine();
    

