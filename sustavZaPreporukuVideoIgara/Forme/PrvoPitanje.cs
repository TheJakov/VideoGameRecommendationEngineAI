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
            if (!IspravnoOdabranoPrvoPitanje())
            {
                MessageBox.Show("Niste odabrali niti jednu opciju.", "Oops!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DodjeliVrijednostModelu();
                DrugoPitanje drugoPitanje = new DrugoPitanje();
                NavigationHelper.IdiNaFormu(this, drugoPitanje);
            }
        }

        private void cbShooter_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaCbPrvoPitanje())
            {
                PozoviMB();
                cbShooter.Checked = false;
            }
        }
        private void cbRpg_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaCbPrvoPitanje())
            {
                PozoviMB();
                cbRpg.Checked = false;
            }
        }
        private void cbMoba_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaCbPrvoPitanje())
            {
                PozoviMB();
                cbMoba.Checked = false;
            }
        }
        private void cbSimulation_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaCbPrvoPitanje())
            {
                PozoviMB();
                cbSimulation.Checked = false;
            }
        }
        private void cbBattleRoyale_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaCbPrvoPitanje())
            {
                PozoviMB();
                cbBattleRoyale.Checked = false;
            }
        }
        private void cbPlatformer_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaCbPrvoPitanje())
            {
                PozoviMB();
                cbPlatformer.Checked = false;
            }
        }
        private void cbHacknSlash_CheckedChanged(object sender, EventArgs e)
        {
            if (!ProvjeraMaxDvaCbPrvoPitanje())
            {
                PozoviMB();
                cbHacknSlash.Checked = false;
            }
        }

        private bool ProvjeraMaxDvaCbPrvoPitanje()
        {
            int brojChecked = 0;
            if (cbShooter.Checked)
                brojChecked++;
            if (cbRpg.Checked)
                brojChecked++;
            if (cbMoba.Checked)
                brojChecked++;
            if (cbSimulation.Checked)
                brojChecked++;
            if (cbBattleRoyale.Checked)
                brojChecked++;
            if (cbPlatformer.Checked)
                brojChecked++;
            if (cbHacknSlash.Checked)
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

        private bool IspravnoOdabranoPrvoPitanje()
        {
            int brojChecked = 0;
            if (cbShooter.Checked)
                brojChecked++;
            if (cbRpg.Checked)
                brojChecked++;
            if (cbMoba.Checked)
                brojChecked++;
            if (cbSimulation.Checked)
                brojChecked++;
            if (cbBattleRoyale.Checked)
                brojChecked++;
            if (cbPlatformer.Checked)
                brojChecked++;
            if (cbHacknSlash.Checked)
                brojChecked++;

            if (brojChecked == 1 || brojChecked == 2)
                return true;
            else
                return false;
        }

        private void DodjeliVrijednostModelu()
        {
            if (cbShooter.Checked)
                EvaluationModel.ListOfTypes.Add("shooter");
            if (cbRpg.Checked)
                EvaluationModel.ListOfTypes.Add("rpg");
            if (cbMoba.Checked)
                EvaluationModel.ListOfTypes.Add("moba");
            if (cbSimulation.Checked)
                EvaluationModel.ListOfTypes.Add("simulation");
            if (cbBattleRoyale.Checked)
                EvaluationModel.ListOfTypes.Add("battle royale");
            if (cbPlatformer.Checked)
                EvaluationModel.ListOfTypes.Add("platformer");
            if (cbHacknSlash.Checked)
                EvaluationModel.ListOfTypes.Add("hack_and_slash");
        }
       
    }
}
