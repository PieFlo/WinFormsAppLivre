﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppLivre
{
    public partial class FormPanel : Form
    {
        private static FormPanel _panel;
        public FormPanel()
        {
            InitializeComponent();
        }

        private void FormPanel_Load(object sender, EventArgs e)
        {
            labelWlcm.Text = "Bienvenue "+LoginInfo.username+" !";
        }
        public static FormPanel Panel
        {
            get
            {
                if (_panel == null || _panel.IsDisposed)
                    _panel = new FormPanel();
                return _panel;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //FormListVentes listVentes = new FormListVentes();
            //listVentes.Show();
            FormListVentes.ListVentes.Show();
            this.Hide();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            FormVente Vente = new FormVente();
            Vente.Show();
            this.Hide();
        }

        private void btnDeals_Click(object sender, EventArgs e)
        {
            FormDeals.Deals.Show();
            this.Hide();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FormUpdateUser updateUser = new FormUpdateUser();
            updateUser.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollections Collections = new FormCollections();
            Collections.ShowDialog();
        }
    }
}
