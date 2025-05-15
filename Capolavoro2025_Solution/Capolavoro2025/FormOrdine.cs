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
    public partial class FormOrdine : Form
    {
        private static List<Form> allForms = new List<Form>();
        public FormOrdine()
        {
            InitializeComponent();
            allForms.Add(this);
        }

        private void FormOrdine_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormOrdine_FormClosed(object sender, FormClosedEventArgs e)
        {
            allForms.Remove((Form)sender);
        }

        private void FormOrdine_Load(object sender, EventArgs e)
        {
            SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "magazzino.txt");
            SettaDgv(DgvOrdine, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "ordine.txt");
        }

        private void SettaDgv(DataGridView dgv, string intestazioni, string file)
        {
            dgv.Rows.Clear();
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

        private void btnAggiungiPezzo_Click(object sender, EventArgs e)
        {
            string pezzo;
            string quantita;
            do
            {
                pezzo = Interaction.InputBox("Inserisci il codice dell'oggetto da aggiungere al ordine:");
                quantita = Interaction.InputBox("Inserisci la quantità del pezzo da aggiungere al ordine:");
                if (pezzo == "" || pezzo == null || quantita == "" || quantita == null)
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
            } while (pezzo == "" || Convert.ToInt32(quantita) <= 0);
            string[] message = ClsFileOrdine.AggiungiPezzoOrdine(pezzo, Convert.ToInt32(quantita), "ordine.txt");
            SettaDgv(DgvOrdine, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "ordine.txt");
            if (Convert.ToInt32(message[1]) == 2)
            {
                MessageBox.Show(message[0], "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(message[0], "INFORMAZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}
