// See https://aka.ms/new-console-template for more information
Console.WriteLine("Controler la saisie avec limite!");

//Variable

string mdp;
string mdpValide = "formation";
int i = 0;

//Traitement

Console.WriteLine("saisissez votre mots de passe");
mdp=Console.ReadLine();
if (mdp == mdpValide)
{
    Console.WriteLine("vous êtes connectez!!!");
}

else
{
   
    Console.WriteLine(" votre comte est bloquer !!!");
}

while (i <= 3)
{
    if (mdp == mdpValide || i <= 3)
    
        {
            Console.WriteLine("veuillez resaisir votre mots de passe");
            mdp = Console.ReadLine();
            //Console.WriteLine(" Votre compte est bmoqué!!!");
        }

    else 
        {
            Console.WriteLine("votre compte est bloqué!!!");
        break;
        }
}