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
    public partial class CetvrtoPitanje : Form
    {
        public CetvrtoPitanje()
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
            PetoPitanje petoPitanje = new PetoPitanje();
            NavigationHelper.IdiNaFormu(this, petoPitanje);
        }

        private void cbSp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbMp_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbCoop_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
