using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;

namespace CoinAPITest
{
    class Program
    {
        private static string API_KEY = "b54bcf4d-1bca-4e8e-9a24-22ff2c3d462c";

        static void Main(string[] args)
        {
            try
            {
                foreach(Crypto crypto in makeAPICall())
                {
                    Console.WriteLine(crypto);
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static List<Crypto> makeAPICall()
        {
            var URL = new UriBuilder("https://sandbox-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "10";
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string json = client.DownloadString(URL.ToString());

            dynamic dataSet = JsonConvert.DeserializeObject(json);

            List<Crypto> cryptos = new List<Crypto>();

            foreach(var row in dataSet.data)
            {
                Crypto crypto = new Crypto();
                crypto.id = row.id;
                crypto.name = row.name;
                crypto.price = row.quote.USD.price;
                cryptos.Add(crypto);
            }

            return cryptos;
        }

        public void CoinDeskAPI()
        {
            while (true)
            {
                string json;

                using (var web = new System.Net.WebClient())
                {
                    var url = @"https://api.coindesk.com/v1/bpi/currentprice.json";
                    json = web.DownloadString(url);
                }

                dynamic obj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                var time = Convert.ToString(obj.time.updated);
                var currentPrice = Convert.ToDecimal(obj.bpi.EUR.rate);

                Console.WriteLine(time + " " + currentPrice);

                Thread.Sleep(60000);
            }
        }
    }
}
