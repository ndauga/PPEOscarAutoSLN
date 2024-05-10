namespace PPEOscarAuto
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
            this.LvMain = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TbMain = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.CbSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LvMain
            // 
            this.LvMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LvMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNom,
            this.colPrenom,
            this.colAdresse,
            this.colCodePostal,
            this.colVille});
            this.LvMain.HideSelection = false;
            this.LvMain.Location = new System.Drawing.Point(1, 37);
            this.LvMain.Name = "LvMain";
            this.LvMain.Size = new System.Drawing.Size(806, 383);
            this.LvMain.TabIndex = 0;
            this.LvMain.UseCompatibleStateImageBehavior = false;
            this.LvMain.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colNom
            // 
            this.colNom.Text = "Nom";
            this.colNom.Width = 95;
            // 
            // colPrenom
            // 
            this.colPrenom.Text = "Prenom";
            this.colPrenom.Width = 106;
            // 
            // colAdresse
            // 
            this.colAdresse.Text = "Adresse";
            this.colAdresse.Width = 245;
            // 
            // colCodePostal
            // 
            this.colCodePostal.Text = "Code Postal";
            this.colCodePostal.Width = 501;
            // 
            // colVille
            // 
            this.colVille.Text = "Ville";
            this.colVille.Width = 58;
            // 
            // TbMain
            // 
            this.TbMain.Location = new System.Drawing.Point(424, 10);
            this.TbMain.Name = "TbMain";
            this.TbMain.Size = new System.Drawing.Size(278, 20);
            this.TbMain.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(708, 8);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 2;
            this.BtnSend.Text = "Envoyer";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // CbSelect
            // 
            this.CbSelect.FormattingEnabled = true;
            this.CbSelect.Location = new System.Drawing.Point(263, 9);
            this.CbSelect.Name = "CbSelect";
            this.CbSelect.Size = new System.Drawing.Size(155, 21);
            this.CbSelect.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Critère de Selection:";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(10, 9);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(806, 418);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbSelect);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbMain);
            this.Controls.Add(this.LvMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvMain;
        private System.Windows.Forms.TextBox TbMain;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.ComboBox CbSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colPrenom;
        private System.Windows.Forms.ColumnHeader colAdresse;
        private System.Windows.Forms.ColumnHeader colCodePostal;
        private System.Windows.Forms.ColumnHeader colVille;
        private System.Windows.Forms.Button btnModif;
    }
}

