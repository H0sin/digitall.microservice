#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Digitall/Api/Api.csproj", "src/Digitall/Api/"]
COPY ["src/Digitall/Ioc/Ioc.csproj", "src/Digitall/Ioc/"]
COPY ["src/Digitall/Application/Application.csproj", "src/Digitall/Application/"]
COPY ["src/Digitall/Data/Data.csproj", "src/Digitall/Data/"]
COPY ["src/Digitall/Domain/Domain.csproj", "src/Digitall/Domain/"]
RUN dotnet restore "./src/Digitall/Api/./Api.csproj"
ENV ASPNETCORE_URLS=http://+:5000
COPY . .
WORKDIR "/src/src/Digitall/Api"
RUN dotnet build "./Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.dll"]
