#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Resume.Api/Resume.Api.csproj", "Resume.Api/"]
RUN dotnet restore "Resume.Api/Resume.Api.csproj"
COPY . .
WORKDIR "/src/Resume.Api"
RUN dotnet build "Resume.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Resume.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Resume.Api.dll"]