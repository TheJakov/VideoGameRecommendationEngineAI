using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using SustavZaPreporukuVideoIgaraML.Model;

namespace Prediction
{
    class Program
    {
        /**
         * Sa testnim podacima s1 samostalno radi
         * isti ti podaci putem forme ne rade
         * */
        private static string path = @"..\..\..\..\MyTest.txt";
        private static List<ModelInput> sveKombinacijeModelInputa = new List<ModelInput>();
        static void Main(string[] args)
        {
            //string s1="XBOX mature True False 60 80 76 100 3 3 3 3 3 2010-sad False False -l1 rpg -l2 apocalyptic";
            //args = s1.Split(' ');
            //string s1 = "PS everyone True True 1 80 51 75 2 2 1 1 1 2010-sad True True -l1 rpg -l2 crime adventure";
            //args = s1.Split(' ');
            
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            //Console.ReadLine();
            


            SrediArgumente(args);
            PuniMlModelPodacimaKorisnika();
            ZapisiUDatoteku();
            //Console.ReadLine();
            Environment.Exit(0);
        }

        private static void SrediArgumente(string[] args)
        {
            EvaluationModel.Platform = args[0];
            EvaluationModel.ESRB = args[1];
            EvaluationModel.Singleplayer = bool.Parse(args[2]);
            EvaluationModel.Multiplayer = bool.Parse(args[3]);
            EvaluationModel.Price = int.Parse(args[4]);
            EvaluationModel.IGNRating = int.Parse(args[5]);
            EvaluationModel.CampaignDurationMin = int.Parse(args[6]);
            EvaluationModel.CampaignDurationMax = int.Parse(args[7]);
            EvaluationModel.KoefPopular = int.Parse(args[8]);
            EvaluationModel.KoefCustomization = int.Parse(args[9]);
            EvaluationModel.KoefWorldSize = int.Parse(args[10]);
            EvaluationModel.KoefWorldDiversity = int.Parse(args[11]);
            EvaluationModel.KoefGraphicsQuality = int.Parse(args[12]);
            EvaluationModel.ReleasePeriod = args[13];
            EvaluationModel.Modding = bool.Parse(args[14]);
            EvaluationModel.Competitive = bool.Parse(args[15]);

            int brojac = 0;
            List<string> l1 = new List<string>();
            if (args[16].Equals("-l1"))
            {
                for (int i = 17; i < args.Length; i++)
                {
                    if (args[i].Equals("-l2"))
                    {
                        brojac = i;
                        break;
                    }

                    l1.Add(args[i]);
                }
            }


            List<string> l2 = new List<string>();
            if (args[brojac].Equals("-l2"))
            {
                for (int i = brojac + 1; i < args.Length; i++)
                {
                    l2.Add(args[i]);
                }
            }

            EvaluationModel.ListOfTypes = l1;
            EvaluationModel.ListOfGenres = l2;
        }

        private static void PuniMlModelPodacimaKorisnika()
        {
            ModelInput modelInput = new ModelInput();
            modelInput.Platform = EvaluationModel.Platform;
            modelInput.Esrb = EvaluationModel.ESRB;

            if ((bool)EvaluationModel.Singleplayer)
                modelInput.Singleplayer = 50;
            else
                modelInput.Singleplayer = 0;

            if ((bool)EvaluationModel.Multiplayer)
                modelInput.Multyplayer = 50;
            else
                modelInput.Multyplayer = 0;

            modelInput.Price = (float)EvaluationModel.Price;
            modelInput.Ign_rating = (float)EvaluationModel.IGNRating;
            if (EvaluationModel.CampaignDurationMin == 1 && EvaluationModel.CampaignDurationMax == 25)
                modelInput.Campaign_duration = 25;
            else if (EvaluationModel.CampaignDurationMin == 26 && EvaluationModel.CampaignDurationMax == 50)
                modelInput.Campaign_duration = 50;
            else if (EvaluationModel.CampaignDurationMin == 51 && EvaluationModel.CampaignDurationMax == 75)
                modelInput.Campaign_duration = 75;
            else if (EvaluationModel.CampaignDurationMin == 76 && EvaluationModel.CampaignDurationMax == 100)
                modelInput.Campaign_duration = 100;

            if (EvaluationModel.KoefPopular == 1)
                modelInput.Is_popular = 0;
            else if (EvaluationModel.KoefPopular == 2)
                modelInput.Is_popular = 25;
            else if (EvaluationModel.KoefPopular == 3)
                modelInput.Is_popular = 50;

            if (EvaluationModel.KoefCustomization == 1)
                modelInput.Char_customization = 33.33f;
            else if (EvaluationModel.KoefCustomization == 2)
                modelInput.Char_customization = 66.66f;
            else if (EvaluationModel.KoefCustomization == 3)
                modelInput.Char_customization = 100;

            if (EvaluationModel.KoefWorldSize == 1)
                modelInput.World_size = 33.33f;
            else if (EvaluationModel.KoefWorldSize == 2)
                modelInput.World_size = 66.66f;
            else if (EvaluationModel.KoefWorldSize == 3)
                modelInput.World_size = 100;

            if (EvaluationModel.KoefWorldDiversity == 1)
                modelInput.World_diversity = 33.33f;
            else if (EvaluationModel.KoefWorldDiversity == 2)
                modelInput.World_diversity = 66.66f;
            else if (EvaluationModel.KoefWorldDiversity == 3)
                modelInput.World_diversity = 100;

            if (EvaluationModel.KoefGraphicsQuality == 1)
                modelInput.Graphics = 33.33f;
            else if (EvaluationModel.KoefGraphicsQuality == 2)
                modelInput.Graphics = 66.66f;
            else if (EvaluationModel.KoefGraphicsQuality == 3)
                modelInput.Graphics = 100;

            modelInput.Period = EvaluationModel.ReleasePeriod;

            if ((bool)EvaluationModel.Modding)
                modelInput.Modding = 50;
            else
                modelInput.Modding = 0;

            if ((bool)EvaluationModel.Competitive)
                modelInput.Competitive = 50;
            else
                modelInput.Competitive = 0;


            modelInput.Optimization = 50;

            KombiacijeKorisničkihPodataka(modelInput);
        }

