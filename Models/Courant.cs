
using System.Security.Cryptography.X509Certificates;

namespace Models;

public class Courant : Compte
{
    private double _ligneDeCredit;
    
    public override double LigneDeCredit
    {
        get
        {
            return _ligneDeCredit;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("La ligne de crédit est strictement positive...");
                return;
            }

            _ligneDeCredit = value;
        }
    }
    public override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);
    }
    protected override double CalculInteret()
    {
        return Solde * ((Solde <0) ? 0.0975 : 0.03);
    }

    
}
