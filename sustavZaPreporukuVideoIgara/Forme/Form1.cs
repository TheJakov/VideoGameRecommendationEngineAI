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

namespace sustavZaPreporukuVideoIgara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpreman_Click(object sender, EventArgs e)
        {
            EvaluationHelper.ResetirajModel();
            PrvoPitanje prvoPitanje = new PrvoPitanje();
            NavigationHelper.IdiNaFormu(this, prvoPitanje);
        }
    }
}
