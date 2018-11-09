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
//using WinFormsAppLivre.Models;

namespace WinFormsAppLivre
{
    public partial class FormRegister : Form
    {
        //string connectionString = @"Data Source=192.168.111.10;Initial Catalog=PROJET;Persist Security Info=True;User ID=sa;Password=abcd4ABCD;";
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPwd.Text == "" || txtConfirmPwd.Text == "")
                MessageBox.Show("Remplissez tous les champs svp");
            else if (txtPwd.Text != txtConfirmPwd.Text)
                MessageBox.Show("Les mots de passe ne correspondent pas");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("procInsertUser", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Mdp", txtPwd.Text.Trim());
                    sqlCmd.Parameters.Add("@exist", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                    sqlCmd.ExecuteNonQuery();
                    int retval = (int)sqlCmd.Parameters["@exist"].Value;
                    if (retval == 0)
                        MessageBox.Show("Inscription réussi");

                    else if (retval == 1)
                    {
                        MessageBox.Show("L'adresse mail ou le nom d'utilisateur est déjà utilisé");
                        Clear();
                    }
                        
                }
            }
        }

        void Clear()
        {
            txtUsername.Text = txtEmail.Text = txtPwd.Text = txtConfirmPwd.Text = "";
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
