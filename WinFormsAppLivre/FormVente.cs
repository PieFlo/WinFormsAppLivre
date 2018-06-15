using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsAppLivre
{
    public partial class FormVente : Form
    {
        private FormVente _vente;
        public FormVente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormVente_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pROJETDataSetLivres.Livres'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.livresTableAdapter1.Fill(this.pROJETDataSetLivres.Livres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("procNewVente", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@idVendeur", LoginInfo.idUser);
                sqlCmd.Parameters.AddWithValue("@idLivre", comboBox1.SelectedValue);
                sqlCmd.Parameters.AddWithValue("@prix", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@etat", comboBoxEtat.SelectedItem);
                sqlCmd.Parameters.AddWithValue("@dispo", comboBox2.SelectedItem);


                int nbRecords = sqlCmd.ExecuteNonQuery();
                
                if (nbRecords > 0)
                    MessageBox.Show("Votre livre a bien été mis en vente.");
                else
                    MessageBox.Show("Désolé, votre livre n'as pas pu été mis en vente.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormPanel.Panel.Show();
            this.Dispose();
            this.Close();
        }

        private void comboBoxEtat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
