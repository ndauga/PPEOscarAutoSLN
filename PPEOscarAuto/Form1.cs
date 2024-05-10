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

namespace PPEOscarAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            update();
        }

        private void update()
        {
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            List<Concessionnaire> lesConcs = conn.ReadConc();
            if (lesConcs != null)
            {
                foreach (Concessionnaire Conc in lesConcs)
                {
                    string[] tabConc = { Conc.ConcessionnaireID.ToString(), Conc.Nom, Conc.Prenom, Conc.Adresse, Conc.CodePostal, Conc.Ville };
                    ListViewItem listViewItem = new ListViewItem(tabConc);

                    LvMain.Items.Add(listViewItem);
                }
            }
            CbSelect.Items.Clear();
            CbSelect.Items.Add("Ville");
            CbSelect.Items.Add("Nom");
            CbSelect.Items.Add("Code Postal");
            CbSelect.SelectedItem = "Ville";
            conn.ClosePDO();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if(CbSelect.SelectedIndex == 0)
                TbMain.Text = TbMain.Text.ToUpper();
            LvMain.Items.Clear();
            ConcConnector conn = new ConcConnector();
            conn.OpenPDO();
            List<Concessionnaire> lesConcs = new List<Concessionnaire>();
            if (TbMain.Text != "")
            {
                lesConcs = conn.Requete(CbSelect.SelectedItem.ToString(), TbMain.Text);
            }
            else
                lesConcs = conn.ReadConc();

            if (lesConcs != null)
            {
                foreach (Concessionnaire Conc in lesConcs)
                {
                    string[] tabConc = { Conc.ConcessionnaireID.ToString(), Conc.Nom, Conc.Prenom, Conc.Adresse, Conc.CodePostal, Conc.Ville };
                    ListViewItem listViewItem = new ListViewItem(tabConc);

                    LvMain.Items.Add(listViewItem);
                }
            }
            conn.ClosePDO();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            PPEOscarAutoModif.Form2 modif = new PPEOscarAutoModif.Form2();
            modif.ShowDialog();
            LvMain.Items.Clear();
            update();

        }
    }
}
