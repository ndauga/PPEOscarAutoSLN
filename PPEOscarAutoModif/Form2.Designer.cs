namespace PPEOscarAutoModif
{
    partial class Form2
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbCodePostal = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.lbVille = new System.Windows.Forms.Label();
            this.listbId = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(9, 337);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.Location = new System.Drawing.Point(70, 337);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 19);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(130, 337);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(7, 7);
            this.lbId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(17, 15);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "Id";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(7, 45);
            this.lbNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(34, 15);
            this.lbNom.TabIndex = 5;
            this.lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(7, 86);
            this.lbPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(51, 15);
            this.lbPrenom.TabIndex = 6;
            this.lbPrenom.Text = "Prenom";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Location = new System.Drawing.Point(7, 132);
            this.lbAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(51, 15);
            this.lbAdresse.TabIndex = 7;
            this.lbAdresse.Text = "Adresse";
            // 
            // lbCodePostal
            // 
            this.lbCodePostal.AutoSize = true;
            this.lbCodePostal.Location = new System.Drawing.Point(7, 185);
            this.lbCodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodePostal.Name = "lbCodePostal";
            this.lbCodePostal.Size = new System.Drawing.Size(73, 15);
            this.lbCodePostal.TabIndex = 8;
            this.lbCodePostal.Text = "Code Postal";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(70, 42);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(137, 20);
            this.tbNom.TabIndex = 10;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(70, 84);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(137, 20);
            this.tbPrenom.TabIndex = 11;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(70, 129);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(137, 20);
            this.tbAdresse.TabIndex = 12;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(70, 183);
            this.tbCodePostal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(137, 20);
            this.tbCodePostal.TabIndex = 13;
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(70, 240);
            this.tbVille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(137, 20);
            this.tbVille.TabIndex = 15;
            // 
            // lbVille
            // 
            this.lbVille.AutoSize = true;
            this.lbVille.Location = new System.Drawing.Point(7, 243);
            this.lbVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVille.Name = "lbVille";
            this.lbVille.Size = new System.Drawing.Size(30, 15);
            this.lbVille.TabIndex = 14;
            this.lbVille.Text = "Ville";
            // 
            // listbId
            // 
            this.listbId.FormattingEnabled = true;
            this.listbId.HorizontalScrollbar = true;
            this.listbId.Location = new System.Drawing.Point(70, 7);
            this.listbId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listbId.Name = "listbId";
            this.listbId.Size = new System.Drawing.Size(137, 17);
            this.listbId.TabIndex = 16;
            this.listbId.SelectedIndexChanged += new System.EventHandler(this.listbId_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(242, 366);
            this.Controls.Add(this.listbId);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.lbVille);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbCodePostal);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbCodePostal;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label lbVille;
        private System.Windows.Forms.ListBox listbId;
    }
}

