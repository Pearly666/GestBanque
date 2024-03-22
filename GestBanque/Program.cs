using Models;
namespace GestBanque;

class program
{
    static void Main(string[]args)
    {
        Banque banque = new Banque()
        {
            Nom = "ING"
        };

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

        banque.Ajouter(courant);

        banque["0001"]?.Depot(-100);
        courant.Depot(100);
        courant.Retrait(-100);
        courant.Retrait(100);
        courant.Retrait(600);

        Console.WriteLine(courant.Solde);
    }
}
