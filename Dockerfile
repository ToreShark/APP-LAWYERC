FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["APP_LAWYER.WEB/APP_LAWYER.WEB.csproj", "APP_LAWYER.WEB/"]
COPY ["APP_LAWYER.BLL/APP_LAWYER.BLL.csproj", "APP_LAWYER.BLL/"]
COPY ["APP_LAWYER.DAL/APP_LAWYER.DAL.csproj", "APP_LAWYER.DAL/"]
RUN dotnet restore "APP_LAWYER.WEB/APP_LAWYER.WEB.csproj"
COPY . .
WORKDIR "/src/APP_LAWYER.WEB"
RUN dotnet build "APP_LAWYER.WEB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "APP_LAWYER.WEB.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APP_LAWYER.WEB.dll"]