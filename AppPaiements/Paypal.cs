using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement 
    {
        public string Email { get; set; }
        public Paypal (double montant , string description , string email) :base (montant , description)
        {
            Email = email;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Le montant du paiement par PayPal " +
                $"s'élève à un montant de {Montant}€, " +
                $"avec une description : {Description}," +
                $" et son e-mail relier a son user est : {Email}");
        }
    }
}
