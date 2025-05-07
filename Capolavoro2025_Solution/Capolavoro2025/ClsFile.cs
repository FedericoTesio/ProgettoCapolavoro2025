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
            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split(' ');
                dgv.Rows.Add(valori);
            }
            sr.Close();
        }

        public static void AggiungiPezziAlFile(string inputFile, TextBox txtOggetto, TextBox txtMateriale, TextBox txtDimensione, NumericUpDown nudCosto, NumericUpDown nudQuantità, TextBox txtCodice)
        {
            Pezzo nuovoPezzo = new Pezzo();
            nuovoPezzo.Nome = txtOggetto.Text;
            nuovoPezzo.Materiale = txtMateriale.Text;
            nuovoPezzo.Dimensione = txtDimensione.Text;
            nuovoPezzo.Costo = (double)nudCosto.Value;
            nuovoPezzo.Quantita = (int)nudQuantità.Value;
            nuovoPezzo.Codice = txtCodice.Text;

            StreamReader sr = new StreamReader(inputFile);

            bool trovato = false;

            int quantita;

            while (!sr.EndOfStream && !trovato)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split(' ');
                if (valori[0] == nuovoPezzo.Nome)
                {
                    trovato = true;
                    quantita = Convert.ToInt32(valori[4]) + nuovoPezzo.Quantita;
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(inputFile);
            sw.Equals(nuovoPezzo.Nome,);

           
        }
    }
}
