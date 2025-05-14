using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capolavoro2025.ClsFileMagazzino;

namespace Capolavoro2025
{
    internal class ClsFileOrdine
    {
        public struct Pezzo
        {
            public string Nome;
            public string Materiale;
            public string Dimensione;
            public string Peso;
            public string Costo;
            public int Quantita;
            public string Codice;
        }
        private static bool CercaPezzoNelOrdine(string OrdineFile, string pezzo)
        {
            StreamReader sr = new StreamReader(OrdineFile);
            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split('-');

                if (valori[6] == pezzo)
                {

                    return true;
                }
            }
            sr.Close();
            return false;
        }

        public static string[] AggiungiPezzoOrdine(string pezzo, int quantita, string OrdineFile)
        {
            bool PezzoGiaPresente = CercaPezzoNelOrdine(OrdineFile, pezzo);

            if (PezzoGiaPresente)
            {
                string[] message = { "Il pezzo è già presente nell'ordine!", "0" };
                return message;
            }

            // Popolo la struct così mi salvo i dati del pezzo
            Pezzo PezzoStruct = new Pezzo();
            StreamReader sr = new StreamReader("magazzino.txt");
            bool trovato = false;
            while (!sr.EndOfStream || !trovato)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split('-');

                if (valori[6] == pezzo)
                {
                    PezzoStruct.Nome = valori[0];
                    PezzoStruct.Materiale = valori[1];
                    PezzoStruct.Dimensione = valori[2];
                    PezzoStruct.Peso = valori[3];
                    PezzoStruct.Costo = valori[4];
                    PezzoStruct.Quantita = Convert.ToInt32(valori[5]);
                    PezzoStruct.Codice = valori[6];
                    trovato = true;
                }
            }
            sr.Close();
            if (trovato) {
                StreamWriter sw = new StreamWriter(OrdineFile, true);
                sw.WriteLine($"{PezzoStruct.Nome}-{PezzoStruct.Materiale}-{PezzoStruct.Dimensione}-{PezzoStruct.Peso}-{PezzoStruct.Costo}-{quantita}-{pezzo}");
                sw.Close();
                string[] message = { "Pezzo aggiunto all'ordine correttamente!", "1" };
                return message;
            }
            else
            {
                string[] message = { "Pezzo non trovato!", "2" };
                return message;
            }
        }
    }
}
