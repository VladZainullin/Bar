FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM  mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /build
COPY . . 
RUN dotnet restore
RUN dotnet build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web.dll"]