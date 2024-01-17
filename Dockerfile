FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /app/PersonnummerKontrollApp

COPY ./bin/Debug/net8.0/ .

CMD ["dotnet", "PersonnummerKontrollApp/out/PersonnummerKontrollApp.dll"]