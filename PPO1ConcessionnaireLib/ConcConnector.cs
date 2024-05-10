using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPO1ConcessionnaireLib
{
    //Objet pour la gestion de la connection à la base de donnée.
    public class ConcConnector
    {
        private MySqlConnection ConnectPersOslo = new MySqlConnection();
        private bool _connected = false;
        //Ouverture PDO
        public void OpenPDO()
        {
            if (_connected)
            {
                return;
            }
            _connected = true;
            ConnectPersOslo.ConnectionString = "SERVER=localhost;DATABASE=bdOccasionCs;UID=root;";
            ConnectPersOslo.Open();

        }
        //Fermeture PDO
        public void ClosePDO()
        {
            if (_connected)
            {
                ConnectPersOslo.Close();
                _connected = false;
            }
            return;

        }
        //Donne tous les concessionnaires de la BDD
        public List<Concessionnaire> ReadConc()
        { 
            if (_connected)
            {
                List<Concessionnaire> lesConc = new List<Concessionnaire>();
                MySqlCommand cmd = new MySqlCommand("select * from Concessionnaire", ConnectPersOslo);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Concessionnaire unConc = new Concessionnaire(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5));
                    lesConc.Add(unConc);
                }

                //Fermeture du dataReader et connection
                rd.Close();
                return lesConc;
            }
            return null;
        }
        //Donne tous les utilisateurs de la BDD
        public List<User> ReadUser()
        {
            if (_connected)
            {
                List<User> lesUser = new List<User>();
                MySqlCommand cmd = new MySqlCommand("select * from compte", ConnectPersOslo);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    User unUser = new User(rd.GetString(0), rd.GetString(1));
                    lesUser.Add(unUser);
                }

                //Fermeture du dataReader et connection
                rd.Close();
                return lesUser;
            }
            return null;
        }
        //Requetes
        public List<Concessionnaire> Requete(string Combo, string name)
        {
            if (Combo == "Code Postal")
                Combo = "codePostal";
            if (_connected)
            {
                List<Concessionnaire> lesConc = new List<Concessionnaire>();
                MySqlCommand cmd = new MySqlCommand($"select * from Concessionnaire where {Combo}=@nom", ConnectPersOslo);
                cmd.Parameters.Add("@nom", MySqlDbType.String);
                cmd.Parameters["@nom"].Value = name;
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Concessionnaire unConc = new Concessionnaire(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5));
                    lesConc.Add(unConc);
                }

                //Fermeture du dataReader et connection
                rd.Close();
                return lesConc;
            }
            return null;
        }
        //Ajoute les info utilisateur préalablement encrypté
        public bool AddUser(string nom, string mdp)
        {
            bool resp = false;
            if (_connected)
            {
                //Controle Compte
                List<User> lesUser = ReadUser();
                foreach (User user in lesUser)
                {
                    if (nom == user.Name & mdp == user.Password)
                    {
                        resp = false;
                        break;
                    }
                    else
                        resp = true;
                }
                if (resp)
                {
                    //Ajout Compte
                    MySqlCommand cmd = new MySqlCommand($"insert into compte values(@nom, @mdp)", ConnectPersOslo);
                    cmd.Parameters.Add("@nom", MySqlDbType.String);
                    cmd.Parameters["@nom"].Value = nom;
                    cmd.Parameters.Add("@mdp", MySqlDbType.String);
                    cmd.Parameters["@mdp"].Value = mdp;
                    MySqlDataReader rd = cmd.ExecuteReader();
                    //Fermeture du dataReader et connection
                    rd.Close();
                }
            }
            return resp;
        }
        //Ajout concessionnaire
        public bool AddConc(string nom, string prenom, string adresse, string codepostal, string ville)
        {
            bool resp = true;
            if (_connected)
            {
                if (resp)
                {
                    //Ajout Concessionnaire
                    MySqlCommand cmd = new MySqlCommand($"Insert into Concessionnaire(nom, prenom, adresse, codePostal, ville) Values (@nom, @prenom, @adresse, @codepostal, @ville)", ConnectPersOslo);
                    cmd.Parameters.Add("@nom", MySqlDbType.String);
                    cmd.Parameters["@nom"].Value = nom;
                    cmd.Parameters.Add("@prenom", MySqlDbType.String);
                    cmd.Parameters["@prenom"].Value = prenom;
                    cmd.Parameters.Add("@adresse", MySqlDbType.String);
                    cmd.Parameters["@adresse"].Value = adresse;
                    cmd.Parameters.Add("@codepostal", MySqlDbType.String);
                    cmd.Parameters["@codepostal"].Value = codepostal;
                    cmd.Parameters.Add("@ville", MySqlDbType.String);
                    cmd.Parameters["@ville"].Value = ville;
                    MySqlDataReader rd = cmd.ExecuteReader();
                    //Fermeture du dataReader et connection
                    rd.Close();
                }
            }
            return resp;
        }
        //Suprime Concessionnaire
        public bool DelConc(int ConcId)
        {
            bool resp = false;
            if (_connected)
            {
                //Controle Concessionnaire
                List<Concessionnaire> lesConc = ReadConc();
                foreach (Concessionnaire conc in lesConc)
                {
                    if (ConcId == conc.ConcessionnaireID)
                    {
                        resp = true;
                        break;
                    }
                    else
                        resp = false;
                       
                }
                if (resp)
                {
                    //Suprime Concessionnaire
                    MySqlCommand cmd = new MySqlCommand($"delete from Concessionnaire where idConces=(@id)", ConnectPersOslo);
                    cmd.Parameters.Add("@id", MySqlDbType.String);
                    cmd.Parameters["@id"].Value = ConcId;
                    MySqlDataReader rd = cmd.ExecuteReader();
                    //Fermeture du dataReader et connection
                    rd.Close();
                }
            }
            return resp;
        }
        public bool EditConcCmd(int ConcId, string newcontent, string parameter)
        {
            bool resp = false;
            if (_connected)
            {
                MySqlCommand cmd = new MySqlCommand($"update concessionnaire set {parameter}=(@newcontent) where idConces=(@id)", ConnectPersOslo);
                cmd.Parameters.Add("@newcontent", MySqlDbType.String);
                cmd.Parameters["@newcontent"].Value = newcontent;
                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                cmd.Parameters["@id"].Value = ConcId;
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                resp = true;
            }
            return resp;
        }
        //Modifie Concessionnaire
        public bool EditConc(int ConcId, string nom, string prenom, string adresse, string codepostal, string ville)
        {
            bool resp = false;
            if (_connected)
            {
                //Controle Concessionnaire
                List<Concessionnaire> lesConc = ReadConc();
                Concessionnaire oldConc=null;
                foreach (Concessionnaire conc in lesConc)
                {
                    if (ConcId == conc.ConcessionnaireID)
                    {
                        resp = true;
                        oldConc = conc;
                        break;
                    }
                    else
                        resp = false;
                }
                Concessionnaire newConc=new Concessionnaire(ConcId, nom, prenom, adresse, codepostal, ville);
                if (oldConc == newConc)
                    resp = false;
                if (resp)
                {
                    if (oldConc.Nom != nom)
                        resp = EditConcCmd(ConcId, nom, "nom");
                    if (oldConc.Prenom != prenom)
                        resp = EditConcCmd(ConcId, prenom, "prenom");
                    if (oldConc.Adresse != adresse)
                        resp = EditConcCmd(ConcId, adresse, "adresse");
                    if (oldConc.CodePostal != codepostal)
                        resp = EditConcCmd(ConcId, codepostal, "codepostal");
                    if (oldConc.Ville != ville)
                        resp = EditConcCmd(ConcId, ville, "ville");
                }
            }
            return resp;
        }
    }
}
