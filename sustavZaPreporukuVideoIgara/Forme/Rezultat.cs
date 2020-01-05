using sustavZaPreporukuVideoIgara.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SustavZaPreporukuVideoIgaraML.Model;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace sustavZaPreporukuVideoIgara.Forme
{
    public partial class Rezultat : Form
    {
        private string cPath = @"..\..\..\Prediction\bin\Debug\netcoreapp3.1";
        private string path = @"..\..\..\Results.txt";
        private string pathArgs = @"..\..\..\Args.txt";

        public Rezultat()
        {
            InitializeComponent();
            
            ZapisiArgumenteUDatoteku();
            PokreniPredictionEXE();
            PuniLabelZaMlModel();
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            NavigationHelper.IdiNaFormu(this, pocetnaForma);
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void PokreniPredictionEXE()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(string.Concat(cPath, "\\", "Prediction.exe"));
            startInfo.UseShellExecute = false;

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
            }
        }

        private void PuniLabelZaMlModel()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    labelAIresult.Text = "";
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        labelAIresult.Text += s + "\n";
                    }
                }
            }
        }

        private string StvoriParametar()
        {
            string s = "";
            s += EvaluationModel.Platform;
            s = s + ";" + EvaluationModel.ESRB;
            s = s + ";" + EvaluationModel.Singleplayer;
            s = s + ";" + EvaluationModel.Multiplayer;
            s = s + ";" + EvaluationModel.Coop;
            s = s + ";" + EvaluationModel.Price;
            s = s + ";" + EvaluationModel.IGNRating;
            s = s + ";" + EvaluationModel.CampaignDurationMin;
            s = s + ";" + EvaluationModel.CampaignDurationMax;
            s = s + ";" + EvaluationModel.KoefPopular;
            s = s + ";" + EvaluationModel.KoefCustomization;
            s = s + ";" + EvaluationModel.KoefWorldSize;
            s = s + ";" + EvaluationModel.KoefWorldDiversity;
            s = s + ";" + EvaluationModel.KoefGraphicsQuality;
            s = s + ";" + EvaluationModel.ReleasePeriod;
            s = s + ";" + EvaluationModel.Modding;
            s = s + ";" + EvaluationModel.Competitive;

            s = s + ";" + "-l1;";

            foreach (string tip in EvaluationModel.ListOfTypes)
            {
                s = s + tip + ";";
            }

            s = s + "-l2;";

            foreach (string genre in EvaluationModel.ListOfGenres)
            {
                s = s + genre + ";";
            }

            return s.Trim();
        }

        private void ZapisiArgumenteUDatoteku()
        {
            string parametar = StvoriParametar();
            if (!File.Exists(pathArgs))
            {
                using (StreamWriter sw = File.CreateText(pathArgs))
                {
                    sw.Write(parametar);
                }
            }
            else
            {
                File.Delete(pathArgs);
                using (StreamWriter sw = File.CreateText(pathArgs))
                {
                    sw.Write(parametar);
                }
            }
        }
    }
}
