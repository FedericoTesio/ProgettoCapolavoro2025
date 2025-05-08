using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Capolavoro2025.ClsFile;

namespace Capolavoro2025
{
    internal class ClsFile
    {

        public struct Pezzo
        {
            public string Nome;
            public string Materiale;
            public string Dimensione;
            public double Costo;
            public int Quantita;
            public string Codice;
        }

        public static void RiempiDgv(DataGridView dgv, string inputFile)
        {
            StreamReader sr = new StreamReader(inputFile);
            dgv.Rows.Clear();
            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split(' ');
                dgv.Rows.Add(valori);
            }
            sr.Close();
        }
        /// <summary>
        /// Aggiunge un pezzo al file di input. Se il pezzo esiste già, aggiorna la quantità.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="txtOggetto"></param>
        /// <param name="txtMateriale"></param>
        /// <param name="txtDimensione"></param>
        /// <param name="nudCosto"></param>
        /// <param name="nudQuantità"></param>
        /// <param name="txtCodice"></param>
        /// <returns> ritorna un bool cosi visualizziamo una messageBox che ci informa sulle azioni svolte</returns>
        public static bool AggiungiPezziAlFile(string inputFile, TextBox txtOggetto, TextBox txtMateriale, TextBox txtDimensione, NumericUpDown nudCosto, NumericUpDown nudQuantità, TextBox txtCodice)
        {
            Pezzo nuovoPezzo = new Pezzo();
            nuovoPezzo.Nome = txtOggetto.Text;
            nuovoPezzo.Materiale = txtMateriale.Text;
            nuovoPezzo.Dimensione = txtDimensione.Text;
            nuovoPezzo.Costo = (double)nudCosto.Value;
            nuovoPezzo.Quantita = (int)nudQuantità.Value;
            nuovoPezzo.Codice = txtCodice.Text;

            List<string> righe = new List<string>();
            bool trovato = false;

            StreamReader sr = new StreamReader(inputFile);
            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split(' ');

                // controllo se il pezzo esiste già 
                if (valori[5] == nuovoPezzo.Codice)
                {
                    trovato = true;
                    int nuovaQuantita = Convert.ToInt32(valori[4]) + nuovoPezzo.Quantita;
                    righe.Add($"{valori[0]} {valori[1]} {valori[2]} {valori[3]} {nuovaQuantita} {valori[5]}");
                }
                else
                {
                    righe.Add(riga);
                }
            }
            sr.Close();

            // aggiungo il pezzo non esistente
            if (!trovato)
            {
                righe.Add($"{nuovoPezzo.Nome} {nuovoPezzo.Materiale} {nuovoPezzo.Dimensione} {nuovoPezzo.Costo} {nuovoPezzo.Quantita} {nuovoPezzo.Codice}");
            }

            // utilizzo un bool pk devo capire se devo sovrascrivere(false) o aggiungere(true)
            StreamWriter sw = new StreamWriter(inputFile, false);
            for (int i = 0; i < righe.Count; i++)
            {
                sw.WriteLine(righe[i]);
            }
            sw.Close();

            return trovato;
        }

        internal static bool RimuoviPezziAlFile(string inputFile, TextBox txtOggetto, TextBox txtMateriale, TextBox txtDimensione, NumericUpDown nudCosto, NumericUpDown nudQuantità, TextBox txtCodice)
        {
            Pezzo pezzoDaRimuovere = new Pezzo();
            pezzoDaRimuovere.Codice = txtCodice.Text;
            pezzoDaRimuovere.Quantita = (int)nudQuantità.Value;

            List<string> righe = new List<string>();
            bool rimosso = false;

            StreamReader sr = new StreamReader(inputFile);
            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split(' ');

                if (valori[5] == pezzoDaRimuovere.Codice)
                {
                    int quantitaAttuale = Convert.ToInt32(valori[4]);
                    int nuovaQuantita = quantitaAttuale - pezzoDaRimuovere.Quantita;

                    if (nuovaQuantita > 0)
                    {
                        righe.Add($"{valori[0]} {valori[1]} {valori[2]} {valori[3]} {nuovaQuantita} {valori[5]}");
                    }
                    rimosso = true;
                }
                else
                {
                    righe.Add(riga);
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(inputFile, false);
            for (int i = 0; i < righe.Count; i++)
            {
                sw.WriteLine(righe[i]);
            }
            sw.Close();

            return rimosso;
        }
    }
}
