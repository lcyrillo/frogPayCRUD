FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["FrogPay.CRUD.API/FrogPay.CRUD.API.csproj", "FrogPay.CRUD.API/"]
COPY ["FrogPay.CRUD.Domain/FrogPay.CRUD.Domain.csproj", "FrogPay.CRUD.Domain/"]
COPY ["FrogPay.CRUD.Infrastructure/FrogPay.CRUD.Infrastructure.csproj", "FrogPay.CRUD.Infrastructure/"]

RUN dotnet restore "FrogPay.CRUD.API/FrogPay.CRUD.API.csproj"

COPY . .

WORKDIR "/src/FrogPay.CRUD.API"
RUN dotnet build "FrogPay.CRUD.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FrogPay.CRUD.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "FrogPay.CRUD.API.dll" ]