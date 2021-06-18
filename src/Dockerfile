# Stage 1 (Copy and restore layers from application)
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build 
WORKDIR /src
COPY *.sln ./
COPY *.config ./
COPY TechnicalChallenge.Api/TechnicalChallenge.Api.csproj/ TechnicalChallenge.Api/
COPY TechnicalChallenge.Domain/TechnicalChallenge.Domain.csproj/ TechnicalChallenge.Domain/
COPY TechnicalChallenge.Domain.Core/TechnicalChallenge.Domain.Core.csproj/ TechnicalChallenge.Domain.Core/
COPY TechnicalChallenge.Tests/TechnicalChallenge.Tests.csproj/ TechnicalChallenge.Tests/

RUN dotnet restore
COPY . ./

# Stage 2 (Publish application into /app directory)
WORKDIR /src/TechnicalChallenge.Api
RUN dotnet publish -c Release -o /app

# Stage 3 (Generate runtime image from previous processes)
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 80
COPY --from=build /app .
ENTRYPOINT ["dotnet", "TechnicalChallenge.Api.dll"]