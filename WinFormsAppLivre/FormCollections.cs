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
    public partial class FormCollections : Form
    {
        //private static Collections _collections;
        public FormCollections()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCollections_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(LoginInfo.connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(@"select titre, numero_tome from livres l, ventes v where v.id_livre = l.id_livre and id_vendeur = " + LoginInfo.idUser+";", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString(); //nom collection
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString(); // titre tome

            }
        }
    }

/*
    public static FormCollections Collections
    {
        get
        {
            if (_collections == null || _collections.IsDisposed)
                _collections = new FormCollections();
            return _collections;
        }
    }*/

}
