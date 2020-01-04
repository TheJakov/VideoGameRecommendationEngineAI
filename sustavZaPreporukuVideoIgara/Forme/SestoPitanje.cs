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

namespace sustavZaPreporukuVideoIgara.Forme
{
    public partial class SestoPitanje : Form
    {
        private string korisnickiUnos;
        public SestoPitanje()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            NavigationHelper.IdiNaFormu(this, pocetnaForma);
        }

        private void btnSljedece_Click(object sender, EventArgs e)
        {
            if (ProvjeraUnosaSestoPitanje(korisnickiUnos))
            {
                DodjeliVrijednostModelu();
                SedmoPitanje sedmoPitanje = new SedmoPitanje();
                NavigationHelper.IdiNaFormu(this, sedmoPitanje);
            }
            else
                PozoviMB();

        }

        private void textBoxIGNRejting_TextChanged(object sender, EventArgs e)
        {
            korisnickiUnos = textBoxIGNRejting.Text;
            if (korisnickiUnos.Contains("."))
                MessageBox.Show("Koristite zarez kod unosa decimalnog broja," +
                    "umjesto da koristite točku.", "Savjet",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ProvjeraUnosaSestoPitanje(string korUnos)
        {
            if (double.TryParse(korUnos, out double vrijednost))
            {
                double naJednuDecimalu = Math.Round(vrijednost, 1, MidpointRounding.AwayFromZero);
                if(naJednuDecimalu >= 1.0 && naJednuDecimalu <= 10.0)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }
        private void PozoviMB()
        {
            MessageBox.Show("Morate unjeti vrijednost između 1.0 i 10.0 !", "Ooops!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DodjeliVrijednostModelu()
        {
            double rating = double.Parse(korisnickiUnos);
            double ratingOneDecimal = Math.Round(rating, 1, MidpointRounding.AwayFromZero);
            double ratingTo100Base = ratingOneDecimal * 10;
            int ModelRating = Convert.ToInt32(ratingTo100Base);
            EvaluationModel.IGNRating = ModelRating;
        }
    }
}
