using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement 
    {

        public int NumeroCarte { get; set; }
        public CarteCredit (string descrpition , double montant , int numeroCarte)
            :base (montant , descrpition)
        {
            NumeroCarte = numeroCarte;

        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"le Paiement par Carte de Crédit seleve a un montant de {Montant}, avec une description {Description}, ayant pour Numéro de carte = {NumeroCarte}");
        }
    }
}
