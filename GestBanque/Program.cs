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

        Compte courant = new Courant()
        {
            Numero = "0001",
            LigneDeCredit = 500,
            Titulaire = doeJohn
        };

        Compte epargne = new Epargne()
        {
            Numero = "0002",
            Titulaire = doeJohn
        };

        banque.Ajouter(courant);
        banque.Ajouter(epargne);

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

        banque["0002"]?.Retrait(100);
        Console.WriteLine($"Retrait de 100 sur le compte '0002' : {banque["0002"]?.Solde}");

        if (banque["0002"] is Epargne e)
        {
            Console.WriteLine($"Date de dernier retrait : {e.DernierRetrait}");
        }

        banque["0002"]?.AppliquerInteret();

        Console.WriteLine($"Avoir des comptes de Mr {doeJohn.Nom} {doeJohn.Prenom} : {banque.AvoirDesComptes(doeJohn)}");

        banque.Supprimer("0001");
        banque.Supprimer("0002");

        Console.WriteLine(courant.Solde);
    }
}
