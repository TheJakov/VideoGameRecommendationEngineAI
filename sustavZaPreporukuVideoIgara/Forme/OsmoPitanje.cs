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
    public partial class OsmoPitanje : Form
    {
        public OsmoPitanje()
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
            DevetoPitanje devetoPitanje = new DevetoPitanje();
            NavigationHelper.IdiNaFormu(this, devetoPitanje);
        }

        private void cbHorror_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbHorror.Checked = false;
            }
        }

        private void cbWar_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbWar.Checked = false;
            }
        }

        private void cbCrime_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbCrime.Checked = false;
            }
        }

        private void cbApocalyptic_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbApocalyptic.Checked = false;
            }
        }

        private void cbSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbSpace.Checked = false;
            }
        }

        private void cbAdventure_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbAdventure.Checked = false;
            }
        }

        private void cbSport_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbSport.Checked = false;
            }
        }

        private void cbDriving_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaOsmoPitanje())
            {
                PozoviMB();
                cbDriving.Checked = false;
            }
        }
        private bool ProvjeraMaxDvaOsmoPitanje()
        {
            int brojChecked = 0;
            if (cbHorror.Checked)
                brojChecked++;
            if (cbWar.Checked)
                brojChecked++;
            if (cbCrime.Checked)
                brojChecked++;
            if (cbApocalyptic.Checked)
                brojChecked++;
            if (cbSpace.Checked)
                brojChecked++;
            if (cbAdventure.Checked)
                brojChecked++;
            if (cbSport.Checked)
                brojChecked++;
            if (cbDriving.Checked)
                brojChecked++;

            if (brojChecked <= 2)
                return true;
            else
                return false;
        }

        private void PozoviMB()
        {
            MessageBox.Show("Možete označiti najviše dvije opcije!", "Ooops!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
