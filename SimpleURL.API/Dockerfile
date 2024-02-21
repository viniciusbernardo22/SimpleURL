FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SimpleURL.API/SimpleURL.API.csproj", "SimpleURL.API/"]
RUN dotnet restore "SimpleURL.API/SimpleURL.API.csproj"
COPY . .
WORKDIR "/src/SimpleURL.API"
RUN dotnet build "SimpleURL.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleURL.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleURL.API.dll"]
