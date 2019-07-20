using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace VirgoInventarisTool
{
    class JsonApiHandler
    {
        public JsonApiHandler()
        {

        }

        public void GetToken(string url, Boolean forced)
        {
            long currentTime = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            long expTime = Properties.Settings.Default.expTime;

            if(currentTime >= expTime || forced)
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/authenticate");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"username\":\"Inv_Virgo_admin\"," +
                                  "\"password\":\"!1974Sv-Virgo4817@\"}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    dynamic responseJson = JObject.Parse(result);
                    Console.WriteLine("expTime: " + responseJson.exp);
                    Properties.Settings.Default.Token = responseJson.token;
                    Properties.Settings.Default.expTime = responseJson.exp;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Upgrade();
                }
            }

            
        }

        public List<DrinkItem> getLatestColdDrinks(String url)
        {
            string[] drinks = {"cola" , "cola_zero", "sprite" , "fuze_green", "fuze_sparkling" , "fuze_blacktea" , "fanta", "cassis", "o2_geel", "o2_rood", "o2_groen", "redbull", "fristi", "chocomel", "spa_rood"};
            List<DrinkItem> latestColdDrinks = new List<DrinkItem>();

            var request = (HttpWebRequest)WebRequest.Create(url + "/api/getlatestcolddrinks");
            request.Headers.Add("access-token", Properties.Settings.Default.Token);
            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var responseStream = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var reader = responseStream.ReadToEnd();
                    JArray responseJson = JArray.Parse(reader);
                    for(int i = 0; i < drinks.Length; i++)
                    {
                        String key = drinks[i].ToString();
                        DrinkItem item = new DrinkItem(drinks[i], (int)responseJson[0][key] , (DateTime)responseJson[0]["date"]);
                        latestColdDrinks.Add(item);
                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    Console.WriteLine(errorText);
                    // log errorText
                }
                throw;
            }

            return latestColdDrinks;
        }

        public List<List<DrinkItem>> getAllColdDrinks(String url)
        {
            string[] drinks = { "cola", "cola_zero", "sprite", "fuze_green", "fuze_sparkling", "fuze_blacktea", "fanta", "cassis", "o2_geel", "o2_rood", "o2_groen", "redbull", "fristi", "chocomel", "spa_rood" };
            List<DrinkItem> coldDrinkLine = new List<DrinkItem>();
            List<List<DrinkItem>> allColdDrinks = new List<List<DrinkItem>>();

            var request = (HttpWebRequest)WebRequest.Create(url + "/api/getallcolddrinks");
            request.Headers.Add("access-token", Properties.Settings.Default.Token);
            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var responseStream = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var reader = responseStream.ReadToEnd();
                    JArray responseJson = JArray.Parse(reader);
                    for (int i = 0; i < responseJson.Count; i++)
                    {
                        for(int j = 0; j < drinks.Length; j++)
                        {
                            String key = drinks[j].ToString();
                            DrinkItem item = new DrinkItem(drinks[j], (int)responseJson[i][j], (DateTime)responseJson[i]["date"]);
                            coldDrinkLine.Add(item);
                        }
                        allColdDrinks.Add(coldDrinkLine);
                        coldDrinkLine.Clear();
                        
                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    Console.WriteLine(errorText);
                    // log errorText
                }
                throw;
            }

            return allColdDrinks;
        }

        public List<DrinkItem> getLatestAlcoholDrinks(String url)
        {
            string[] drinks = {"hertog_jan","jupiler","liefmans","leffe_blond","palm","hoegaarde","witte_wijn","rode_wijn","bacardi","bacardi_razz" };
            List<DrinkItem> latestAlcoholDrinks = new List<DrinkItem>();

            var request = (HttpWebRequest)WebRequest.Create(url + "/api/getlatestalcoholdrinks");
            request.Headers.Add("access-token", Properties.Settings.Default.Token);
            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var responseStream = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var reader = responseStream.ReadToEnd();
                    JArray responseJson = JArray.Parse(reader);
                    for (int i = 0; i < drinks.Length; i++)
                    {
                        String key = drinks[i].ToString();
                        DrinkItem item = new DrinkItem(drinks[i], (int)responseJson[0][key], (DateTime)responseJson[0]["date"]);
                        latestAlcoholDrinks.Add(item);
                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    Console.WriteLine(errorText);
                    // log errorText
                }
                throw;
            }

            return latestAlcoholDrinks;
        }

        public List<List<DrinkItem>> getAllAlcoholDrinks(String url)
        {
            string[] drinks = { "hertog_jan", "jupiler", "liefmans", "leffe_blond", "palm", "hoegaarde", "witte_wijn", "rode_wijn", "bacardi", "bacardi_razz" };
            List<DrinkItem> alcoholDrinkLine = new List<DrinkItem>();
            List<List<DrinkItem>> allAlcoholDrinks = new List<List<DrinkItem>>();

            var request = (HttpWebRequest)WebRequest.Create(url + "/api/getallalcoholdrinks");
            request.Headers.Add("access-token", Properties.Settings.Default.Token);
            try
            {
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var responseStream = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var reader = responseStream.ReadToEnd();
                    JArray responseJson = JArray.Parse(reader);
                    for (int i = 0; i < responseJson.Count; i++)
                    {
                        for (int j = 0; j < drinks.Length; j++)
                        {
                            String key = drinks[j].ToString();
                            DrinkItem item = new DrinkItem(drinks[j], (int)responseJson[i][j], (DateTime)responseJson[i]["date"]);
                            alcoholDrinkLine.Add(item);
                        }
                        allAlcoholDrinks.Add(alcoholDrinkLine);
                        alcoholDrinkLine.Clear();

                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    Console.WriteLine(errorText);
                    // log errorText
                }
                throw;
            }

            return allAlcoholDrinks;
        }

        public void insertcoldDrinkItems(String url, List<DrinkItem> drinks)
        {
            JObject jobject = new JObject();

            foreach (DrinkItem i in drinks)
            {
                jobject.Add(i.getName(), i.getAmount());
            }

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/insertcolddrinks/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("access-token", Properties.Settings.Default.Token);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                

                streamWriter.Write(jobject);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        public void insertalcoholDrinkItems(String url, List<DrinkItem> drinks)
        {
            JObject jobject = new JObject();

            foreach (DrinkItem i in drinks)
            {
                jobject.Add(i.getName(), i.getAmount());
            }

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url + "/api/insertalcohol");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("access-token", Properties.Settings.Default.Token);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {


                streamWriter.Write(jobject);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }

    class DrinkItem
    {
        private String name;
        private int amount;
        private DateTime dateTime;

        public DrinkItem(String name, int amount, DateTime dateTime)
        {
            this.name = name;
            this.amount = amount;
            this.dateTime = dateTime;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getAmount()
        {
            return amount;
        }

        public void setAmount(int amount)
        {
            this.amount = amount;
        }

        public DateTime getDate()
        {
            return this.dateTime;
        }

        public void setDate(DateTime date)
        {
            this.dateTime = date;
        }
    }
}
