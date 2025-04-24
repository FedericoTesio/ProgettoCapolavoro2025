using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capolavoro2025
{
    internal class ClsFile
    {
        public static void RiempiDgv(DataGridView dgv, string file)
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split(' ');
                dgv.Rows.Add(valori);
            }
        }
    }
}
