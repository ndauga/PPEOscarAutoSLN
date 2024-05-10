namespace PPEOscarAutoConnect
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBase = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.lbMdp = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbBase2 = new System.Windows.Forms.Label();
            this.lbNom2 = new System.Windows.Forms.Label();
            this.lbMdp2 = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.tbNom2 = new System.Windows.Forms.TextBox();
            this.tbMdp2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase.Location = new System.Drawing.Point(5, 2);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(147, 20);
            this.lbBase.TabIndex = 0;
            this.lbBase.Text = "Indentifiez vous:";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(7, 39);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(39, 16);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "Nom:";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(104, 39);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 22);
            this.tbNom.TabIndex = 2;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(104, 64);
            this.tbMdp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.Size = new System.Drawing.Size(100, 22);
            this.tbMdp.TabIndex = 3;
            // 
            // lbMdp
            // 
            this.lbMdp.AutoSize = true;
            this.lbMdp.Location = new System.Drawing.Point(5, 70);
            this.lbMdp.Name = "lbMdp";
            this.lbMdp.Size = new System.Drawing.Size(92, 16);
            this.lbMdp.TabIndex = 4;
            this.lbMdp.Text = "Mot de passe:";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(225, 36);
            this.btnValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 186);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.lbBase);
            this.tabPage1.Controls.Add(this.btnValider);
            this.tabPage1.Controls.Add(this.lbNom);
            this.tabPage1.Controls.Add(this.lbMdp);
            this.tabPage1.Controls.Add(this.tbNom);
            this.tabPage1.Controls.Add(this.tbMdp);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(391, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connexion";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.lbBase2);
            this.tabPage2.Controls.Add(this.lbNom2);
            this.tabPage2.Controls.Add(this.lbMdp2);
            this.tabPage2.Controls.Add(this.btnEnregistrer);
            this.tabPage2.Controls.Add(this.tbNom2);
            this.tabPage2.Controls.Add(this.tbMdp2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(391, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Création Compte";
            // 
            // lbBase2
            // 
            this.lbBase2.AutoSize = true;
            this.lbBase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase2.Location = new System.Drawing.Point(5, 7);
            this.lbBase2.Name = "lbBase2";
            this.lbBase2.Size = new System.Drawing.Size(158, 20);
            this.lbBase2.TabIndex = 9;
            this.lbBase2.Text = "Créez un compte:";
            // 
            // lbNom2
            // 
            this.lbNom2.AutoSize = true;
            this.lbNom2.Location = new System.Drawing.Point(7, 44);
            this.lbNom2.Name = "lbNom2";
            this.lbNom2.Size = new System.Drawing.Size(39, 16);
            this.lbNom2.TabIndex = 10;
            this.lbNom2.Text = "Nom:";
            // 
            // lbMdp2
            // 
            this.lbMdp2.AutoSize = true;
            this.lbMdp2.Location = new System.Drawing.Point(5, 75);
            this.lbMdp2.Name = "lbMdp2";
            this.lbMdp2.Size = new System.Drawing.Size(92, 16);
            this.lbMdp2.TabIndex = 11;
            this.lbMdp2.Text = "Mot de passe:";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(229, 38);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(104, 23);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // tbNom2
            // 
            this.tbNom2.Location = new System.Drawing.Point(109, 41);
            this.tbNom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom2.Name = "tbNom2";
            this.tbNom2.Size = new System.Drawing.Size(100, 22);
            this.tbNom2.TabIndex = 6;
            // 
            // tbMdp2
            // 
            this.tbMdp2.Location = new System.Drawing.Point(109, 66);
            this.tbMdp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMdp2.Name = "tbMdp2";
            this.tbMdp2.Size = new System.Drawing.Size(100, 22);
            this.tbMdp2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(408, 199);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Label lbMdp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbBase2;
        private System.Windows.Forms.Label lbNom2;
        private System.Windows.Forms.Label lbMdp2;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox tbNom2;
        private System.Windows.Forms.TextBox tbMdp2;
    }
}

