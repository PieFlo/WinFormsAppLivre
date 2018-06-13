namespace WinFormsAppLivre
{
    partial class FormListVentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.livre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acheter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.livre,
            this.prix,
            this.etat,
            this.vendeur,
            this.acheter,
            this.idVente,
            this.idLivre});
            this.dataGridView1.Location = new System.Drawing.Point(22, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(583, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(168, 58);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez faire votre choix parmi les offres des autres utilisateurs.";
            // 
            // livre
            // 
            this.livre.HeaderText = "Livre";
            this.livre.Name = "livre";
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            // 
            // etat
            // 
            this.etat.HeaderText = "Etat";
            this.etat.Name = "etat";
            // 
            // vendeur
            // 
            this.vendeur.HeaderText = "Vendeur";
            this.vendeur.Name = "vendeur";
            // 
            // acheter
            // 
            this.acheter.HeaderText = "";
            this.acheter.Name = "acheter";
            // 
            // idVente
            // 
            this.idVente.HeaderText = "IdVente";
            this.idVente.Name = "idVente";
            this.idVente.ReadOnly = true;
            this.idVente.Visible = false;
            // 
            // idLivre
            // 
            this.idLivre.HeaderText = "IdLivre";
            this.idLivre.Name = "idLivre";
            this.idLivre.ReadOnly = true;
            this.idLivre.Visible = false;
            // 
            // FormListVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormListVentes";
            this.Text = "Acheter un livre";
            this.Load += new System.EventHandler(this.FormListVentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn livre;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendeur;
        private System.Windows.Forms.DataGridViewButtonColumn acheter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivre;
    }
}