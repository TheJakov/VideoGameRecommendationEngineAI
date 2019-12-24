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
    public partial class DvanaestoPitanje : Form
    {
        public DvanaestoPitanje()
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
            if (!IspravnoOdabranoDvanaestoPitanje())
            {
                MessageBox.Show("Niste odabrali niti jednu opciju.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DodjeliVrijednostModelu();
                TrinaestoPitanje trinaestoPitanje = new TrinaestoPitanje();
                NavigationHelper.IdiNaFormu(this, trinaestoPitanje);
            }
        }

        private void cb90_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDvanaestoPitanje())
            {
                PozoviMB();
                cb90.Checked = false;
            }
        }

        private void cb2000_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDvanaestoPitanje())
            {
                PozoviMB();
                cb2000.Checked = false;
            }
        }

        private void cb2010_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDvanaestoPitanje())
            {
                PozoviMB();
                cb2010.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaDvanaestoPitanje()
        {
            int brojChecked = 0;
            if (cb90.Checked)
                brojChecked++;
            if (cb2000.Checked)
                brojChecked++;
            if (cb2010.Checked)
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
        private bool IspravnoOdabranoDvanaestoPitanje()
        {
            int brojChecked = 0;
            if (cb90.Checked)
                brojChecked++;
            if (cb2000.Checked)
                brojChecked++;
            if (cb2010.Checked)
                brojChecked++;

            if (brojChecked == 1)
                return true;
            else
                return false;
        }
        private void DodjeliVrijednostModelu()
        {
            if (cb90.Checked)
                EvaluationModel.ReleasePeriod = "90s";
            if (cb2000.Checked)
                EvaluationModel.ReleasePeriod = "2000s";
            if (cb2010.Checked)
                EvaluationModel.ReleasePeriod = "2010-sad";
        }
    }
}
