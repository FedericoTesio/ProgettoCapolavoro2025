using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capolavoro2025
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SettaDgv(DgvMagazzino, "Oggetto Materiale Dimensione Costo Quantità Codice", "input.txt");
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
            ClsFile.RiempiDgv(dgv, file);
            dgv.ClearSelection();
        }
    }
}
