FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80

FROM mycompanyname/microservicesolution-base:1.0 AS build
WORKDIR /src

COPY . .
WORKDIR "/src/services/administration/src/MicroserviceSolution.AdministrationService.HttpApi.Host"
RUN dotnet publish -c Release -o /app

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroserviceSolution.AdministrationService.HttpApi.Host.dll"]