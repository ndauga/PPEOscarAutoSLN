using PPO1ConcessionnaireLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPEOscarAutoConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string nom = Crypto.EncryptString(tbNom.Text);
            string mdp = Crypto.EncryptString(tbMdp.Text);
            bool success = false;
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            List<User> lesUser = conn.ReadUser();
            conn.ClosePDO();
            foreach (User user in lesUser)
            {
                if (nom == user.Name & mdp == user.Password)
                {
                    PPEOscarAuto.Form1 modif = new PPEOscarAuto.Form1();
                    modif.ShowDialog();
                    success = true;
                }
            }
            if (!success)
            {
                MessageBox.Show("Utilisateur Inconnu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string nom = Crypto.EncryptString(tbNom2.Text);
            string mdp = Crypto.EncryptString(tbMdp2.Text);
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            bool add = conn.AddUser(nom, mdp);
            conn.ClosePDO();
            if (add)
                MessageBox.Show("Utilisateur Enregistré!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nom Déja utilisé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
