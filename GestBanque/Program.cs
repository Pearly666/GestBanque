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

        Courant courant2 = new Models.Courant()
        {
            Numero = "0002",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        banque.Ajouter(courant);

        banque["0001"]?.Depot(-100);
        banque["0001"]?.Depot(100);
        banque["0001"]?.Retrait(-100);
        banque["0001"]?.Retrait(100);
        banque["0001"]?.Retrait(600);

        banque["0002"]?.Depot(300);

        Console.WriteLine(banque.AvoirDesComptes(doeJohn));

        Console.WriteLine(courant2.Solde);
    }
}
