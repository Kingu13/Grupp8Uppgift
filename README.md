# CICDPineLine

# Personnummerkontrollapplikation

Denna applikation är designad för att validera svenska personnummer. Den är skapad i C# och innehåller NUnit-tester för att verifiera funktionaliteten. Applikationen kan köras lokalt eller i en Docker-container.

## Funktioner

- Validerar svenska personnummer.
- Inkluderar enhetstester för att säkerställa korrekt validering.
- Docker-stöd för flexibel körning.

## Förutsättningar

- .NET 6.0 eller senare.
- Docker (för att köra applikationen i en container).

## Installation och Körning

### Lokalt

1. **Klona Repositoriet:**
git clone "https://github.com/Kingu13/Grupp8Uppgift.git"

2. **Navigera till Repositoriet:**
cd 

3. **Bygg och Kör Applikationen:**
dotnet build 
dotnet run

### Kör Enhetstester

För att köra enhetstesterna, använd följande kommando:
detnet test


### Använda Docker

1. **Bygg Docker-Containern:**
docker run personnummerkontroll


## Svenska Regler för Personnummer

Svenska personnummer följer formatet YYMMDD-XXXX, där YYMMDD representerar födelsedatum och XXXX är en unik kod med en kontrollsiffra som sista siffra. Applikationen validerar personnummer genom att:

1. **Kontrollera Formatet:** Se till att numret följer det korrekta formatet.
2. **Datumvalidering:** Kontrollera att YYMMDD utgör ett giltigt datum.
3. **Kontrollsiffran:** Använd Luhn-algoritmen för att verifiera kontrollsiffran.


