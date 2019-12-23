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
    public partial class PetoPitanje : Form
    {
        public PetoPitanje()
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
            SestoPitanje sestoPitanje = new SestoPitanje();
            NavigationHelper.IdiNaFormu(this, sestoPitanje);
        }

        private void cbBesplatna_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaPetoPitanje())
            {
                PozoviMB();
                cbBesplatna.Checked = false;
            }
        }

        private void cb100kn_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaPetoPitanje())
            {
                PozoviMB();
                cb100kn.Checked = false;
            }
        }

        private void cb200kn_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaPetoPitanje())
            {
                PozoviMB();
                cb200kn.Checked = false;
            }
        }

        private void cb350kn_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaPetoPitanje())
            {
                PozoviMB();
                cb350kn.Checked = false;
            }
        }

        private void cbPreko350kn_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaPetoPitanje())
            {
                PozoviMB();
                cbPreko350kn.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaPetoPitanje()
        {
            int brojChecked = 0;
            if (cbBesplatna.Checked)
                brojChecked++;
            if (cb100kn.Checked)
                brojChecked++;
            if (cb200kn.Checked)
                brojChecked++;
            if (cb350kn.Checked)
                brojChecked++;
            if (cbPreko350kn.Checked)
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
    }
}
