using System;
using System.Collections.Generic;
using System.Text;

namespace Prediction
{
    static class EvaluationModel
    {
        public static string Platform;

        public static string ESRB;

        public static bool? Singleplayer;
        public static bool? Multiplayer;
        public static bool? Coop;

        /// <summary>
        /// Price needs to be above or equal this marginal rating.
        /// </summary>
        public static int? Price;

        /// <summary>
        /// Rating needs to be above or equal this marginal rating.
        /// </summary>
        public static int? IGNRating;

        /// <summary>
        /// Rating needs to be between these two marginal ratings.
        /// </summary>
        public static int? CampaignDurationMin;
        public static int? CampaignDurationMax;

        /// <summary>
        /// Vrijednost od 1-3. Svejedno = 1, Važno = 2, Vrlo važno = 3.
        /// </summary>
        public static int? KoefPopular;

        /// <summary>
        /// Vrijednost od 1-3. Svejedno = 1, Važno = 2, Vrlo važno = 3.
        /// </summary>
        public static int? KoefCustomization;

        /// <summary>
        /// Vrijednost od 1-3. Svejedno = 1, Važno = 2, Vrlo važno = 3.
        /// </summary>
        public static int? KoefWorldSize;

        /// <summary>
        /// Vrijednost od 1-3. Svejedno = 1, Važno = 2, Vrlo važno = 3.
        /// </summary>
        public static int? KoefWorldDiversity;

        /// <summary>
        /// Vrijednost od 1-3. Svejedno = 1, Važno = 2, Vrlo važno = 3.
        /// </summary>
        public static int? KoefGraphicsQuality;

        public static string ReleasePeriod;

        public static bool? Modding;

        public static bool? Competitive;

        /// <summary>
        /// Najviše dopušteno dodati dva žanra.
        /// </summary>
        public static List<string> ListOfGenres;

        /// <summary>
        /// Najviše dopušteno dodati dva tipa.
        /// </summary>
        public static List<string> ListOfTypes;

        /// <summary>
        /// Uvijek 1 kako bi se osiguralo da se vrijednost optimizacije samo zbraja i tako
        /// cini minimalnu razliku i prednost kod ostalih igara. Razlog tome je sto je u
        /// jednu ruku nepravedno izrazavati ovu prednost kod igara gdje je samo PC optimiziranost
        /// uzeta u obzir, dok je kod verzija igre na konzolama to obicno solidno optimizirano.
        /// </summary>
        public static int FixedKoefOptimization = 1;
    }
}
