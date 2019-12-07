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

        private void btnPrethodno_Click(object sender, EventArgs e)
        {
            PrvoPitanje prvoPitanje = new PrvoPitanje();
            NavigationHelper.IdiNaFormu(this, prvoPitanje);
        }

        private void btnSljedece_Click(object sender, EventArgs e)
        {

        }
    }
}
