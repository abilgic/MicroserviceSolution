FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80

FROM mycompanyname/microservicesolution-base:1.0 AS build
WORKDIR /src

COPY . .
WORKDIR "/src/services/identity/src/MicroserviceSolution.IdentityService.HttpApi.Host"
RUN dotnet publish -c Release -o /app

FROM build AS publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroserviceSolution.IdentityService.HttpApi.Host.dll"]