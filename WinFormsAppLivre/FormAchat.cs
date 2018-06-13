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
    public partial class FormAchat : Form
    {
        private string idVente;
        private string idLivre;
        private string vendeur;
        private string prix;
        private string etat;
        private string livre;
    
        public string IdVente { set => idVente = value;}
        public string IdLivre { set => idLivre = value;}
        public string Vendeur { set => vendeur = value; }
        public string Prix { set => prix = value; }
        public string Etat { set => etat = value; }
        public string Livre { set => livre = value; }

        public FormAchat()
        {
            InitializeComponent();
        }

        private void FormAchat_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(LoginInfo.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(@"  SELECT nom_cat, nom_genre, (prenom +' '+ nom_auteur) AS auteur
                                                        FROM Livres l, Categories c, Genres g, Auteurs a, CorrespCat cc, CorrespGenre cg, Ecrit ca
                                                        WHERE l.id_livre = cc.id_livre AND l.id_livre = cg.id_livre AND l.id_livre = ca.id_livre
                                                        AND c.id_cat = cc.id_cat AND g.id_genre = cg.id_genre AND a.id_auteur = ca.id_auteur 
                                                        AND l.id_livre = "+ idLivre +";", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int count = 0; string rowGenre = ""; string rowAuteur = "";
            foreach (DataRow item in dt.Rows)
            {
                if (count == 0)
                {
                    labelCat.Text = item[0].ToString();
                    rowGenre = item[1].ToString();
                    labelGenre.Text = rowGenre;
                    rowAuteur = item[2].ToString();
                    labelAuteur.Text = rowAuteur;
                }
                else if (item[1].ToString() != rowGenre)
                    labelGenre.Text = labelGenre.Text + ", " + item[1].ToString();
                else if (item[2].ToString() != rowAuteur)
                    labelAuteur.Text = labelAuteur.Text + ", " + item[2].ToString();
                count++;
            }
                
            labelVendeur.Text = labelVendeur.Text + ' '+vendeur;
            labelEtat.Text = etat;
            labelPrix.Text = prix;
            labelLivre.Text = livre;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("procAchat", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@idVente", idVente);
                    sqlCmd.Parameters.AddWithValue("@idAcheteur", LoginInfo.idUser);
               
                    sqlCmd.Parameters.Add("@payable", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    sqlCmd.ExecuteNonQuery();
                    int retval = (int)sqlCmd.Parameters["@payable"].Value;
                    if (retval == 1)
                    {

                        MessageBox.Show("Demande d'achat envoyé, en attente de confirmation du vendeur.");
                        FormListVentes.ListVentes.Dispose();
                        FormListVentes.ListVentes.Close();
                        FormPanel.Panel.Show();
                    }
                    else if (retval == 0)
                        MessageBox.Show("Solde insuffisant.");
                }


        }
    }
}
