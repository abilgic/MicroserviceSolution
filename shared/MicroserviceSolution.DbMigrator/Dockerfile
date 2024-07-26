FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mycompanyname/microservicesolution-base:1.0 AS build
WORKDIR /src

COPY . .
WORKDIR "/src/shared/MicroserviceSolution.DbMigrator"
RUN dotnet publish -c Release -o /app

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroserviceSolution.DbMigrator.dll"]