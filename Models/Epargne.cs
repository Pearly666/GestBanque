﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Epargne : Compte
    {
      
        private DateTime _dernierRetrait;
        public DateTime DernierRetrait
        {
            get
            {
                return _dernierRetrait;
            }
            private set
            {
                _dernierRetrait = value;
            }
        }
        public override void Retrait(double montant)
        {

            double ancienSolde = Solde;
            base.Retrait(montant);

            if (Solde != ancienSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }

        public Epargne(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde, DateTime dernierRetrait) : base(numero, titulaire, solde)
        {
            DernierRetrait = dernierRetrait;
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
    }
}
