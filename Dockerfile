FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /app

COPY  ./bin/Debug/net6.0/ .

WORKDIR /app/PersonnummerKontrollApp

RUN dotnet publish -c Release -o out

WORKDIR /app

CMD ["dotnet", "PersonnummerKontrollApp/out/PersonnummerKontrollApp.dll"]
