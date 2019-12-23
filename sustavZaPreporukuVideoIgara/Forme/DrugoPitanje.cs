using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sustavZaPreporukuVideoIgara.Forme;
using sustavZaPreporukuVideoIgara.Helpers;

namespace sustavZaPreporukuVideoIgara.Forme
{
    public partial class DrugoPitanje : Form
    {
        public DrugoPitanje()
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
            if (!IspravnoOdabranoDrugoPitanje())
            {
                MessageBox.Show("Niste odabrali niti jednu opciju.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DodjeliVrijednostModelu();
                TrecePitanje trecePitanje = new TrecePitanje();
                NavigationHelper.IdiNaFormu(this, trecePitanje);
            }
        }

        private void cbEveryone_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDrugoPitanje())
            {
                PozoviMB();
                cbEveryone.Checked = false;
            }
        }

        private void cbTeen_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDrugoPitanje())
            {
                PozoviMB();
                cbTeen.Checked = false;
            }
        }

        private void cbMature_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDrugoPitanje())
            {
                PozoviMB();
                cbMature.Checked = false;
            }
        }

        private void cbAdults_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDrugoPitanje())
            {
                PozoviMB();
                cbAdults.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaDrugoPitanje()
        {
            int brojChecked = 0;
            if (cbEveryone.Checked)
                brojChecked++;
            if (cbTeen.Checked)
                brojChecked++;
            if (cbMature.Checked)
                brojChecked++;
            if (cbAdults.Checked)
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

        private bool IspravnoOdabranoDrugoPitanje()
        {
            int brojChecked = 0;
            if (cbEveryone.Checked)
                brojChecked++;
            if (cbTeen.Checked)
                brojChecked++;
            if (cbMature.Checked)
                brojChecked++;
            if (cbAdults.Checked)
                brojChecked++;

            if (brojChecked == 1)
                return true;
            else
                return false;
        }

        private void DodjeliVrijednostModelu()
        {
            if (cbEveryone.Checked)
                EvaluationModel.ESRB = "everyone";
            if (cbTeen.Checked)
                EvaluationModel.ESRB = "teen";
            if (cbMature.Checked)
                EvaluationModel.ESRB = "mature";
            if (cbAdults.Checked)
                EvaluationModel.ESRB = "adults";
        }
    }
}
