﻿
namespace Models;

public class Courant
{
    private string _numero;
    private double _solde;
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

    public Personne Titulaire
    {
        get
        {
            return _titulaire;
        }

        set
        {
            _titulaire = value;
        }
    }
    public void Depot(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur: montant négatif impossible");
            return;
        }
        Solde += montant;
    }
    
    public void Retrait(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur, retrait d'un montant négatif impossible"); // => Erreur: exception 
            return;
        }
        if (Solde - montant < LigneDeCredit) ;
        {
            Console.WriteLine("Erreur: solde insuffisant"); // => Erreur: exeception
            return;
        }
        Solde -= montant;
    }
}