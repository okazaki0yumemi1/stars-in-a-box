#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["stars-in-a-box/stars-in-a-box.csproj", "stars-in-a-box/"]
RUN dotnet restore "stars-in-a-box/stars-in-a-box.csproj"
COPY . .
WORKDIR "/src/stars-in-a-box"
RUN dotnet build "stars-in-a-box.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "stars-in-a-box.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "stars-in-a-box.dll"]