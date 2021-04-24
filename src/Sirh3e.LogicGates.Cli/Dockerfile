FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Sirh3e.LogicGates.Cli/Sirh3e.LogicGates.Cli.csproj", "Sirh3e.LogicGates.Cli/"]
RUN dotnet restore "src/Sirh3e.LogicGates.Cli/Sirh3e.LogicGates.Cli.csproj"
COPY . .
WORKDIR "/src/Sirh3e.LogicGates.Cli"
RUN dotnet build "Sirh3e.LogicGates.Cli.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sirh3e.LogicGates.Cli.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sirh3e.LogicGates.Cli.dll"]
