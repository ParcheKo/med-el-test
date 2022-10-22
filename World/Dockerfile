FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["World/World.csproj", "World/"]
RUN dotnet restore "World/World.csproj"
COPY . .
WORKDIR "/src/World"
RUN dotnet build "World.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "World.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "World.dll"]
