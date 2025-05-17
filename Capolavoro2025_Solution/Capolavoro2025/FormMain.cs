using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Capolavoro2025
{
    public partial class FormMain : Form
    {
        private static List<Form> allForms = new List<Form>();

        private bool PassVisbleOrNot = false;

        public FormMain()
        {
            InitializeComponent();
            allForms.Add(this);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (allForms.Count <= 1)
            {
                Application.Exit();
                e.Cancel = false;
            }
            else
            {
                allForms.Remove((Form)sender);
                e.Cancel = true;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            allForms.Remove((Form)sender);
        }

        private void btnInviaDati_Click(object sender, EventArgs e)
        {
            if (txtUtente.Text.ToLower() == "cliente" && txtPassword.Text == "Cliente12&")
            {
                FormOrdine form = new FormOrdine();
                allForms.Add(form);
                this.Close();
                this.Hide();
                form.Show();
                string message = ClsFileOrdine.CreaOrdine();
                if (message == "")
                {
                    MessageBox.Show("Errore nella creazione dell' ordine", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (txtUtente.Text.ToLower() == "commesso" && txtPassword.Text == "Commesso69£")
            {
                FormMagazzino form = new FormMagazzino();
                allForms.Add(form);
                this.Close();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Nome Utente o Password non corretti!\nRiprova", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PassVisbleOrNot = false;
                txtPassword.UseSystemPasswordChar = true;
                btnVisualizzaPassword.Text = "👀";
                PassVisbleOrNot = false;
                txtUtente.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnVisualizzaPassword_Click(object sender, EventArgs e)
        {
            if (PassVisbleOrNot)
            {
                txtPassword.UseSystemPasswordChar = true;
                btnVisualizzaPassword.Text = "👀";
                PassVisbleOrNot = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                btnVisualizzaPassword.Text = "👁";
                PassVisbleOrNot = true;
            }
        }
    }
}
