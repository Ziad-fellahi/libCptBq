using System;

namespace libCptBq
{
    /// <summary>
    /// Classe Compte
    /// </summary>
    public class Compte
    {
        /// <summary>
        /// Propriétés
        /// </summary>
        public int Numero { get; set; }
        public string Nom { get; set; }
        public decimal Solde { get; set; }
        public decimal DecouvertAutorise { get; set; }

        /// <summary>
        /// Constructeur à 4 arguments
        /// </summary>
        public Compte(int numero, string nom, decimal solde, decimal decouvertAutorise)
        {
            this.Numero = numero;
            this.Nom = nom;
            this.Solde = solde;
            this.DecouvertAutorise = decouvertAutorise;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Compte()
        {
            this.Numero = 0;
            this.Nom = "";
            this.Solde = 0m;
            this.DecouvertAutorise = 0m;
        }

        /// <summary>
        /// Crédite le compte
        /// </summary>
        public void Crediter(decimal montant)
        {
            if (montant > 0)
            {
                this.Solde += montant;
            }
        }

        /// <summary>
        /// Débite le compte si possible
        /// </summary>
        public bool Debiter(decimal montant)
        {
            if (montant <= 0) return false; // interdit le débit négatif
            if (this.Solde - montant >= this.DecouvertAutorise)
            {
                this.Solde -= montant;
                return true;
            }
            return false;
        }

        public bool Transferer(decimal montant, Compte c)
        {
            if (montant <= 0) return false; // interdit le transfert négatif
            if (this.Debiter(montant))
            {
                c.Crediter(montant);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Compare le solde avec un autre compte
        /// </summary>
        public bool Superieur(Compte autre)
        {
            return this.Solde > autre.Solde;
        }

        /// <summary>
        /// Représentation texte de l’objet
        /// </summary>
        public override string ToString()
        {
            return $"numero: {this.Numero} nom: {this.Nom} solde: {this.Solde:F2} decouvert autorisé: {this.DecouvertAutorise:F2}";
        }
    }


}
