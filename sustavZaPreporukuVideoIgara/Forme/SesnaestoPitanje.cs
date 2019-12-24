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
    public partial class SesnaestoPitanje : Form
    {
        public SesnaestoPitanje()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Form1 pocetnaForma = new Form1();
            NavigationHelper.IdiNaFormu(this, pocetnaForma);
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if (!IspravnoOdabranoSesnaestoPitanje())
            {
                MessageBox.Show("Niste odabrali niti jednu opciju.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DodjeliVrijednostModelu();
                Rezultat rezultatForma = new Rezultat();
                NavigationHelper.IdiNaFormu(this, rezultatForma);
            }
        }

        private void cbDa_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaSesnaestoPitanje())
            {
                PozoviMB();
                cbDa.Checked = false;
            }
        }

        private void cbNe_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaSesnaestoPitanje())
            {
                PozoviMB();
                cbNe.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaSesnaestoPitanje()
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
        private bool IspravnoOdabranoSesnaestoPitanje()
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
                EvaluationModel.Modding = false;
            if (cbDa.Checked)
                EvaluationModel.Modding = true;
        }
    }
}
