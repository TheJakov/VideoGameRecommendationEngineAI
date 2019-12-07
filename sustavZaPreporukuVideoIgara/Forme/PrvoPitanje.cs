using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sustavZaPreporukuVideoIgara.Helpers;
using sustavZaPreporukuVideoIgara.Forme;

namespace sustavZaPreporukuVideoIgara.Forme
{
    /// <summary>
    /// Forma se zove PrvoPitanje i samo na taj način označava da je
    /// to prva u nizu forma na kojoj će se vršiti profiliranje
    /// korisnika sustava.
    /// Tom logikom, svaka sljedeća će biti DrugoPitanje, TrećePitanje
    /// te će se ta noticija koristiti kako bi olakšali navigaciju u svrhu
    /// redosljeda profiliranja korisnika.
    /// </summary>
    public partial class PrvoPitanje : Form
    {
        public PrvoPitanje()
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
            DrugoPitanje drugoPitanje = new DrugoPitanje();
            NavigationHelper.IdiNaFormu(this, drugoPitanje);
        }
    }
}
