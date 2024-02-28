# Utilisez l'image de base SDK pour compiler le code source
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copiez csproj et restaurez les dépendances
COPY *.csproj ./
RUN dotnet restore

# Copiez le reste des fichiers et construisez
COPY . ./
RUN dotnet publish -c Release -o out

# Générez l'image de runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "PraiseUS.dll"]
