#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Assessment.Api/Assessment.Api.csproj", "Assessment.Api/"]
RUN dotnet restore "Assessment.Api/Assessment.Api.csproj"
COPY . .
WORKDIR "/src/Assessment.Api"
RUN dotnet build "Assessment.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Assessment.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Assessment.Api.dll"]