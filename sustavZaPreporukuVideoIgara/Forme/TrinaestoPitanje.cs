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
    public partial class TrinaestoPitanje : Form
    {
        public TrinaestoPitanje()
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
            if (!IspravnoOdabranoTrinaestoPitanje())
            {
                MessageBox.Show("Niste odabrali niti jednu opciju.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DodjeliVrijednostModelu();
                CetrnaestoPitanje cetrnaestoPitanje = new CetrnaestoPitanje();
                NavigationHelper.IdiNaFormu(this, cetrnaestoPitanje);
            }
        }

        private void cbDa_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaTrinaestoPitanje())
            {
                PozoviMB();
                cbDa.Checked = false;
            }
        }

        private void cbNe_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaTrinaestoPitanje())
            {
                PozoviMB();
                cbNe.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaTrinaestoPitanje()
        {
            int brojChecked = 0;
            if (cbNe.Checked)
                brojChecked++;
            if (cbDa.Checked)
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

        private bool IspravnoOdabranoTrinaestoPitanje()
        {
            int brojChecked = 0;
            if (cbNe.Checked)
                brojChecked++;
            if (cbDa.Checked)
                brojChecked++;

            if (brojChecked == 1)
                return true;
            else
                return false;
        }
        private void DodjeliVrijednostModelu()
        {
            if (cbNe.Checked)
                EvaluationModel.Competitive = false;
            if (cbDa.Checked)
                EvaluationModel.Competitive = true;
        }
    }
}
