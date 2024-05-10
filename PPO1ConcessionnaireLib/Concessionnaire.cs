using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO1ConcessionnaireLib
{
    public class Concessionnaire
    {
        //Objet contenant pour l'application les informations des Concessionnaires.
        //Attributs
        private int concessionnaireID;
        private string nom;
        private string prenom;
        private string adresse;
        private string codePostal;
        private string ville;
        //Constructeur
        public Concessionnaire(int concessionnaireID, string nom, string prenom, string adresse, string codePostal, string ville)
        {
            ConcessionnaireID = concessionnaireID;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
        }
        //Getter Setters
        public int ConcessionnaireID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
    }
}
