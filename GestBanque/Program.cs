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

        Courant courant = new Courant()
        {
            Numero = "0001",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        Courant courant2 = new Courant()
        {
            Numero = "0002",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        banque.Ajouter(courant);
        banque.Ajouter(courant2);

        banque["0001"]?.Depot(-100);
        Console.WriteLine($"Depot de -100 sur le compte '0001' : {banque["0001"]?.Solde}");
        banque["0001"]?.Depot(100);
        Console.WriteLine($"Depot de 100 sur le compte '0001' : {banque["0001"]?.Solde}");
        banque["0001"]?.Retrait(-100);
        Console.WriteLine($"Retrait de -100 sur le compte '0001' : {banque["0001"]?.Solde}");
        banque["0001"]?.Retrait(200);
        Console.WriteLine($"Retrait de 200 sur le compte '0001' : {banque["0001"]?.Solde}");
        banque["0001"]?.Retrait(600);
        Console.WriteLine($"Retrait de 600 sur le compte '0001' : {banque["0001"]?.Solde}");
        banque["0002"]?.Depot(300);
        Console.WriteLine($"Depot de 300 sur le compte '0002' : {banque["0002"]?.Solde}");

        Console.WriteLine($"Avoir des comptes de Mr {doeJohn.Nom} {doeJohn.Prenom} : {banque.AvoirDesComptes(doeJohn)}");

        banque.Supprimer("0001");
        banque.Supprimer("0002");

        Console.WriteLine(banque["0001"] is null);
        Console.WriteLine(banque["0002"] is null);
    }
}
