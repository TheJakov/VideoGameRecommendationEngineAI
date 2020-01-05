using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sustavZaPreporukuVideoIgara.Helpers
{
    public static class ReadDataHelper
    {
        public static string ProcitajCSVPodatke()
        {
            //Čitanje podataka iz csv-a
            string putanja = @"../../../INTS - List of all games.csv";
            string csvIgreText = "";
            try
            {
                csvIgreText = System.IO.File.ReadAllText(putanja);
            }
            catch
            {
                MessageBox.Show("Došlo je do greške kod čitanja CSV datoteke igara.", "Ooops",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return csvIgreText;
        }

        public static string[] PrepoznajRetkeIzTeksta(string inputText, char splitter)
        {
            string[] izlaznaLista = inputText.Split(splitter);
            for (int i = 0; i < izlaznaLista.Length; i++)
            {
                izlaznaLista[i].Trim();
            }
            return izlaznaLista;
        }

        public static List<CSVGameModel> DohvatiListuIgara(string[] nizRedaka, char splitter)
        {
            List<CSVGameModel> izlaznaListaProcitanihIgara = new List<CSVGameModel>();

            //string[] atributiZaglavlja = nizRedaka[0].Split(splitter);
            for (int i = 1; i < nizRedaka.Length; i++)
            {
                string[] objektJedneIgre = nizRedaka[i].Split(splitter);

                //podrazumijeva se da su svi podaci u CSV-u ispravno formatirani, 
                //te nema provjera osim pretvorbe u odgovarajuci tip podatka

                CSVGameModel tempModelIgre = new CSVGameModel();

                tempModelIgre.GameName = objektJedneIgre[0].ToString().Trim();
                tempModelIgre.Platform = objektJedneIgre[1].ToString().Trim();
                tempModelIgre.ESRB = objektJedneIgre[2].ToString().Trim();
                tempModelIgre.Singleplayer = int.Parse(objektJedneIgre[3].Trim());
                tempModelIgre.Multiplayer = int.Parse(objektJedneIgre[4].Trim());
                tempModelIgre.Coop = int.Parse(objektJedneIgre[5].Trim());
                tempModelIgre.Price = int.Parse(objektJedneIgre[6].Trim());
                tempModelIgre.IGNRating = int.Parse(objektJedneIgre[7].Trim());
                tempModelIgre.CampaignDuration = int.Parse(objektJedneIgre[8].Trim());
                tempModelIgre.IsPopular = int.Parse(objektJedneIgre[9].Trim());
                tempModelIgre.CharCustomization = int.Parse(objektJedneIgre[10].Trim());
                tempModelIgre.WorldSize = int.Parse(objektJedneIgre[11].Trim());
                tempModelIgre.WorldDiversity = int.Parse(objektJedneIgre[12].Trim());
                tempModelIgre.Graphics = int.Parse(objektJedneIgre[13].Trim());
                tempModelIgre.Period = objektJedneIgre[14].ToString().Trim();
                tempModelIgre.Modding = int.Parse(objektJedneIgre[15].Trim());
                tempModelIgre.Competitive = int.Parse(objektJedneIgre[16].Trim());
                tempModelIgre.Genre = objektJedneIgre[17].ToString().Trim();
                tempModelIgre.Type = objektJedneIgre[18].ToString().Trim();
                tempModelIgre.Optimization = int.Parse(objektJedneIgre[19].Trim());

                izlaznaListaProcitanihIgara.Add(tempModelIgre);
            }
            return izlaznaListaProcitanihIgara;
        }
    }
}
