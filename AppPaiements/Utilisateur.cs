﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom {  get; set; }
        public List <Paiement> Paiements { get; set; }
        public Utilisateur (string nom)
        {

            Nom = nom;
            Paiements = new List <Paiement> ();
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Son Nom est  : {Nom}");
            Console.WriteLine("la liste des paiements se presentes comme suit :");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }

        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
    }
}
