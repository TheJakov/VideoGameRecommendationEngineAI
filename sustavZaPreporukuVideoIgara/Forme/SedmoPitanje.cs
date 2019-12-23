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
    public partial class SedmoPitanje : Form
    {
        public SedmoPitanje()
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
            OsmoPitanje osmoPitanje = new OsmoPitanje();
            NavigationHelper.IdiNaFormu(this, osmoPitanje);
        }

        private void cbDo5_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaSedmoPitanje())
            {
                PozoviMB();
                cbDo5.Checked = false;
            }
        }

        private void cb5_10_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaSedmoPitanje())
            {
                PozoviMB();
                cb5_10.Checked = false;
            }
        }

        private void cb10_20_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaSedmoPitanje())
            {
                PozoviMB();
                cb10_20.Checked = false;
            }
        }

        private void cbPreko20_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaSedmoPitanje())
            {
                PozoviMB();
                cbPreko20.Checked = false;
            }
        }

        private bool ProvjeraJednaOpcijaSedmoPitanje()
        {
            int brojChecked = 0;
            if (cbDo5.Checked)
                brojChecked++;
            if (cb5_10.Checked)
                brojChecked++;
            if (cb10_20.Checked)
                brojChecked++;
            if (cbPreko20.Checked)
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
