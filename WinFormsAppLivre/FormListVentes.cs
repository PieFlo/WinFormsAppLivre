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
    public partial class FormListVentes : Form
    {
        private static FormListVentes _listVentes;
        public static FormListVentes ListVentes
        {
            get
            {
                if (_listVentes == null || _listVentes.IsDisposed)
                    _listVentes = new FormListVentes();
                return _listVentes;
            }
        }
        public FormListVentes()
        {
            InitializeComponent();
        }

        private void FormListVentes_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(LoginInfo.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(@"  SELECT titre, prix, etat_livre, username, id_vente, l.id_livre FROM Ventes v, Livres l, Users u 
                                                        WHERE v.id_livre = l.id_livre AND v.id_vendeur = u.id_user 
                                                        AND etape_vente = 'disponible' AND id_vendeur != " + LoginInfo.idUser + ";", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2)+" €"; //prix
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString(); //username vendeur
                dataGridView1.Rows[n].Cells[4].Value = "Acheter";
                dataGridView1.Rows[n].Cells[5].Value = item[4].ToString(); //id_vente
                dataGridView1.Rows[n].Cells[6].Value = item[5].ToString(); //id_livre
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormPanel.Panel.Show();
            this.Dispose();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    var achat = new FormAchat
                    {
                        IdVente = row.Cells["idVente"].Value.ToString(),
                        IdLivre = row.Cells["idLivre"].Value.ToString(),
                        Vendeur = row.Cells["vendeur"].Value.ToString(),
                        Prix = row.Cells["prix"].Value.ToString(),
                        Etat = row.Cells["etat"].Value.ToString(),
                        Livre = row.Cells["livre"].Value.ToString()
                    };
                    achat.ShowDialog();
                
                }

            

        }

    }
}