        private static void KombiacijeKorisničkihPodataka(ModelInput modelInput)
        {

            if (EvaluationModel.ListOfGenres.Count > EvaluationModel.ListOfTypes.Count)
            {
                foreach (string genre in EvaluationModel.ListOfGenres)
                {
                    ModelInput model = Clone(modelInput);
                    model.Genre = genre;
                    foreach (string type in EvaluationModel.ListOfTypes)
                    {
                        model.Type = type;
                    }
                    sveKombinacijeModelInputa.Add(model);
                }
            }
            else if (EvaluationModel.ListOfGenres.Count < EvaluationModel.ListOfTypes.Count)
            {
                foreach (string type in EvaluationModel.ListOfTypes)
                {
                    ModelInput model = Clone(modelInput);
                    model.Type = type;
                    foreach (string genre in EvaluationModel.ListOfGenres)
                    {
                        model.Genre = genre;
                    }
                    sveKombinacijeModelInputa.Add(model);
                }
            }
            else if (EvaluationModel.ListOfGenres.Count == 1 && EvaluationModel.ListOfTypes.Count == 1)
            {
                string type = EvaluationModel.ListOfTypes[0];
                string genre = EvaluationModel.ListOfGenres[0];
                ModelInput model = Clone(modelInput);
                model.Type = type;
                model.Genre = genre;
                sveKombinacijeModelInputa.Add(model);
            }
            else if (EvaluationModel.ListOfGenres.Count == 2 && EvaluationModel.ListOfTypes.Count == 2)
            {
                string type1 = EvaluationModel.ListOfTypes[0];
                string genre1 = EvaluationModel.ListOfGenres[0];
                string type2 = EvaluationModel.ListOfTypes[1];
                string genre2 = EvaluationModel.ListOfGenres[1];
                ModelInput model = Clone(modelInput);
                model.Type = type1;
                model.Genre = genre1;
                ModelInput model1 = Clone(modelInput);
                model1.Type = type1;
                model1.Genre = genre2;
                ModelInput model2 = Clone(modelInput);
                model2.Type = type2;
                model2.Genre = genre1;
                ModelInput model3 = Clone(modelInput);
                model3.Type = type2;
                model3.Genre = genre2;
                sveKombinacijeModelInputa.Add(model);
                sveKombinacijeModelInputa.Add(model1);
                sveKombinacijeModelInputa.Add(model2);
                sveKombinacijeModelInputa.Add(model3);
            }
        }

        private static ModelInput Clone(ModelInput modelInput)
        {
            ModelInput model = new ModelInput();

            model.Platform = modelInput.Platform;
            model.Esrb = modelInput.Esrb;
            model.Singleplayer = modelInput.Singleplayer;
            model.Multyplayer = modelInput.Multyplayer;
            model.Price = modelInput.Price;
            model.Ign_rating = modelInput.Ign_rating;
            model.Campaign_duration = modelInput.Campaign_duration;
            model.Is_popular = modelInput.Is_popular;
            model.Char_customization = modelInput.Char_customization;
            model.World_size = modelInput.World_size;
            model.World_diversity = modelInput.World_diversity;
            model.Graphics = modelInput.Graphics;
            model.Period = modelInput.Period;
            model.Modding = modelInput.Modding;
            model.Competitive = modelInput.Competitive;
            model.Optimization = modelInput.Optimization;

            return model;
        }

        private static string SrediZapisZaTXT()
        {
            Console.WriteLine("test 1");
            /**
             * Ovdje sad zapinje program kad se pokrece iz forme aplikacije, prekida s radom i izade (bez error-a).
             * Kad se samostalno debagira, ispravno radi, tj. vrši predikciju
             * Niti try catch ne pomaže
             * Thread Sleep sam probao ako nešto pre brzo ide da usporim, ali ni to ne pomaže
             **/
            List<ModelOutput> modelOutputs = new List<ModelOutput>();
            foreach (ModelInput input in sveKombinacijeModelInputa)
            {
                Console.WriteLine("unutra sam");
                ModelOutput output;
                try
                {
                    output = ConsumeModel.Predict(input);
                    Thread.Sleep(1000);
                    modelOutputs.Add(output);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("gotov");
            }

            Console.WriteLine("test 2");
            //Console.ReadLine();

            string zapis = "";
            foreach (ModelOutput output in modelOutputs)
            {
                Array.Sort(output.Score);
                zapis += output.Prediction + " : " + output.Score[output.Score.Length - 1] + "\n";
            }

            Console.WriteLine("test 3");
            return zapis;
        }

        private static void ZapisiUDatoteku()
        {
            Console.WriteLine("test ");
            string s = SrediZapisZaTXT();
            Console.WriteLine("test dobro");
            if (!File.Exists(path))
            {    
                /*
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(s);
                }
                */
                File.WriteAllText(path, s);
            }
            else
            {
                File.Delete(path);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}
