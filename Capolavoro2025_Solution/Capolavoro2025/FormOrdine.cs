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
            //SettaDgv(DgvOrdine, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "ordine.txt");
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

            bool PezzoGiaPresente = ClsFileOrdine.CercaPezzoNellOrdine("ordine.txt", pezzo);

            if (PezzoGiaPresente)
            {
                MessageBox.Show("Il pezzo è già presente nell'ordine!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult annullaRisultato = MessageBox.Show("Vuoi aumentare la quantità del pezzo nell'ordine?", "Conferma Aumento Quantità", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (annullaRisultato != DialogResult.Yes)
                {
                    return;
                }
            }

            string[] message = ClsFileOrdine.AggiungiPezzoOrdine(pezzo, Convert.ToInt32(quantita), "ordine.txt");

            if (Convert.ToInt32(message[1]) == 2)
            {
                MessageBox.Show(message[0], "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(message[0], "INFORMAZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            SettaDgv(DgvOrdine, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "ordine.txt");
            SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "magazzino.txt");
        }

        private void btnEliminaOrdine_Click(object sender, EventArgs e)
        {
            ClsFileOrdine.EliminaOrdine("ordine.txt");
            SettaDgv(DgvOrdine, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "ordine.txt");
            ClsFileOrdine.RiportaQuantits("ordine.txt", "magazzino.txt");
            SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "magazzino.txt");
            MessageBox.Show("Ordine elliminato con successo", "INFORMAZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnInviaOrdine_Click(object sender, EventArgs e)
        {
            string prezzoTotale = ClsFileOrdine.CalcolaPrezzoTotale("ordine.txt");
            DialogResult confermaRisultato = MessageBox.Show($"Il prezzo totale dell'ordine è di {prezzoTotale}.\nVuoi confermare l'ordine?", "Conferma Ordine", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confermaRisultato == DialogResult.Yes)
            {
                MessageBox.Show("Ordine inviato con successo", "INFORMAZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ClsFileOrdine.EliminaOrdine("ordine.txt");
                ClsFileOrdine.CreaOrdine();
                SettaDgv(DgvOrdine, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "ordine.txt");
            }
            else
            {
                MessageBox.Show("Ordine non inviato", "INFORMAZIONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void btnRimuoviPezzoOrdine_Click(object sender, EventArgs e)
        {
            string pezzo;
            string quantitaStr;
            int quantita;

            // Ciclo di input con validazione numerica e non nullità
            do
            {
                pezzo = Interaction.InputBox("Inserisci il codice dell'oggetto da rimuovere dall'ordine:");
                quantitaStr = Interaction.InputBox("Inserisci la quantità del pezzo da rimuovere dall'ordine:");

                if (string.IsNullOrWhiteSpace(pezzo) || string.IsNullOrWhiteSpace(quantitaStr))
                {
                    DialogResult annullaRisultato = MessageBox.Show("Vuoi annullare l'operazione?", "Conferma Annullamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (annullaRisultato == DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Inserire un pezzo e una quantità validi!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (!int.TryParse(quantitaStr, out quantita) || quantita <= 0)
                {
                    MessageBox.Show("La quantità deve essere un numero intero positivo!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pezzo = ""; // Forza il ciclo a ripetere
                }
            } while (string.IsNullOrWhiteSpace(pezzo) || !int.TryParse(quantitaStr, out quantita) || quantita <= 0);

            string[] message = ClsFileOrdine.RimuoviPezzoOrdine(pezzo, quantita, "ordine.txt");

            // Correggi la gestione del codice di ritorno: "1" = successo, "0" = errore
            if (message.Length > 1 && message[1] == "0")
            {
                MessageBox.Show(message[0], "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(message[0], "INFORMAZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SettaDgv(DgvOrdine, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "ordine.txt");
            SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Peso Costo Quantità Codice", "magazzino.txt");
        }
    }
}
