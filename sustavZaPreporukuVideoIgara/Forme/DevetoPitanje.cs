﻿using sustavZaPreporukuVideoIgara.Helpers;
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
    public partial class DevetoPitanje : Form
    {
        public DevetoPitanje()
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
            DesetoPitanje desetoPitanje = new DesetoPitanje();
            NavigationHelper.IdiNaFormu(this, desetoPitanje);
        }

        private void cbSvejedno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDevetoPitanje())
            {
                PozoviMB();
                cbSvejedno.Checked = false;
            }
        }

        private void cbVazno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDevetoPitanje())
            {
                PozoviMB();
                cbVazno.Checked = false;
            }
        }

        private void cbJakoVazno_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraJednaOpcijaDevetoPitanje())
            {
                PozoviMB();
                cbJakoVazno.Checked = false;
            }
        }
        private bool ProvjeraJednaOpcijaDevetoPitanje()
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
    }
}
