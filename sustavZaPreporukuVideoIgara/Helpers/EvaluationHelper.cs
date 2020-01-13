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
            EvaluationModel.CampaignDurationMin = null;
            EvaluationModel.CampaignDurationMax = null;

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

        public static void EvalutateList(List<CSVGameModel> listaIgara)
        {
            foreach (var igra in listaIgara)
            {
                igra.Score = 0;
                if (EvaluationModel.Platform != igra.Platform) { }
                else
                {
                    if (EvaluationModel.Multiplayer == true && igra.Multiplayer == 0) { }
                    else
                    {
                        if(EvaluationModel.Singleplayer==true && igra.Singleplayer == 0) { }
                        else
                        {
                            if (EvaluationModel.Coop == true && igra.Coop == 0) { }
                            else
                            {
                                if (!EvaluationModel.ListOfTypes.Contains(igra.Type)) { }
                                else
                                {
                                    if (!EvaluationModel.ListOfGenres.Contains(igra.Genre)) { }
                                    else
                                    {
                                        if (EvaluationModel.Price > igra.Price) { }
                                        else
                                        {
                                            if (EvaluationModel.IGNRating > igra.IGNRating) { }
                                            else
                                            {
                                                if(igra.CampaignDuration >= EvaluationModel.CampaignDurationMin && igra.CampaignDuration <= EvaluationModel.CampaignDurationMax)
                                                {
                                                    igra.CampaignDuration = igra.CampaignDuration * 2;
                                                }
                                                if(igra.Period == EvaluationModel.ReleasePeriod)
                                                {
                                                    igra.Score += 50;  //tražen period
                                                }
                                                if(EvaluationModel.ESRB == igra.ESRB)
                                                {
                                                    igra.Score += 100;  //tražen ESRB
                                                }
                                                if (igra.Competitive == 50 && EvaluationModel.Competitive == true)
                                                {
                                                    igra.Competitive = igra.Competitive * 2;
                                                }
                                                if(igra.Modding == 50 && EvaluationModel.Modding == true)
                                                {
                                                    igra.Modding = igra.Modding * 2;
                                                }
                                                igra.CharCustomization = igra.CharCustomization * (int)EvaluationModel.KoefCustomization;
                                                igra.WorldDiversity = igra.WorldDiversity * (int)EvaluationModel.KoefWorldDiversity;
                                                igra.Graphics = igra.Graphics * (int)EvaluationModel.KoefGraphicsQuality;
                                                igra.WorldDiversity = igra.WorldSize * (int)EvaluationModel.KoefWorldSize;
                                                igra.IsPopular = igra.IsPopular * (int)EvaluationModel.KoefPopular;

                                                igra.Score += igra.Singleplayer + igra.Multiplayer + igra.Coop + igra.Price +
                                                                igra.IGNRating + igra.CampaignDuration + igra.IsPopular +
                                                                igra.CharCustomization + igra.WorldSize + igra.WorldDiversity +
                                                                igra.Graphics + igra.Modding + igra.Competitive + igra.Optimization;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
