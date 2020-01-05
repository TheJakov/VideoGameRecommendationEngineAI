using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sustavZaPreporukuVideoIgara.Helpers
{
    /// <summary>
    /// Klasa koja služi za učitavanje podataka iz CSV u radnu memoriju
    /// </summary>
    public class CSVGameModel
    {
        public string GameName { get; set; }
        public string Platform { get; set; }
        public string ESRB { get; set; }

        /// <summary>
        /// T/F = 50/0
        /// </summary>
        public int Singleplayer { get; set; }

        /// <summary>
        /// T/F = 50/0
        /// </summary>
        public int Multiplayer { get; set; }

        /// <summary>
        /// T/F = 50/0
        /// </summary>
        public int Coop { get; set; }

        //Svaki int koji nije oznacen sa TF uzima vrijednost 1-100
        public int Price { get; set; }
        public int IGNRating { get; set; }
        public int CampaignDuration { get; set; }

        /// <summary>
        /// T/F = 50/0
        /// </summary>
        public int IsPopular { get; set; }

        public int CharCustomization { get; set; }
        public int WorldSize { get; set; }
        public int WorldDiversity { get; set; }
        public int Graphics { get; set; }
        public string Period { get; set; }

        /// <summary>
        /// T/F = 50/0
        /// </summary>
        public int Modding { get; set; }

        /// <summary>
        /// T/F = 50/0
        /// </summary>
        public int Competitive { get; set; }

        public string Genre { get; set; }
        public string Type { get; set; }
        public int Optimization { get; set; }

        /// <summary>
        /// Score is calculated in EvaluationHelper
        /// </summary>
        public int Score { get; set; }
    }
}
