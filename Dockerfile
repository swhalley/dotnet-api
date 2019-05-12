#Build
FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build

WORKDIR /app
COPY Backend/*.csproj ./staging/

WORKDIR /app/staging/
RUN dotnet restore

COPY Backend/. ./
RUN dotnet publish -c Release -o out

#Runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine AS runtime
WORKDIR /app
COPY --from=build /app/staging/out ./

RUN pwd

EXPOSE 5000
EXPOSE 5001
ENTRYPOINT ["dotnet", "dotnet-api-oauth.dll"]