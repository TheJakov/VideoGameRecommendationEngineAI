using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sustavZaPreporukuVideoIgara.Helpers
{
    public static class NavigationHelper
    {
        public static void IdiNaFormu(Form trenutna, Form sljedeca)
        {
            trenutna.Hide();
            sljedeca.ShowDialog();
            trenutna.Close();
        }
    }
}
