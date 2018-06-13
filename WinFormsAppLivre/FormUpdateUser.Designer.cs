namespace WinFormsAppLivre
{
    partial class FormUpdateUser
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.paysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETDataSetPays = new WinFormsAppLivre.PROJETDataSetPays();
            this.cbBoxVille = new System.Windows.Forms.ComboBox();
            this.villesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETDataSetVilles = new WinFormsAppLivre.PROJETDataSetVilles();
            this.paysTableAdapter = new WinFormsAppLivre.PROJETDataSetPaysTableAdapters.PaysTableAdapter();
            this.villesTableAdapter = new WinFormsAppLivre.PROJETDataSetVillesTableAdapters.VillesTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETDataSetPays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETDataSetVilles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(309, 409);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 37);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "valider";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Répéter mot de passe";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adresse e-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(516, 83);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.Size = new System.Drawing.Size(146, 34);
            this.txtConfirmPwd.TabIndex = 12;
            this.txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(516, 43);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(146, 34);
            this.txtPwd.TabIndex = 11;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(160, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 34);
            this.txtEmail.TabIndex = 10;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(115, 230);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(48, 23);
            this.nom.TabIndex = 19;
            this.nom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(169, 222);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(146, 34);
            this.txtNom.TabIndex = 18;
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(93, 270);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(70, 23);
            this.prenom.TabIndex = 21;
            this.prenom.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(169, 262);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(146, 34);
            this.txtPrenom.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date de naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Adresse";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(446, 262);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(146, 34);
            this.txtAdresse.TabIndex = 24;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(160, 43);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 34);
            this.txtUsername.TabIndex = 9;
            // 
            // paysBindingSource
            // 
            this.paysBindingSource.DataMember = "Pays";
            this.paysBindingSource.DataSource = this.pROJETDataSetPays;
            // 
            // pROJETDataSetPays
            // 
            this.pROJETDataSetPays.DataSetName = "PROJETDataSetPays";
            this.pROJETDataSetPays.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbBoxVille
            // 
            this.cbBoxVille.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.villesBindingSource, "id_ville", true));
            this.cbBoxVille.DataSource = this.villesBindingSource;
            this.cbBoxVille.DisplayMember = "nom_ville";
            this.cbBoxVille.FormattingEnabled = true;
            this.cbBoxVille.Location = new System.Drawing.Point(446, 221);
            this.cbBoxVille.Name = "cbBoxVille";
            this.cbBoxVille.Size = new System.Drawing.Size(146, 24);
            this.cbBoxVille.TabIndex = 27;
            this.cbBoxVille.ValueMember = "id_ville";
            this.cbBoxVille.SelectedIndexChanged += new System.EventHandler(this.cbBoxVille_SelectedIndexChanged);
            // 
            // villesBindingSource
            // 
            this.villesBindingSource.DataMember = "Villes";
            this.villesBindingSource.DataSource = this.pROJETDataSetVilles;
            this.villesBindingSource.CurrentChanged += new System.EventHandler(this.villesBindingSource_CurrentChanged);
            // 
            // pROJETDataSetVilles
            // 
            this.pROJETDataSetVilles.DataSetName = "PROJETDataSetVilles";
            this.pROJETDataSetVilles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paysTableAdapter
            // 
            this.paysTableAdapter.ClearBeforeFill = true;
            // 
            // villesTableAdapter
            // 
            this.villesTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ville";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // FormUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 488);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBoxVille);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Name = "FormUpdateUser";
            this.Text = "FormUpdateUser";
            this.Load += new System.EventHandler(this.FormUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETDataSetPays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETDataSetVilles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbBoxVille;
        private PROJETDataSetPays pROJETDataSetPays;
        private System.Windows.Forms.BindingSource paysBindingSource;
        private PROJETDataSetPaysTableAdapters.PaysTableAdapter paysTableAdapter;
        private PROJETDataSetVilles pROJETDataSetVilles;
        private System.Windows.Forms.BindingSource villesBindingSource;
        private PROJETDataSetVillesTableAdapters.VillesTableAdapter villesTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}