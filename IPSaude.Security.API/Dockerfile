#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["IPSaude.Security.API/IPSaude.Security.API.csproj", "IPSaude.Security.API/"]
RUN dotnet restore "IPSaude.Security.API/IPSaude.Security.API.csproj"
COPY . .
WORKDIR "/src/IPSaude.Security.API"
RUN dotnet build "IPSaude.Security.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IPSaude.Security.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IPSaude.Security.API.dll"]