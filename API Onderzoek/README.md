# API Onderzoek
# Welke API is het meest geschikt voor mijn project?

## Introductie
In dit onderzoek ga ik uitzoeken welke API's er geschikt zijn voor mijn project. Ik ga mijn criterea op een rij zetten en alle API's testen met mijn test applicatie.

## Criterea
Om een goede API uit te kiezen die past bij mijn project, ga ik de verschillende API's beoordelen op een aantal criterea:  
- Kosten
- Aantal calls
- Bruikbare periode
- Data

### Kosten
Het is belangrijk dat de API gratis is, omdat ik het zelf het niet waard vind om er geld in te investeren, en ik verwacht dit ook niet van Fontys.

### Aantal calls
Mijn applicatie heeft als doel de huidige crypto waarden tonen van een aantal crypto currencies. Ik hoef niet elke seconde te updaten (al streef ik hier wel naar), want dat gaat niet veel voorkomen bij gratis API's. Mijn minimale aantal calls ligt rond de 50 per dag, omdat ik dan genoeg ruimte heb om de werking aan te tonen en er mee te stoeien.

### Bruikbare periode
De API moet minimaal mee gaan tot het einde van dit semester, dat is nu ongeveer 3 maanden.

### Data
Hoeveel currencies geeft de API door? Ik wil minimaal een top 10 van de huidige crypto currencies (op basis van market cap) opvragen. Ik ben tevreden met zoveel mogelijk data, maar dit is zeker geen prioriteit, ik ga akkoord met alle soorten hoeveelheden data, omdat de andere criterea veel zwaarder wegen om dit project mogelijk te maken. Het minimale is wel dat de huidige prijs beschikbaar moet zijn.

## Library (Wat is al bekend?)
Ik ga onderzoeken wat er al op internet beschikbaar omtrent Crypto API vergelijkingen, en neem deze mee in het onderzoek.

De eerste vergelijking die ik tegen ben gekomen is een [top 5 van Nicholas Resendez](https://towardsdatascience.com/top-5-best-cryptocurrency-apis-for-developers-32475d2eb749). Hij heeft op moment van schrijven een goede vergelijking van de (in juni 2020) grootste/beste Crypto data API's.  
LunarCRUSH is de eerste API die behandeld wordt, dit is een goede kandidaat voor mijn project. De API's Messari, Nomics en CoinGecko vielen automatisch af, omdat bij deze API's geen top 10 crypto werd gebruikt (dus ID: 1 voor de hoogste marketcap en ID: 2 voor de volgende etc.), bij deze API's wordt alleen de naam van de crypto gebruikt (ID: BTC, ID: ETH etc.), dit is dus niet handig als ik een automatische top 10 wil laten zien. Er blijft nu nog 1 crypto API over en dat is Coinmarketcap, ik ben al bekend met deze API en is ook zeker een goede kandidaat voor mijn project.

## Onderzochtten API's
### Table Of Contents
- [Coinmarketcap](https://github.com/BrucevandeVen/ExternalCryptoAPI/tree/main/API%20Onderzoek#coinmarketcap)
- [LunarCRUSH](https://github.com/BrucevandeVen/ExternalCryptoAPI/tree/main/API%20Onderzoek#lunarcrush)
- [CoinDesk]()

### [Coinmarketcap](https://coinmarketcap.com/)
Als eerste heb ik [coinmarketcap](https://coinmarketcap.com/api/) bezocht, omdat ik deze website al veel voorbij heb zien komen in mijn kennissenkringen en zelf ook wel eens gebruikt heb om de huidige crypto waardes te volgen. De data is op een aantal seconden na accuraat. De Coinmarketcap documentatie zit achter een login scherm.  

**Criterea:**
- Kosten: 0  
![image](https://user-images.githubusercontent.com/58031089/114744643-32c95f80-9d4e-11eb-9937-ab06a5fe2bd8.png)  
- Aantal calls: Maximaal 30 per minuut, 333 per dag, 10.000 per maand
- Bruikbare periode: Onbeperkt
- Data: https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest   
![image](https://user-images.githubusercontent.com/58031089/114706687-8ecdbd00-9d29-11eb-8884-f99dc7e5180c.png)

**Conclusie:**    
Coinmarketcap is zeer geschikt om te gebruiken voor mijn project, het voldoet aan mijn criterea.  

### [LunarCRUSH](https://lunarcrush.com/dashboard)
LunarCRUSH is een van de bekendere crypto monitor applicaties, naast Cryptomarketcap en Binance. De data update elk uur. De [LunarCRUSH documentatie](https://lunarcrush.com/developers/docs#).  

**Criterea:**
- Kosten: 45 euro per maand  
![image](https://user-images.githubusercontent.com/58031089/114724693-1f14fd80-9d3c-11eb-9c0a-8634d31e4de2.png)  
- Aantal calls: Onbeperkt
- Bruikbare periode: Onbeperkt
- Data: https://api.lunarcrush.com/v2?data=meta&key=8piwl04kwy9qd4x792isyd&type=price  
![image](https://user-images.githubusercontent.com/58031089/114712992-f63b3b00-9d30-11eb-926e-d5fff65bc636.png)  

**Conclusie:**  
LunarCRUSH heeft alles wat ik wil, behalve de prijs en het feit dat het per uur update, maar dat is voor mijn project niet van belang op het moment. LunarCRUSH gaat dus zeker weten niet in mijn project komen i.v.m. de prijs.

### [CoinDesk](https://www.coindesk.com/coindesk-api)
CoinDesk heeft een simpele API die alleen Bitcoin data verstrekt (BPI).  

**Criterea:**
- Kosten: 0
- Aantal calls: Onbeperkt
- Bruikbare periode: Onbeperekt
- Data: https://api.coindesk.com/v1/bpi/currentprice.json  
![image](https://user-images.githubusercontent.com/58031089/114720532-626d6d00-9d38-11eb-9701-95d5372f3233.png)

**Conclusie:**  
Deze API is alleen handig als het niet mogelijk is een van de eerder benoemde API's aan te sluiten, de data is te schaars om zinvol in mijn project te verwerken.

## Workshop (Prototyting)
Ik ga prototypes maken tijdens het API onderzoek om te vergelijken welke API het beste is. Een van deze prototypes is mijn [Coin Test API](https://github.com/BrucevandeVen/ExternalCryptoAPI/tree/main/CoinAPITest).

## Conclusie
Coinmarketcap is een zeer sterke optie, deze past bij mijn criterea. Ik ga deze API gebruiken bij mijn implementatie.
