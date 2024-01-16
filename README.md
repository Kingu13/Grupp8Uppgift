# PersonnummerValidator Applikation

## Introduktion
PersonnummerValidator är en C#-applikation utvecklad för att validera svenska personnummer. Applikationen erbjuder konsolbaserad interaktion och Docker-stöd, vilket möjliggör enkel validering av personnummer enligt svenska standarder.

## Funktioner
- Validerar svenska personnummer enligt formatet YYMMDD-XXXX.
- Möjlighet att köra applikationen både lokalt och i en Docker-container.
- Inkluderar grundläggande logik för att kontrollera format och längd på inmatade personnummer.

## Systemkrav
- .NET 6.0 SDK eller högre.
- Docker (för körning i en container).

## Installation och Körning

### Lokal Körning

<<<<<<< HEAD
1.**Skapa en map där du vill ha filerna från github**:


2. **Klona Repositoriet med Git Bash**:
git clone "https://github.com/Kingu13/Grupp8Uppgift.git"



3. **Kompilera och kör applikationen**:
dotnet run

### Kör Enhetstester
Öppna en terminal för filen "UnitTest1.cs" För att köra enhetstesterna, använd följande kommando: dotnet test

### Körning med Docker

1. **Bygg Docker-Containern**:
docker build -t personnummerkontroll .
=======
1. **Skapa en map där du vill ha filerna från github**

2. **Klona Repositoriet:**
git clone "https://github.com/Kingu13/Grupp8Uppgift.git"

3. **Kör Applikationen:**
Öppna en terminal för filen "PersonnummerValidator.cs"
Använd kommandot: dotnet run

### Kör Enhetstester
Öppna en terminal för filen "UnitTest1.cs"
För att köra enhetstesterna, använd följande kommando: dotnet test
>>>>>>> 9483baac1f991cb513f6d63415e108bf7269cfcc

2. **Kör Docker-Containern**:
docker run personnummerkontroll


## Personnummer Validering

Svenska personnummer består av 10 siffror (YYMMDD-XXXX) där YYMMDD representerar födelsedatum och XXXX är en unik kod inklusive en kontrollsiffra. Applikationen kontrollerar att inmatningen:

- Är 11 tecken lång inklusive bindestreck.
- Har korrekta sifferpositioner och format.
- (Valfritt) Ytterligare valideringslogik kan läggas till för att kontrollera datum och kontrollsiffran.



