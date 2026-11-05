
# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["PersonalProfileApp/PersonalProfileApp.csproj", "PersonalProfileApp/"]
RUN dotnet restore "PersonalProfileApp/PersonalProfileApp.csproj"

COPY . .
WORKDIR /src/PersonalProfileApp

RUN dotnet publish "PersonalProfileApp.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "PersonalProfileApp.dll"]
