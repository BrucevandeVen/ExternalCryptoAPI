# API Onderzoek

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
[LunarCRUSH](https://lunarcrush.com/developers/pricing) is de eerste API die behandeld wordt

## Onderzochtten API's
### Table Of Contents
- [Coinmarketcap](https://github.com/BrucevandeVen/ExternalCryptoAPI/tree/main/API%20Onderzoek#coinmarketcap)
- [LunarCRUSH](https://github.com/BrucevandeVen/ExternalCryptoAPI/tree/main/API%20Onderzoek#lunarcrush)

### [Coinmarketcap](https://coinmarketcap.com/)
Als eerste heb ik [coinmarketcap](https://coinmarketcap.com/api/) bezocht, omdat ik deze website al veel voorbij heb zien komen in mijn kennissenkringen en zelf ook wel eens gebruikt heb om de huidige crypto waardes te volgen. De data is op een aantal seconden na accuraat. De Coinmarketcap documentatie zit achter een login scherm.  

**Criterea:**
- Kosten: 0
- Aantal calls: Maximaal 30 per minuut, 333 per dag, 10.000 per maand
- Bruikbare periode: Onbeperkt
- Data: https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest   
![image](https://user-images.githubusercontent.com/58031089/114706687-8ecdbd00-9d29-11eb-8884-f99dc7e5180c.png)

**Conclusie:**    
Coinmarketcap is zeer geschikt om te gebruiken voor mijn project, het voldoet aan mijn criterea.  

### [LunarCRUSH](https://lunarcrush.com/dashboard)
LunarCRUSH heb ik onderzocht in de Library fase. De data update elk uur. De [LunarCRUSH documentatie](https://lunarcrush.com/developers/docs#).  

**Criterea:**
- Kosten: 0
- Aantal calls: Onbeperkt
- Bruikbare periode: Onbeperkt
- Data: https://api.lunarcrush.com/v2?data=meta&key=8piwl04kwy9qd4x792isyd&type=price  
![image](https://user-images.githubusercontent.com/58031089/114712992-f63b3b00-9d30-11eb-926e-d5fff65bc636.png)  

**Conclusie:**  
LunarCRUSH heeft alles wat ik wil, er is geen enkele mogelijkheid dat hier nog een API overheen komt. Het enige minpunten is dat de API per uur update, maar dat is voor mijn project niet van belang op het moment.

## Workshop (Prototyting)
Ik ga prototypes maken tijdens het API onderzoek om te vergelijken welke API het beste is. Een van deze prototypes is mijn [Coin Test API](https://github.com/BrucevandeVen/ExternalCryptoAPI/tree/main/CoinAPITest).
