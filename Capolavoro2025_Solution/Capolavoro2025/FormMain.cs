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

        private void FormMain_Load(object sender, EventArgs e)
        {
            SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "magazzino.txt");
        }

        private void SettaDgv(DataGridView dgv, string intestazioni, string file)
        {
            string[] intestazioniArray = intestazioni.Split(' ');
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = true;
            dgv.ColumnCount = intestazioniArray.Length;
            for (int i = 0; i < intestazioniArray.Length; i++)
            {
                dgv.Columns[i].HeaderText = intestazioniArray[i];
            }
            ClsFileMagazzino.RiempiDgv(dgv, file);
            dgv.ClearSelection();
        }

        private void btnAggiungiPezzi_Click(object sender, EventArgs e)
        {
            if (txtOggetto.Text == "" || txtOggetto.Text == null ||
                txtMateriale.Text == "" || txtMateriale.Text == null ||
                txtDimensione.Text == "" || txtDimensione.Text == null ||
                txtPeso.Text == "" || txtPeso.Text == null ||
                nudCosto.Value == 0 ||
                nudQuantità.Value == 0 ||
                txtCodice.Text == "" || txtCodice.Text == null)
            {
                MessageBox.Show("Inserire un pezzo valido!\nAssicurati di aver completato tutti i campi", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool modifica = ClsFileMagazzino.AggiungiPezziAlFile("magazzino.txt", txtOggetto, txtMateriale, txtDimensione, txtPeso, nudCosto, nudQuantità, txtCodice);
            if (modifica)
            {
                MessageBox.Show("Pezzo già esistente, quantità aggiornata");
            }
            else
            {
                MessageBox.Show("Pezzo aggiunto");
            }
            ClsFileMagazzino.RiempiDgv(DgvMagazzino, "magazzino.txt");
            //SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Costo Quantità Codice", "magazzino.txt");
        }

        private void btnRimuoviOggetto_Click(object sender, EventArgs e)
        {
            if (txtOggetto.Text == "" || txtOggetto.Text == null ||
                txtMateriale.Text == "" || txtMateriale.Text == null ||
                txtDimensione.Text == "" || txtDimensione.Text == null ||
                txtPeso.Text == "" || txtPeso.Text == null ||
                nudCosto.Value == 0 ||
                nudQuantità.Value == 0 ||
                txtCodice.Text == "" || txtCodice.Text == null)
            {
                MessageBox.Show("Inserire un pezzo valido!\nAssicurati di aver completato tutti i campi", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool modifica = ClsFileMagazzino.RimuoviPezziAlFile("magazzino.txt", txtOggetto, txtMateriale, txtDimensione, txtPeso, nudCosto, nudQuantità, txtCodice);
            if (modifica)
            {
                MessageBox.Show("Pezzo rimosso corretamente");
            }
            else
            {
                MessageBox.Show("Pezzo non trovato", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClsFileMagazzino.RiempiDgv(DgvMagazzino, "magazzino.txt");
            //SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Costo Quantità Codice", "magazzino.txt");
        }

        private void btnCercaPezzo_Click(object sender, EventArgs e)
        {
            string pezzo;
            do
            {
                pezzo = Interaction.InputBox("Inserisci il codice dell'oggetto da cercare:");
                if (pezzo == "")
                {
                    DialogResult annullaRisultato = MessageBox.Show("Vuoi annullare l'operazione?", "Conferma Annullamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (annullaRisultato == DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Inserire un pezzo valido!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } while (pezzo == "");

            string message = ClsFileMagazzino.CercaPezzoNelFile("magazzino.txt", DgvMagazzino, pezzo);

            if (message == "")
            {
                MessageBox.Show("Pezzo non trovato!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(message, "INFORMAZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            FormOrdine form = new FormOrdine();
            allForms.Add(form);
            this.Close();
            this.Hide();
            form.Show();
        }
    }
}
