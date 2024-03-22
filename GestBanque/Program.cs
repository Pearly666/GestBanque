using Models;
namespace GestBanque;

class program
{
    static void Main(string[]args)
    {
        Personne doeJohn = new Personne()
        {
            Nom = "Doe",
            Prenom = "John",
            DateNaiss = new DateTime(2000, 02, 29)
        };

        Courant courant = new Models.Courant()
        {
            Numero = "0001",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        courant.Depot(-100);
        courant.Depot(100);
        courant.Retrait(-100);
        courant.Retrait(100);
        courant.Retrait(600);

        Console.WriteLine(courant.Solde);
    }
}
