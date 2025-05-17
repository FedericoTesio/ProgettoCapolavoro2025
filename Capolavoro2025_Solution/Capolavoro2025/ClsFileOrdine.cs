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
            StreamReader sr = new StreamReader(fileOrdine);
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

        public static string[] AggiungiPezzoOrdine(string pezzo, int quantita, string fileOrdine)
        {
            // Popolo la struct così mi salvo i dati del pezzo
            Pezzo PezzoStruct = new Pezzo();
            StreamReader sr = new StreamReader("magazzino.txt");
            bool trovato = false;
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
            sr.Close();

            if (trovato)
            {
                bool rimosso = ClsFileMagazzino.RimuoviPezziAlFile("magazzino.txt", quantita, PezzoStruct.Codice);
                if (rimosso)
                {
                    StreamWriter sw = new StreamWriter(fileOrdine, true);
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
            int prezzoTotale = 0;
            int prezzo = 0;
            int quantita = 0;
            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split('-');
                quantita = Convert.ToInt32(valori[5]);
                prezzo = Convert.ToInt32(valori[4].Replace("€", ""));
                prezzoTotale += prezzo * quantita;
            }
            sr.Close();
            return prezzoTotale.ToString() + "€";
        }

        internal static void RiportaQuantits(string fileOrdine, string fileMagazzino)
        {
            StreamReader sr = new StreamReader(fileOrdine);

            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] valori = riga.Split('-');
                ClsFileMagazzino.AggiungiPezziAlFile(fileMagazzino, valori[0], valori[1], valori[2], valori[3], valori[4], Convert.ToInt32(valori[5]), valori[6]);
            }
            sr.Close();
        }
    }
}
