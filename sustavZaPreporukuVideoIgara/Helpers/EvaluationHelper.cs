using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sustavZaPreporukuVideoIgara.Helpers
{
    static class EvaluationHelper
    {
        public static void ResetirajModel()
        {
            EvaluationModel.Platform = null;
            EvaluationModel.ESRB = null;

            EvaluationModel.Singleplayer = null;
            EvaluationModel.Multiplayer = null;
            EvaluationModel.Coop = null;

            EvaluationModel.Price = null;
            EvaluationModel.IGNRating = null;
            EvaluationModel.CampaignDuration = null;

            EvaluationModel.KoefPopular = null;
            EvaluationModel.KoefCustomization = null;
            EvaluationModel.KoefWorldSize = null;
            EvaluationModel.KoefWorldDiversity = null;
            EvaluationModel.KoefGraphicsQuality = null;

            EvaluationModel.ReleasePeriod = null;
            EvaluationModel.Modding = null;
            EvaluationModel.Competitive = null;

            EvaluationModel.ListOfGenres = new List<string>();
            EvaluationModel.ListOfTypes = new List<string>();

            //Pogledaj summary kod implementacije klase za objasnjenje.
            EvaluationModel.FixedKoefOptimization = 1;
        }
    }
}
