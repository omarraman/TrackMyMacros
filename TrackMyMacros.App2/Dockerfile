FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TrackMyMacros.App2/TrackMyMacros.App2.csproj", "TrackMyMacros.App2/"]
COPY ["TrackMyMacros.Dtos/TrackMyMacros.Dtos.csproj", "TrackMyMacros.Dtos/"]
COPY ["TrackMyMacros.Infrastructure/TrackMyMacros.Infrastructure.csproj", "TrackMyMacros.Infrastructure/"]
RUN dotnet restore "TrackMyMacros.App2/TrackMyMacros.App2.csproj"
COPY . .
WORKDIR "/src/TrackMyMacros.App2"
RUN dotnet build "TrackMyMacros.App2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TrackMyMacros.App2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrackMyMacros.App2.dll"]
