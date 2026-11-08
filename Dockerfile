# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

# Copy both project files
COPY ["RaceDay222MVC/RaceDay222MVC.csproj", "RaceDay222MVC/"]
COPY ["RaceDay222/RaceDay222.csproj", "RaceDay222/"]

# Restore dependencies
RUN dotnet restore "RaceDay222MVC/RaceDay222MVC.csproj"

# Copy the remaining solution files
COPY . .

# Publish MVC
WORKDIR /src/RaceDay222MVC

RUN dotnet publish "RaceDay222MVC.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false


# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=8080

EXPOSE 8080

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "RaceDay222MVC.dll"]