
namespace Models;

public class Courant:Compte
{
    private double _ligneDeCredit;
    private Personne _titulaire;

    public string Numero
    {
        get
        {
            return _numero;
        }

        set
        {
            _numero = value;
        }
    }
    public double Solde
    {
        get
        {
            return _solde;
        }

        private set
        {
            _solde = value;
        }
    }
    public double LigneDeCredit
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

    protected override void Retrait(double montant)
    {
        Retrait(montant, LigneDeCredit);
    }

    
}
