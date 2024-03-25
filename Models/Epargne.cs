using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Epargne:Compte
    {
        public DateTime DateDernierRetrait
        {
            get
            {
                return _DateDernierRetrait;
            }
            set
            {
                _DateDernierRetrait = value;
            }
        }
        public override void Retrait(double montant)
        {

            double ancienSolde = Solde;
            base.Retrait(montant);

            if (Solde != ancienSolde)
            {
                _DateDernierRetrait = DateTime.Now;
            }
        }
    
}
}
