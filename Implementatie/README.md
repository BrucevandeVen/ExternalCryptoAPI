# Implementatie van de Crypto API
# Hoe implementeer ik een Crypto API?

## introductie
Ik ga hier uitleggen hoe ik mijn uiteindelijk gevonden Crypto API verbind met mijn API d.m.v. code snippets en hoe ik met de crypto data om ga. 
Er wordt gebruik gemaakt van [Dependency Injection](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0) en 
[Entity Framework](https://docs.microsoft.com/en-us/aspnet/entity-framework).

## Coinmarketcap
Coinmarketcap is een van de populairste crypto websites van de wereld, de API is daarom ook heel uitgebreid en goed gedocumenteerd ([Coinmarketcap Documentatie](https://coinmarketcap.com/api/documentation/v1)).  
Als je eenmaal een account hebt aangemaakt krijg je automatisch een API key met maximaal 10.000 API calls per maand, als je meer wilt moet je per maand betalen (dit kan oplopen tot 300 dollar per maand).  
Coinmarketcap raad aan je eigen back-end te gebruiken, omdat ze een CORS beveiliging hebben i.v.m. de API key bescherming.  

Welke endpoints ga ik gebruiken?
- Listings Latest (Om de huidige crypto top 10 op te halen)
- Metadata (Om de afbeelding bij de crypto op te halen) (optioneel)

### Listings Latest
Deze endpoint geeft over alle actieve crypto munten markt data terug, deze is als standaard gesorteerd op market cap van hoog naar laag.  
Overzicht van Coinmarketcap:  
```
You may sort against any of the following:
market_cap: CoinMarketCap's market cap rank as outlined in our methodology.
market_cap_strict: A strict market cap sort (latest trade price x circulating supply).
name: The cryptocurrency name.
symbol: The cryptocurrency symbol.
date_added: Date cryptocurrency was added to the system.
price: latest average trade price across markets.
circulating_supply: approximate number of coins currently in circulation.
total_supply: approximate total amount of coins in existence right now (minus any coins that have been verifiably burned).
max_supply: our best approximation of the maximum amount of coins that will ever exist in the lifetime of the currency.
num_market_pairs: number of market pairs across all exchanges trading each currency.
market_cap_by_total_supply_strict: market cap by total supply.
volume_24h: rolling 24 hour adjusted trading volume.
volume_7d: rolling 24 hour adjusted trading volume.
volume_30d: rolling 24 hour adjusted trading volume.
percent_change_1h: 1 hour trading price percentage change for each currency.
percent_change_24h: 24 hour trading price percentage change for each currency.
percent_change_7d: 7 day trading price percentage change for each currency.
```
Zelf ben ik geïntereseerd in ("voorbeeld data"):  
- name "Bitcoin"
- price "64000"
- percent_change_1h "-0,154139"
- percent change_24h "0,542384"
- percent_change_7d "0,910932"
- symbol "BTC" (optioneel)

De data update elke minuut, dus is heel up-to-date. Per 200 crypto's die in een list worden teruggegeven ben ik 1 API call kwijt, daarbij geeft deze API call duizenden crypto's terug. Om te limiteren ga ik de limit query parameter gebruiken, ik ga deze op 10 zetten.

een voorbeeld van deze request:  
```
{
"data": [
{
"id": 1,
"name": "Bitcoin",
"symbol": "BTC",
"slug": "bitcoin",
"cmc_rank": 5,
"num_market_pairs": 500,
"circulating_supply": 16950100,
"total_supply": 16950100,
"max_supply": 21000000,
"last_updated": "2018-06-02T22:51:28.209Z",
"date_added": "2013-04-28T00:00:00.000Z",
"tags": [
"mineable"
],
"platform": null,
"quote": {
"USD": {
"price": 9283.92,
"volume_24h": 7155680000,
"percent_change_1h": -0.152774,
"percent_change_24h": 0.518894,
"percent_change_7d": 0.986573,
"market_cap": 158055024432,
"last_updated": "2018-08-09T22:53:32.000Z"
},
"BTC": {
"price": 1,
"volume_24h": 772012,
"percent_change_1h": 0,
"percent_change_24h": 0,
"percent_change_7d": 0,
"market_cap": 17024600,
"last_updated": "2018-08-09T22:53:32.000Z"
}
}
}
],
"status": {
"timestamp": "2018-06-02T22:51:28.209Z",
"error_code": 0,
"error_message": "",
"elapsed": 10,
"credit_count": 1
}
}
```

### API Call
Bij de documentatie van Coinmarketcap staat in een aantal formats, talen en frameworks uitgelegd, d.m.v. voorbeeld code snippets, hoe het mogelijk is om een API call te maken naar deze endpoint.

Hoe ik mijn API call heb gemaakt:
```
        private List<Crypto> MakeAPICall()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "10";
            queryString["convert"] = "EUR";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string json = client.DownloadString(URL.ToString());

            dynamic dataSet = JsonConvert.DeserializeObject(json);

            List<Crypto> cryptos = new List<Crypto>();

            foreach (var coin in dataSet.data)
            {
                Crypto crypto = new Crypto();
                crypto.Name = coin.name;
                crypto.Price = coin.quote.EUR.price;
                cryptos.Add(crypto);
            }

            return cryptos;
        }
```
