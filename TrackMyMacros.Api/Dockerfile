FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TrackMyMacros.Api/TrackMyMacros.Api.csproj", "TrackMyMacros.Api/"]
COPY ["TrackMyMacros.Application/TrackMyMacros.Application.csproj", "TrackMyMacros.Application/"]
#COPY ["TrackMyMacros.Domain/TrackMyMacros.Domain.csproj", "TrackMyMacros.Domain/"]
#COPY ["TrackMyMacros.Dtos/TrackMyMacros.Dtos.csproj", "TrackMyMacros.Dtos/"]
#COPY ["TrackMyMacros.Infrastructure/TrackMyMacros.Infrastructure.csproj", "TrackMyMacros.Infrastructure/"]
#COPY ["TrackMyMacros.Persistance/TrackMyMacros.Persistance.csproj", "TrackMyMacros.Persistance/"]
RUN dotnet restore "TrackMyMacros.Api/TrackMyMacros.Api.csproj"
COPY . .
WORKDIR "/src/TrackMyMacros.Api"
RUN dotnet build "TrackMyMacros.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TrackMyMacros.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrackMyMacros.Api.dll"]
