#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GoogleAppVersionParser/GoogleAppVersionParser.csproj", "GoogleAppVersionParser/"]
RUN dotnet restore "GoogleAppVersionParser/GoogleAppVersionParser.csproj"
COPY . .
WORKDIR "/src/GoogleAppVersionParser"
RUN dotnet build "GoogleAppVersionParser.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GoogleAppVersionParser.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GoogleAppVersionParser.dll"]