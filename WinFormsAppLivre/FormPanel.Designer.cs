namespace WinFormsAppLivre
{
    partial class FormPanel
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
            this.labelWlcm = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnDeals = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSolde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWlcm
            // 
            this.labelWlcm.AutoSize = true;
            this.labelWlcm.Location = new System.Drawing.Point(213, 89);
            this.labelWlcm.Name = "labelWlcm";
            this.labelWlcm.Size = new System.Drawing.Size(75, 17);
            this.labelWlcm.TabIndex = 0;
            this.labelWlcm.Text = "Bienvenue";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(69, 162);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(129, 59);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Acheter un livre";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(364, 162);
            this.btnSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(129, 59);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Vendre un livre";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(216, 281);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(129, 59);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "Modifier ses informations";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(364, 281);
            this.btnDelUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(129, 59);
            this.btnDelUser.TabIndex = 4;
            this.btnDelUser.Text = "Supprimer mon Compte";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.Location = new System.Drawing.Point(69, 281);
            this.btnDeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(129, 59);
            this.btnDeals.TabIndex = 5;
            this.btnDeals.Text = "Mes deals";
            this.btnDeals.UseVisualStyleBackColor = true;
            this.btnDeals.Click += new System.EventHandler(this.btnDeals_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(423, 11);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(129, 59);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ma collection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSolde
            // 
            this.btnSolde.Location = new System.Drawing.Point(25, 19);
            this.btnSolde.Name = "btnSolde";
            this.btnSolde.Size = new System.Drawing.Size(150, 42);
            this.btnSolde.TabIndex = 8;
            this.btnSolde.Text = "Afficher mon solde";
            this.btnSolde.UseVisualStyleBackColor = true;
            this.btnSolde.Click += new System.EventHandler(this.btnSolde_Click);
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 372);
            this.Controls.Add(this.btnSolde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDeals);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.labelWlcm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPanel";
            this.Text = "Tableau de bord";
            this.Load += new System.EventHandler(this.FormPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWlcm;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Button btnDeals;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSolde;
    }
}