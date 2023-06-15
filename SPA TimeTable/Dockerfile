FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Install Node.js
RUN curl -fsSL https://deb.nodesource.com/setup_14.x | bash - \
    && apt-get install -y \
        nodejs \
    && rm -rf /var/lib/apt/lists/*

WORKDIR /src
COPY ["SPA TimeTable/SPA TimeTable.csproj", "SPA TimeTable/"]
RUN dotnet restore "SPA TimeTable/SPA TimeTable.csproj"
COPY . .
WORKDIR "/src/SPA TimeTable"
RUN dotnet build "SPA TimeTable.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SPA TimeTable.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SPA TimeTable.dll"]
