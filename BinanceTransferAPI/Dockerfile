FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BinanceTransferAPI/BinanceTransferAPI.csproj", "BinanceTransferAPI/"]
RUN dotnet restore "BinanceTransferAPI/BinanceTransferAPI.csproj"
COPY . .
WORKDIR "/src/BinanceTransferAPI"
RUN dotnet build "BinanceTransferAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BinanceTransferAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BinanceTransferAPI.dll"]
