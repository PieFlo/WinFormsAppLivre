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
    public partial class FormUpdateUser : Form
    {
        public FormUpdateUser()
        {
            InitializeComponent();
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pROJETDataSetVilles.Villes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villesTableAdapter.Fill(this.pROJETDataSetVilles.Villes);
            // TODO: cette ligne de code charge les données dans la table 'pROJETDataSetPays.Pays'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.paysTableAdapter.Fill(this.pROJETDataSetPays.Pays);

            txtUsername.Text = LoginInfo.username;
            txtEmail.Text = LoginInfo.email;
            txtPwd.Text = LoginInfo.mdp;
            txtConfirmPwd.Text = LoginInfo.mdp;
            if (LoginInfo.nom != null)
                txtNom.Text = LoginInfo.nom;
            if (LoginInfo.prenom != null)
                txtPrenom.Text = LoginInfo.prenom; 
            if (LoginInfo.dateNaissance != null )
                dateTimePicker1.Value = LoginInfo.dateNaissance;
            if (LoginInfo.adresse != null)
                txtAdresse.Text = LoginInfo.adresse;
            cbBoxVille.SelectedValue = LoginInfo.idVille;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPwd.Text == "" || txtConfirmPwd.Text == "" || txtNom.Text == "" || txtPrenom.Text == "" || txtAdresse.Text == "")
                MessageBox.Show("Remplissez tous les champs svp");
            else if (txtPwd.Text != txtConfirmPwd.Text)
                MessageBox.Show("Les mots de passe ne correspondent pas");
            else
            { 
                using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UPDATE Users SET username = @username, email =@email , mdp = @pwd, nom = @nom, prenom = @prenom, adresse = @adresse, date_naissance = @dateNaissance, id_ville = @idVille WHERE id_user = @idUser ; ", sqlCon);
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.Parameters.AddWithValue("@idUser", LoginInfo.idUser);
                    sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    sqlCmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
                    sqlCmd.Parameters.AddWithValue("@nom", txtNom.Text);
                    sqlCmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                    sqlCmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                    sqlCmd.Parameters.AddWithValue("@dateNaissance", dateTimePicker1.Value);
                    sqlCmd.Parameters.AddWithValue("@idVille", cbBoxVille.SelectedValue);


                    int nbRecords = sqlCmd.ExecuteNonQuery();

                    if (nbRecords > 0)
                    {
                        MessageBox.Show("votre compte a bien été mis  à jour.");
                        this.Dispose();
                        this.Close();
                    }
                       
                    else
                        MessageBox.Show("erreur.");
                }
            }
             

            
            
        }

        private void villesBindingSource_CurrentChanged(object sender, EventArgs e)
        {


        }

        private void cbBoxVille_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


    }
}
