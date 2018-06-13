namespace WinFormsAppLivre
{
    partial class FormAchat
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
            this.labelAuteur = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelLivre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelVendeur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAuteur
            // 
            this.labelAuteur.AutoSize = true;
            this.labelAuteur.Location = new System.Drawing.Point(148, 136);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(80, 17);
            this.labelAuteur.TabIndex = 33;
            this.labelAuteur.Text = "labelAuteur";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(148, 102);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(78, 17);
            this.labelGenre.TabIndex = 32;
            this.labelGenre.Text = "labelGenre";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(148, 70);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(59, 17);
            this.labelCat.TabIndex = 31;
            this.labelCat.Text = "labelCat";
            // 
            // labelLivre
            // 
            this.labelLivre.AutoSize = true;
            this.labelLivre.Location = new System.Drawing.Point(148, 37);
            this.labelLivre.Name = "labelLivre";
            this.labelLivre.Size = new System.Drawing.Size(69, 17);
            this.labelLivre.TabIndex = 30;
            this.labelLivre.Text = "labelLivre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Auteur(s) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Genre(s) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Titre :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelEtat);
            this.groupBox1.Controls.Add(this.labelPrix);
            this.groupBox1.Controls.Add(this.labelVendeur);
            this.groupBox1.Location = new System.Drawing.Point(24, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 82);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information sur la vente";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(210, 35);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(33, 17);
            this.labelEtat.TabIndex = 2;
            this.labelEtat.Text = "Etat";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(348, 35);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(31, 17);
            this.labelPrix.TabIndex = 1;
            this.labelPrix.Text = "Prix";
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Location = new System.Drawing.Point(17, 35);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(82, 17);
            this.labelVendeur.TabIndex = 0;
            this.labelVendeur.Text = "Vendu par :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 34;
            this.button1.Text = "Confirmer l\'achat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelAuteur);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelGenre);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelCat);
            this.groupBox2.Controls.Add(this.labelLivre);
            this.groupBox2.Location = new System.Drawing.Point(72, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 180);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vous êtes sur le point d\'acheter";
            // 
            // FormAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAchat";
            this.Text = "Confirmer l\'achat";
            this.Load += new System.EventHandler(this.FormAchat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAuteur;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelLivre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}