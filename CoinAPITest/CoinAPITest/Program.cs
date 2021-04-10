using System;
using System.Threading;

namespace CoinAPITest
{
    class Program
    {
        static void Main(string[] args)
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
