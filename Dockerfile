FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY APP_LAWYER.DAL/*.csproj ./APP_LAWYER.DAL/
COPY APP_LAWYER.BLL/*.csproj ./APP_LAWYER.BLL/
COPY APP_LAWYER.WEB/*.csproj ./APP_LAWYER.WEB/
RUN dotnet restore

# Copy everything else and build
COPY APP_LAWYER.DAL/. ./APP_LAWYER.DAL/
COPY APP_LAWYER.BLL/. ./APP_LAWYER.BLL/
COPY APP_LAWYER.WEB/. ./APP_LAWYER.WEB/
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "APP_LAWYER.WEB.dll"]