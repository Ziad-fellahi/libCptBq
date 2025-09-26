using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace libCptBq
{
    public class Banque
    {
        // Attributs
        private List<Compte> mesComptes;
        private List<Type> mesTypes;

        // Constructeur
        public Banque()
        {
            mesComptes = new List<Compte>();
            mesTypes = new List<Type>();
        }

        // Ajouter un compte existant
        public void AjouterCompte(Compte c)
        {
            mesComptes.Add(c);
        }

        // Créer et ajouter un nouveau compte
        public void AjouterCompte(int numero, string nom, decimal solde, decimal decouvertAutorise)
        {
            // TODO : créer un compte et l'ajouter à mesComptes
        }

        // Retourner un compte selon son numéro
        public Compte RendCompte(int numero)
        {
            foreach (Compte c in mesComptes)
    {
        if (c.Numero == numero)
            return c;
    }
    return null; // compte non trouvé
        }

        // Ajouter un type de mouvement à partir des paramètres
        public void AjouterType(string code, string libelle, char sens)
        {
            // TODO : créer un objet Type et l'ajouter à mesTypes
        }

        // Ajouter un type de mouvement existant
        public void AjouterType(Type unType)
        {
            // TODO : ajouter unType à mesTypes
        }

        // Retourner un type de mouvement selon son code
        public Type GetType(string code)
        {
            // TODO : rechercher dans mesTypes et retourner le type
            return null;
        }

        // Redéfinir ToString pour afficher tous les comptes
        public override string ToString()
        {
            // TODO : parcourir mesComptes et afficher les informations
            return "";
        }
    }
}
