
using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {



        Utilisateur utilisateur = new Utilisateur("Oumarou Bailo Bah");

        CarteCredit achatN1 = new CarteCredit ("achat de bouquins" ,850.00 , 98754256);
        CarteCredit achatN2 = new CarteCredit("achat dequipement ", 230.20 , 75456734);
        CarteCredit achatN3 = new CarteCredit("achat de ressources", 850.00, 42689785);


        utilisateur.AjouterPaiement(achatN1);
        utilisateur.AjouterPaiement(achatN2);
        utilisateur.AjouterPaiement (achatN3);

        Paypal paiementN1 = new Paypal (99.75, "Paiement des fourniture de la compta", "bailo@gmail.com");
        Paypal paiementN2 = new Paypal (28.50, "Paiement dun livre de programmation", "oumarou@yahoo.fr");


        utilisateur.AjouterPaiement(paiementN1);
        utilisateur.AjouterPaiement(paiementN2);

        utilisateur.AfficherInfos();


    }
}