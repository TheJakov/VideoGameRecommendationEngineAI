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
    public partial class DesetoPitanje : Form
    {
        public DesetoPitanje()
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
            if (!IspravnoOdabranoDesetoPitanje())
            {
                MessageBox.Show("Niste odabrali niti jednu opciju.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DodjeliVrijednostModelu();
                JedanaestoPitanje jedanaestoPitanje = new JedanaestoPitanje();
                NavigationHelper.IdiNaFormu(this, jedanaestoPitanje);
            }
        }

        private void cbSvejedno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDesetoPitanje())
            {
                PozoviMB();
                cbSvejedno.Checked = false;
            }
        }

        private void cbVazno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDesetoPitanje())
            {
                PozoviMB();
                cbVazno.Checked = false;
            }
        }

        private void cbJakoVazno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDesetoPitanje())
            {
                PozoviMB();
                cbJakoVazno.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaDesetoPitanje()
        {
            int brojChecked = 0;
            if (cbSvejedno.Checked)
                brojChecked++;
            if (cbVazno.Checked)
                brojChecked++;
            if (cbJakoVazno.Checked)
                brojChecked++;

            if (brojChecked <= 1)
                return true;
            else
                return false;
        }
        private void PozoviMB()
        {
            MessageBox.Show("Možete označiti samo jednu opciju!", "Ooops!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IspravnoOdabranoDesetoPitanje()
        {
            int brojChecked = 0;
            if (cbSvejedno.Checked)
                brojChecked++;
            if (cbVazno.Checked)
                brojChecked++;
            if (cbJakoVazno.Checked)
                brojChecked++;

            if (brojChecked == 1)
                return true;
            else
                return false;
        }
        private void DodjeliVrijednostModelu()
        {
            if (cbSvejedno.Checked)
                EvaluationModel.KoefWorldDiversity = 1;
            if (cbVazno.Checked)
                EvaluationModel.KoefWorldDiversity= 2;
            if (cbJakoVazno.Checked)
                EvaluationModel.KoefWorldDiversity = 3;
        }
    }
}
