# Onderzoek naar de implementatie van een externe crypto API

## Introductie
Ik ben zelf al enige tijd bezig met het maken van een Full Stack Crypto WEB APP. In het proces ben ik erachter gekomen dat er meerdere crypto data API's zijn die zeer veel verschillen, er kwamen dus een aantal vragen naar boven zoals: Hoe implementeer "ik een externe crypto API?" en "Welke crypto API is het 'beste'?". In dit onderzoek ga ik proberen een goed beeld te schetsen over hoe je een externe crypto API kan implementeren in een ASP.NET WEB API project.

## Table Of Contents
- [DOT Framework](#dot-framework)
- [What](#what)
- [Why](#why)
- [How](#How)

## DOT Framework

<img src=https://user-images.githubusercontent.com/58031089/114270834-cd543680-9a0e-11eb-9b01-7248641fab13.png width="300" height="300" />

DOT (Development Oriented Triangulation) Framework, is een een onderzoeksmethode die gebruikt kan worden in ICT onderzoeken om zo een goede structuur, compleet en duidelijk overzicht te creëren voor elke lezer. Hierbij wordt de What, Why en How structuur gebruikt.

Bron: [DOT Framework](https://ictresearchmethods.nl/The_DOT_Framework)

## What
Voor mijn project wil ik weten wat de beste manier is om een crypto API te implementeren. Mijn applicatie is een crypto monitor, hierop is het de bedoeling de huidige crypto waardes te laten zien. Ik wil meer dan alleen de Bitcoin waarde weten, maar meer dan 20 verschillende coins vind ik ook overbodig. Ik ga dus zoeken naar een Crypto API die meer dan alleen Bitcoin waardes doorgeeft en minimaal dit semester mee kan omtrent het aantal requests. Als laatste mag het ook geen betaalde API zijn. 
Ook moet ik een externe API kunnen implementeren in mijn project. Ik heb alleen de PUT endpoint nodig, omdat ik alleen waardes wil updaten.

De hoofdonderzoeksvraag:  
**Wat is de beste crypto data API en hoe implementeer ik deze in mijn ASP.NET WEB API project?**

## Why  
**Deelvragen**  
Ik ga dit onderzoek uitvoeren, omdat ik overwelmt wordt door alle opties op het gebied van crypto API's. Het is lastig om iets te vinden wat aan mijn criterea voldoet. Om tot een concreter antwoord te komen heb ik 2 deelvragen bedacht:  
- Wat is/zijn de beste Crypto API('s) voor mijn project?
- Hoe implementeer ik een Crypto API in mijn project?  

**Wat gaat dit onderzoek oplossen?**  
Dit onderzoek gaat er voor zorgen dat ik de juiste externe (Crypto) API kan vinden en implementeren in mijn project. Ik loop hier nu al een tijdje op vast en kijk uit naar het resultaat.

## How
DOT Framework heeft 5 methodes om een onderzoek uit te voeren:
- [Library](https://ictresearchmethods.nl/Category:Library) (onderzoeken wat al gedaan is)
- [Field](https://ictresearchmethods.nl/Category:Field) (baseer keuzes op end users) 
- [Workshop](https://ictresearchmethods.nl/Category:Workshop) (prototyping/sketching)
- [Lab](https://ictresearchmethods.nl/Category:Lab) (testing)
- [Showroom](https://ictresearchmethods.nl/Category:Showroom) (expert feedback)

Ik ben van plan de volgende methodes te gebruiken:  
- Library
- Workshop
- Lab (optioneel)
- Showroom (optioneel)

Ik ben van plan een test applicatie te maken om verschillende API endpoints te kunnen testen van verschillende websites. 
