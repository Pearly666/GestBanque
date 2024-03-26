using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Compte
    {
        public static double operator +(double montant, Compte courant)
        {
            return (montant < 0 ? 0 : montant) + (courant.Solde < 0 ? 0 : courant.Solde);
        }

        private string _numero;
        private double _solde;
        private Personne _titulaire;

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

        public void Depot(double montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Erreur: montant négatif impossible");
                return;
            }
            Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0D);
        }

        protected virtual void Retrait(double montant, double LigneDeCredit)
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


        protected abstract double CalculInteret();

        public void AppliquerInteret ()
        {
            Solde += CalculInteret();
        }
       
    }
}
