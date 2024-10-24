
using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit achatN1 = new CarteCredit ("achat de bouquins" ,850.00 , 98754256);
        CarteCredit achatN2 = new CarteCredit("achat dequipement ", 230.20 , 75456734);
        CarteCredit achatN3 = new CarteCredit("achat de ressources", 850.00, 42689785);

        achatN1.AfficherDetails();
        achatN2.AfficherDetails();
        achatN3.AfficherDetails();

        Paypal paiementN1 = new Paypal (75.00, "Paiement des fourniture de la compta", "bailo@gmail.com");
        Paypal paiementN2 = new Paypal (30.50, "Paiement du livre de programmation", "oumarou@ahoo.fr");

       
        paiementN1.AfficherDetails();
        paiementN2.AfficherDetails();


    }
}