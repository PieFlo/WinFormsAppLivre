using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WinFormsAppLivre
{
    public partial class DeRegister : Form
    {
        string connectionString = @"Data Source=sqlserver.montpellier.epsi.fr,4433;Initial Catalog=PROJET;Persist Security Info=True;User ID=p.poujol;Password=azerty;";

        public DeRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnection = connectionString;
            DialogResult retour = MessageBox.Show("Êtes-vous sur de vouloir supprimer votre compte ?", "Dernière chance", MessageBoxButtons.OKCancel);
            if (retour == DialogResult.Cancel)
            {
                MessageBox.Show("Compte non supprimé !");
                
            }
            else if (retour == DialogResult.OK)
            {
          
                SqlConnection myConn = new SqlConnection(myConnection);
                SqlCommand SelectCommand = new SqlCommand("DELETE FROM Users WHERE username ='" + textBox1.Text + "'", myConn);

                SqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Compte supprimé !");
            }
        }
    }
}
