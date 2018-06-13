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
    public partial class FormDeals : Form
    {
        private static FormDeals _deals;
        public static FormDeals Deals
        {
            get
            {
                if (_deals == null || _deals.IsDisposed)
                    _deals = new FormDeals();
                return _deals;
            }
        }
        public FormDeals()
        {
            InitializeComponent();
        }

        private void FormDeals_Load(object sender, EventArgs e)
        {
            // REMPLISSAGES DATAGRIDVIEW

            SqlConnection con = new SqlConnection(LoginInfo.connectionString);

            // achats en attente de validation par le vendeur 

            SqlDataAdapter sda = new SqlDataAdapter(@"  SELECT titre, prix, etat_livre, username, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users u 
                                                        WHERE v.id_livre = l.id_livre AND v.id_vendeur = u.id_user 
                                                        AND etape_vente = 'demandé' and id_acheteur = " + LoginInfo.idUser + ";", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAchatsDemande.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvAchatsDemande.Rows.Add();
                dgvAchatsDemande.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dgvAchatsDemande.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2) + " €"; //prix
                dgvAchatsDemande.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dgvAchatsDemande.Rows[n].Cells[3].Value = item[3].ToString(); //username vendeur
                dgvAchatsDemande.Rows[n].Cells[4].Value = item[4].ToString(); //etape
                dgvAchatsDemande.Rows[n].Cells[5].Value = "Annuler";
                dgvAchatsDemande.Rows[n].Cells[6].Value = item[5].ToString(); //id_vente
                dgvAchatsDemande.Rows[n].Cells[7].Value = item[6].ToString(); //id_livre
            }

            //achat en attente de reception

            SqlDataAdapter sdaVal = new SqlDataAdapter(@"  SELECT titre, prix, etat_livre, username, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users u 
                                                        WHERE v.id_livre = l.id_livre AND v.id_vendeur = u.id_user 
                                                        AND etape_vente = 'validé' and id_acheteur = " + LoginInfo.idUser + ";", con);
            DataTable dtVal = new DataTable();
            sdaVal.Fill(dtVal);
            dgvAchatsValide.Rows.Clear();
            foreach (DataRow item in dtVal.Rows)
            {
                int n = dgvAchatsValide.Rows.Add();
                dgvAchatsValide.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dgvAchatsValide.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2) + " €"; //prix
                dgvAchatsValide.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dgvAchatsValide.Rows[n].Cells[3].Value = item[3].ToString(); //username vendeur
                dgvAchatsValide.Rows[n].Cells[4].Value = item[4].ToString(); //etape
                dgvAchatsValide.Rows[n].Cells[5].Value = "Confimer reception";
                dgvAchatsValide.Rows[n].Cells[6].Value = item[5].ToString(); //id_vente
                dgvAchatsValide.Rows[n].Cells[7].Value = item[6].ToString(); //id_livre
            }

            // Ventes dispo à la vente

            SqlDataAdapter sdaDispo = new SqlDataAdapter(@"  SELECT titre, prix, etat_livre, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users 
                                                        WHERE v.id_livre = l.id_livre AND v.id_vendeur = id_user AND etape_vente = 'disponible'
                                                         and id_vendeur = " + LoginInfo.idUser + ";", con);
            DataTable dtDispo = new DataTable();
            sdaDispo.Fill(dtDispo);
            dgvVentesDispo.Rows.Clear();
            foreach (DataRow item in dtDispo.Rows)
            {
                int n = dgvVentesDispo.Rows.Add();
                dgvVentesDispo.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dgvVentesDispo.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2) + " €"; //prix
                dgvVentesDispo.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dgvVentesDispo.Rows[n].Cells[3].Value = item[3].ToString(); //etape
                dgvVentesDispo.Rows[n].Cells[4].Value = "Annuler";
                dgvVentesDispo.Rows[n].Cells[5].Value = item[4].ToString(); //id_vente
                dgvVentesDispo.Rows[n].Cells[6].Value = item[5].ToString(); //id_livre

            }

            // Ventes à valider

            SqlDataAdapter sdaDem = new SqlDataAdapter(@"   SELECT titre, prix, etat_livre, acheteur.username, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users vendeur, Users acheteur
                                                            WHERE v.id_livre = l.id_livre AND v.id_acheteur = acheteur.id_user and v.id_vendeur = vendeur.id_user
                                                            AND etape_vente = 'demandé' AND id_vendeur = " + LoginInfo.idUser + ";", con);
            DataTable dtDem = new DataTable();
            sdaDem.Fill(dtDem);
            dgvVentesDemande.Rows.Clear();
            foreach (DataRow item in dtDem.Rows)
            {
                int n = dgvVentesDemande.Rows.Add();
                dgvVentesDemande.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dgvVentesDemande.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2) + " €"; //prix
                dgvVentesDemande.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dgvVentesDemande.Rows[n].Cells[3].Value = item[3].ToString();
                dgvVentesDemande.Rows[n].Cells[4].Value = item[4].ToString(); //etape
                dgvVentesDemande.Rows[n].Cells[5].Value = "Valider";
                dgvVentesDemande.Rows[n].Cells[6].Value = "Refuser";
                dgvVentesDemande.Rows[n].Cells[7].Value = item[5].ToString(); //id_vente
                dgvVentesDemande.Rows[n].Cells[8].Value = item[6].ToString(); //id_livre

            }

            // Ventes en attente de reception par l'acheteur

            SqlDataAdapter sdaVall = new SqlDataAdapter(@"   SELECT titre, prix, etat_livre, acheteur.username, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users vendeur, Users acheteur
                                                            WHERE v.id_livre = l.id_livre AND v.id_acheteur = acheteur.id_user and v.id_vendeur = vendeur.id_user
                                                            AND etape_vente = 'validé' AND id_vendeur = " + LoginInfo.idUser + ";", con);
            DataTable dtVall = new DataTable();
            sdaVall.Fill(dtVall);
            dgvVentesValide.Rows.Clear();
            foreach (DataRow item in dtVall.Rows)
            {
                int n = dgvVentesValide.Rows.Add();
                dgvVentesValide.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dgvVentesValide.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2) + " €"; //prix
                dgvVentesValide.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dgvVentesValide.Rows[n].Cells[3].Value = item[3].ToString();
                dgvVentesValide.Rows[n].Cells[4].Value = item[4].ToString(); //etape
                dgvVentesValide.Rows[n].Cells[5].Value = item[5].ToString(); //id_vente
                dgvVentesValide.Rows[n].Cells[6].Value = item[6].ToString(); //id_livre


            }
            grpBoxVentes.Visible = false;
            gbAchatFin.Hide();
            gbfinal.Hide();
        }

        // DATAGRIDVIEW BOUTONS
        private void dgvAchats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5)
                {
                    using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                    {
                        DataGridViewRow row = this.dgvAchatsDemande.Rows[e.RowIndex];
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UPDATE Ventes SET etape_vente = 'disponible', id_acheteur = NULL WHERE id_vente = @idVente and etape_vente = 'demandé'; ", sqlCon);
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.AddWithValue("@idVente", row.Cells["idVente"].Value.ToString());

                        int result = sqlCmd.ExecuteNonQuery();
                        
                        if (result > 1)
                        {
                            MessageBox.Show("Achat annulé avec succès.");
                            FormDeals.Deals.Dispose();
                            FormDeals.Deals.Close();
                            FormDeals.Deals.Show();
                        }
                        else 
                            MessageBox.Show("L'achat n'a pu être annulé.");
                    }
                }
            }
        }

        private void dgvVentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                {
                    DataGridViewRow row = this.dgvVentesDemande.Rows[e.RowIndex];
                    sqlCon.Open();
                    if (e.ColumnIndex == 5) // accepter
                    {
                        SqlCommand sqlCmd = new SqlCommand("UPDATE Ventes SET etape_vente = 'validé' WHERE id_vente = @idVente and etape_vente = 'demandé'; ", sqlCon);
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.AddWithValue("@idVente", row.Cells[7].Value.ToString());

                        int result = sqlCmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Vous avez accepté la vente");
                            FormDeals.Deals.Dispose();
                            FormDeals.Deals.Close();
                            FormDeals.Deals.Show();
                        }
                        else
                            MessageBox.Show("erreur");
                    }
                    else if (e.ColumnIndex == 6) // refuser
                    {
                        SqlCommand sqlCmd = new SqlCommand("UPDATE Ventes SET etape_vente = 'disponible', id_acheteur = NULL WHERE id_vente = @idVente and etape_vente = 'demandé'; ", sqlCon);

                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.AddWithValue("@idVente", row.Cells[7].Value.ToString());

                        int result = sqlCmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Vous avez refusé la vente.");
                            FormDeals.Deals.Dispose();
                            FormDeals.Deals.Close();
                            FormDeals.Deals.Show();
                        }
                        else
                            MessageBox.Show("erreur");
                    }
                }
            }
        }


        private void dgvVentesDispo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                    {
                        DataGridViewRow row = this.dgvVentesDispo.Rows[e.RowIndex];
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("DELETE FROM Ventes WHERE id_vente = @idVente and etape_vente = 'disponible'; ", sqlCon);
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.AddWithValue("@idVente", row.Cells[5].Value.ToString());

                        int result = sqlCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Vente annulé votre vente avec succès.");
                            FormDeals.Deals.Dispose();
                            FormDeals.Deals.Close();
                            FormDeals.Deals.Show();
                        }
                        else
                            MessageBox.Show("La vente n'a pas pu être annulé.");
                    }



                }
            }
        }

        private void dgvAchatsValide_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5)
                {
                    using (SqlConnection sqlCon = new SqlConnection(LoginInfo.connectionString))
                    {
                        DataGridViewRow row = this.dgvAchatsValide.Rows[e.RowIndex];
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UPDATE Ventes SET etape_vente = 'finalisé' WHERE id_vente = @idVente and etape_vente = 'validé'; ", sqlCon);
                        sqlCmd.CommandType = CommandType.Text;
                        sqlCmd.Parameters.AddWithValue("@idVente", row.Cells["idVvente"].Value.ToString());

                        int result = sqlCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Vous avez validé la reception de l'article.");
                            FormDeals.Deals.Dispose();
                            FormDeals.Deals.Close();
                            FormDeals.Deals.Show();
                        }
                        else
                            MessageBox.Show("erreur");
                    }
                }
            }
        }

        // BOUTONS
        private void btnFiAchats_Click(object sender, EventArgs e)
        {
            gbAchatFin.Show();

            SqlConnection con = new SqlConnection(LoginInfo.connectionString);

            // finalisé 

            SqlDataAdapter sda = new SqlDataAdapter(@"  SELECT titre, prix, etat_livre, username, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users u 
                                                        WHERE v.id_livre = l.id_livre AND v.id_vendeur = u.id_user 
                                                        AND etape_vente = 'finalisé' and id_acheteur = " + LoginInfo.idUser + ";", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAchatsFin.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvAchatsFin.Rows.Add();
                dgvAchatsFin.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dgvAchatsFin.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2) + " €"; //prix
                dgvAchatsFin.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dgvAchatsFin.Rows[n].Cells[3].Value = item[3].ToString(); //username vendeur
                dgvAchatsFin.Rows[n].Cells[4].Value = item[4].ToString(); //etape
                dgvAchatsFin.Rows[n].Cells[5].Value = item[5].ToString(); //id_vente
                dgvAchatsFin.Rows[n].Cells[6].Value = item[6].ToString(); //id_livre
            }

            btnFiAchats.Hide();
        }

        private void btnFiVentes_Click(object sender, EventArgs e)
        {
            gbfinal.Show();

            SqlConnection con = new SqlConnection(LoginInfo.connectionString);

            //  finalisé

            SqlDataAdapter sda = new SqlDataAdapter(@"  SELECT titre, prix, etat_livre, acheteur.username, etape_vente, id_vente, l.id_livre FROM Ventes v, Livres l, Users vendeur, Users acheteur
                                                            WHERE v.id_livre = l.id_livre AND v.id_acheteur = acheteur.id_user and v.id_vendeur = vendeur.id_user
                                                            AND etape_vente = 'finalisé' AND id_vendeur = " + LoginInfo.idUser + ";", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvVentesFin.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvVentesFin.Rows.Add();
                dgvVentesFin.Rows[n].Cells[0].Value = item[0].ToString(); //titre
                dgvVentesFin.Rows[n].Cells[1].Value = item[1].ToString().Substring(0, item[1].ToString().Length - 2) + " €"; //prix
                dgvVentesFin.Rows[n].Cells[2].Value = item[2].ToString(); //etat_livre
                dgvVentesFin.Rows[n].Cells[3].Value = item[3].ToString(); //username vendeur
                dgvVentesFin.Rows[n].Cells[4].Value = item[4].ToString(); //etape
                dgvVentesFin.Rows[n].Cells[5].Value = item[5].ToString(); //id_vente
                dgvVentesFin.Rows[n].Cells[6].Value = item[6].ToString(); //id_livre
            }

            btnFiVentes.Hide();
        }

        private void btnMesAchats_Click(object sender, EventArgs e)
        {
            grpBoxAchats.Visible = true;
            grpBoxVentes.Visible = false;

        }
        private void btnMesVentes_Click(object sender, EventArgs e)
        {
            grpBoxVentes.Visible = true;
            grpBoxAchats.Visible = false;

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormPanel.Panel.Show();
            this.Dispose();
            this.Close();
        }
    }
}
