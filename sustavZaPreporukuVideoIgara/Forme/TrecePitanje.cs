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
    public partial class TrecePitanje : Form
    {
        public TrecePitanje()
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
            if (!IspravnoOdabranoTrecePitanje())
            {
                MessageBox.Show("Niste odabrali niti jednu opciju.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DodjeliVrijednostModelu();
                CetvrtoPitanje cetvrtoPitanje = new CetvrtoPitanje();
                NavigationHelper.IdiNaFormu(this, cetvrtoPitanje);
            }
        }

        private void cbPc_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaTrecePitanje())
            {
                PozoviMB();
                cbPc.Checked = false;
            }
        }

        private void cbPlaystation_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaTrecePitanje())
            {
                PozoviMB();
                cbPlaystation.Checked = false;
            }
        }

        private void cbXbox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaTrecePitanje())
            {
                PozoviMB();
                cbXbox.Checked = false;
            }
        }

        private void cbNintendo_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaTrecePitanje())
            {
                PozoviMB();
                cbNintendo.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaTrecePitanje()
        {
            int brojChecked = 0;
            if (cbPc.Checked)
                brojChecked++;
            if (cbPlaystation.Checked)
                brojChecked++;
            if (cbXbox.Checked)
                brojChecked++;
            if (cbNintendo.Checked)
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

        private bool IspravnoOdabranoTrecePitanje()
        {
            int brojChecked = 0;
            if (cbPc.Checked)
                brojChecked++;
            if (cbPlaystation.Checked)
                brojChecked++;
            if (cbXbox.Checked)
                brojChecked++;
            if (cbNintendo.Checked)
                brojChecked++;

            if (brojChecked <= 1)
                return true;
            else
                return false;
        }

        private void DodjeliVrijednostModelu()
        {
            if (cbPc.Checked)
                EvaluationModel.Platform = "PC";
            if (cbPlaystation.Checked)
                EvaluationModel.Platform = "PS";
            if (cbXbox.Checked)
                EvaluationModel.Platform = "XBOX";
            if (cbNintendo.Checked)
                EvaluationModel.Platform = "Nintendo";
        }
    }
}
