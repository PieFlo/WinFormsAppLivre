namespace WinFormsAppLivre
{
    partial class FormVente
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.livresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETDataSetLivres = new WinFormsAppLivre.PROJETDataSetLivres();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.livresTableAdapter1 = new WinFormsAppLivre.PROJETDataSetLivresTableAdapters.LivresTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.livresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETDataSetLivres)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Soumettre la vente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Etat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Livre";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livresBindingSource, "id_livre", true));
            this.comboBox1.DataSource = this.livresBindingSource;
            this.comboBox1.DisplayMember = "titre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "id_livre";
            // 
            // livresBindingSource
            // 
            this.livresBindingSource.DataMember = "Livres";
            this.livresBindingSource.DataSource = this.pROJETDataSetLivres;
            // 
            // pROJETDataSetLivres
            // 
            this.pROJETDataSetLivres.DataSetName = "PROJETDataSetLivres";
            this.pROJETDataSetLivres.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 48);
            this.button2.TabIndex = 20;
            this.button2.Text = "Ajouter un nouveau livre";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "€";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 22);
            this.textBox1.TabIndex = 23;
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Items.AddRange(new object[] {
            "comme neuf",
            "très bon état",
            "bon état",
            "état correct",
            "mauvais état"});
            this.comboBoxEtat.Location = new System.Drawing.Point(130, 123);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEtat.TabIndex = 33;
            this.comboBoxEtat.SelectedIndexChanged += new System.EventHandler(this.comboBoxEtat_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(310, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(168, 58);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxEtat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(37, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 255);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle vente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Si votre livre n\'est pas listé, ajoutez le.";
            // 
            // livresTableAdapter1
            // 
            this.livresTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livresBindingSource, "id_livre", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "disponible",
            "indisponible"});
            this.comboBox2.Location = new System.Drawing.Point(283, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // FormVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Name = "FormVente";
            this.Text = "Vendre un livre";
            this.Load += new System.EventHandler(this.FormVente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETDataSetLivres)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        //private PROJETDataSet2 pROJETDataSet;
        //private PROJETDataSet2TableAdapters.LivresTableAdapter livresTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private PROJETDataSetLivres pROJETDataSetLivres;
        private System.Windows.Forms.BindingSource livresBindingSource;
        private PROJETDataSetLivresTableAdapters.LivresTableAdapter livresTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}