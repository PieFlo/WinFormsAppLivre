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
    public partial class FormLogin : Form
    {
        private static FormLogin _login;
        //string connectionString = @"Data Source=192.168.111.10;Initial Catalog=PROJET;Persist Security Info=True;User ID=sa;Password=abcd4ABCD;";
        public FormLogin()
        {
            InitializeComponent();
        }
        public static FormLogin Login
        {
            get
            {
                if (_login == null || _login.IsDisposed)
                    _login = new FormLogin();
                return _login;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPwd.Text == "")
                MessageBox.Show("Remplissez tous les champs svp");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                {
                    sqlCon.Open();
                    using (SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Users WHERE username='" + txtLogin.Text + "' OR email='" + txtLogin.Text + "' AND mdp='" + txtPwd.Text + "';", sqlCon))
                    {
                        DataTable dt = new DataTable();

                        sqlDA.Fill(dt);
                
                        if (dt.Rows.Count == 1)
                        {
                            LoginInfo.idUser = dt.Rows[0].Field<int>("id_user");
                            LoginInfo.username = dt.Rows[0].Field<string>("username");
                            LoginInfo.email = dt.Rows[0].Field<string>("email");
                            LoginInfo.mdp = dt.Rows[0].Field<string>("mdp");
                            LoginInfo.porteMonnais = dt.Rows[0].Field<int>("porte_monnais");
                            LoginInfo.isAdmin = dt.Rows[0].Field<bool>("is_admin");
                            DataRow dtRow = dt.Rows[0];
                            if(dtRow["id_ville"] != DBNull.Value)
                                LoginInfo.idVille = dt.Rows[0].Field<int>("id_ville");
                            if (dtRow["nom"] != DBNull.Value)
                                LoginInfo.nom = dt.Rows[0].Field<string>("nom");
                            if (dtRow["prenom"] != DBNull.Value)
                                LoginInfo.prenom = dt.Rows[0].Field<string>("prenom");
                            if (dtRow["date_naissance"] == DBNull.Value)
                                LoginInfo.dateNaissance = DateTime.Today;
                            else
                                LoginInfo.dateNaissance = dt.Rows[0].Field<DateTime>("date_naissance");
                            if (dtRow["adresse"] != DBNull.Value)
                                LoginInfo.adresse = dt.Rows[0].Field<string>("adresse");
                            FormPanel.Panel.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Identifiant ou mot de passe incorrect.");
                            Clear();
                        }
                            
                        
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inscription = new FormRegister();
            inscription.ShowDialog();
        }
        void Clear()
        {
            txtLogin.Text = txtPwd.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
