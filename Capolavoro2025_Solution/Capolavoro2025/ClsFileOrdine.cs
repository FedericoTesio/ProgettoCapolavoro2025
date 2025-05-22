using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static string CreaOrdine()
        {
            string fileOrdine = "ordine.txt";
            File.Create(fileOrdine).Close();

            if (File.Exists(fileOrdine))
            {
                return "Ordine creato corretamente";
            }
            return "";
        }

        public static bool CercaPezzoNellOrdine(string fileOrdine, string pezzo)
        {
            using (StreamReader sr = new StreamReader(fileOrdine))
            {
                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    string[] valori = riga.Split('-');

                    if (valori[6] == pezzo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static string[] AggiungiPezzoOrdine(string pezzo, int quantita, string fileOrdine)
        {
            Pezzo PezzoStruct = new Pezzo();
            bool trovato = false;

            using (StreamReader sr = new StreamReader("magazzino.txt"))
            {
                while (!sr.EndOfStream && !trovato)
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
            }

            if (trovato)
            {
                bool rimosso = ClsFileMagazzino.RimuoviPezziAlFile("magazzino.txt", quantita, PezzoStruct.Codice);
                if (rimosso)
                {
                    using (StreamWriter sw = new StreamWriter(fileOrdine, true))
                    {
                        sw.WriteLine($"{PezzoStruct.Nome}-{PezzoStruct.Materiale}-{PezzoStruct.Dimensione}-{PezzoStruct.Peso}-{PezzoStruct.Costo}-{quantita}-{pezzo}");
                    }
                    string[] message = { "Pezzo aggiunto all'ordine correttamente!", "1" };
                    return message;
                }
                else
                {
                    string[] message = { "Pezzo non trovato!", "2" };
                    return message;
                }
            }
            else
            {
                string[] message = { "Pezzo non trovato!", "2" };
                return message;
            }
        }

        internal static void EliminaOrdine(string file)
        {
            File.Delete(file);
        }

        internal static string CalcolaPrezzoTotale(string file)
        {
            decimal prezzoTotale = 0;
            decimal prezzoDecimale = 0;
            int quantita = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    string[] valori = riga.Split('-');
                    quantita = Convert.ToInt32(valori[5]);
                    if (valori.Length >= 6 &&
                        int.TryParse(valori[5], out quantita) &&
                        decimal.TryParse(
                            valori[4].Replace("€", "").Replace(",", ".").Trim(),
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            out prezzoDecimale))
                    {
                        prezzoTotale += prezzoDecimale * quantita;
                    }
                    else
                    {
                        return "Errore nel calcolo del prezzo";
                    }
                }
            }
            return prezzoTotale.ToString() + "€";
        }

        internal static void RiportaQuantits(string fileOrdine, string fileMagazzino)
        {
            using (StreamReader sr = new StreamReader(fileOrdine))
            {
                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    string[] valori = riga.Split('-');
                    ClsFileMagazzino.AggiungiPezziAlFile(fileMagazzino, valori[0], valori[1], valori[2], valori[3], valori[4], Convert.ToInt32(valori[5]), valori[6]);
                }
            }
        }

        private void FormOrdine_FormClosed(object sender, FormClosedEventArgs e)
        {
            string fileOrdine = "ordine.txt";
            string fileMagazzino = "magazzino.txt";

            // Controlla se ci sono pezzi nell'ordine
            if (File.Exists(fileOrdine) && new FileInfo(fileOrdine).Length > 0)
            {
                ClsFileOrdine.RiportaQuantits(fileOrdine, fileMagazzino);

            }
        }

        internal static string[] RimuoviPezzoOrdine(string pezzo, int quantita, string fileOrdine)
        {
            if (!File.Exists(fileOrdine))
                return new string[] { "File ordine non trovato.", "0" };

            string[] righe = File.ReadAllLines(fileOrdine);
            List<string> nuoveRighe = new List<string>();
            bool trovato = false;

            for (int i = 0; i < righe.Length; i++)
            {
                string riga = righe[i];
                string[] valori = riga.Split('-');
                if (valori.Length >= 7 && valori[6] == pezzo)
                {
                    int quantitaAttuale;
                    if (!int.TryParse(valori[5], out quantitaAttuale))
                        return new string[] { "Quantità non valida nel file ordine.", "0" };

                    // Riaggiungi al magazzino la quantità rimossa
                    int quantitaDaRestituire = quantita >= quantitaAttuale ? quantitaAttuale : quantita;
                    ClsFileMagazzino.AggiungiPezziAlFile(
                        "magazzino.txt",
                        valori[0], // Nome
                        valori[1], // Materiale
                        valori[2], // Dimensione
                        valori[3], // Peso
                        valori[4], // Costo
                        quantitaDaRestituire,
                        valori[6]  // Codice
                    );

                    if (quantita >= quantitaAttuale)
                    {
                        // Non aggiungo la riga, quindi la rimuovo
                    }
                    else
                    {
                        valori[5] = (quantitaAttuale - quantita).ToString();
                        string nuovaRiga = string.Join("-", valori);
                        nuoveRighe.Add(nuovaRiga);
                    }
                    trovato = true;
                }
                else
                {
                    nuoveRighe.Add(riga);
                }
            }

            if (!trovato)
                return new string[] { "Pezzo non trovato nell'ordine.", "0" };

            File.WriteAllLines(fileOrdine, nuoveRighe.ToArray());
            return new string[] { "Pezzo rimosso dall'ordine correttamente.", "1" };
        }
    }
}
