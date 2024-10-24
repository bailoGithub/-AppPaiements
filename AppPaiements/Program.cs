
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


    }
}