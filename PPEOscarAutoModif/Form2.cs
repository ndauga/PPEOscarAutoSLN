using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPO1ConcessionnaireLib;

namespace PPEOscarAutoModif
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            List<Concessionnaire> lesConcs = conn.ReadConc();
            if (lesConcs != null)
            {
                foreach (Concessionnaire Conc in lesConcs)
                {
                        string[] tabConc = { Conc.ConcessionnaireID.ToString(), Conc.Nom, Conc.Prenom, Conc.Adresse, Conc.CodePostal, Conc.Ville };
                        listbId.Items.Add(Conc.ConcessionnaireID);
                }
            }
            listbId.SelectedIndex = 0;
            lstupdate(lesConcs);
            conn.ClosePDO();
        }
        private void lstupdate(List<Concessionnaire> lesConcs)
        {
            int selectedId = (int)listbId.SelectedItem;
            if(lesConcs != null)
            {
                foreach (Concessionnaire Conc in lesConcs)
                {
                    if (Conc.ConcessionnaireID == selectedId)
                    {
                        tbNom.Text = Conc.Nom;
                        tbPrenom.Text = Conc.Prenom;
                        tbAdresse.Text = Conc.Adresse;
                        tbCodePostal.Text = Conc.CodePostal;
                        tbVille.Text = Conc.Ville;
                    }
                }
            }
        }


        private void listbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            List<Concessionnaire> lesConcs = conn.ReadConc();
            lstupdate(lesConcs);
            conn.ClosePDO();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            bool add = conn.AddConc(tbNom.Text, tbPrenom.Text, tbAdresse.Text, tbCodePostal.Text, tbVille.Text);
            conn.ClosePDO();
            if (add)
                MessageBox.Show("Concessionaire Enregistré!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                //On sait jamais ¯\_(ツ)_/¯
                MessageBox.Show("Erreur, Contacter le dévelopeur !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int frontid = (int)listbId.SelectedItem;
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            bool add = conn.DelConc(frontid);
            conn.ClosePDO();
            if (add)
                MessageBox.Show("Concessionaire Supprimé!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Le Concessionaire n'existe pas!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            bool add = conn.EditConc((int)listbId.SelectedItem, tbNom.Text, tbPrenom.Text, tbAdresse.Text, tbCodePostal.Text, tbVille.Text);
            conn.ClosePDO();
            if (add)
                MessageBox.Show("Concessionaire Modifié!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Le Concessionaire n'existe pas!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
