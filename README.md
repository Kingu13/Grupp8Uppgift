# PersonnummerValidator Applikation

## Introduktion
PersonnummerValidator är en C#-applikation utvecklad för att validera svenska personnummer. Applikationen erbjuder konsolbaserad interaktion och Docker-stöd, vilket möjliggör enkel validering av personnummer enligt svenska standarder.

## Funktioner
- Validerar svenska personnummer enligt formaten YYMMDD-XXXX och YYYYMMDD-XXXX.
- Möjlighet att köra applikationen både lokalt och i en Docker-container.
- Inkluderar grundläggande logik för att kontrollera format och längd på inmatade personnummer.

## Systemkrav
- .NET 8.0 SDK.
- Docker (för körning i en container).

## Installation och Körning

### Lokal Körning

1. **Skapa en map där du vill ha filerna från github**

2. **Klona Repositoriet:**
git clone "https://github.com/Msigersted/Grupp8Uppgift.git"

3. **Kör Applikationen:**
Öppna en terminal för filen "Program.cs"
Använd kommandot: dotnet run

### Kör Enhetstester
Öppna en terminal för filen "UnitTest1.cs"
För att köra enhetstesterna, använd följande kommando: dotnet test

2. **Kör Docker-Containern**:
docker run personnummerkontroll


## Personnummer Validering

Svenska personnummer består av 10 eller 12 siffror (YYMMDD-XXXX, YYYYMMDD-XXXX) där YYMMDD och YYYYMMDD representerar födelsedatum och XXXX är en unik kod inklusive en kontrollsiffra. Applikationen kontrollerar att inmatningen:

- Är 11 eller 13 tecken lång inklusive bindestreck.
- Har korrekta sifferpositioner och format.
- (Valfritt) Ytterligare valideringslogik kan läggas till för att kontrollera datum och kontrollsiffran.



