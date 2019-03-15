# Overview 
This application demonstrates using dotnet core and EF core to build an application.
dotnet core is used to create rest endpoints. EF core is used to communicate with the database.

# Setup

## Run a database
The mySQL database below is using Docker to run. If you have an existing MySQL database you can skip this step.

The connection pool information can be found in appsettings.json and/or appsettings.Development.json
```
"ConnectionStrings": {
    "ContactDb": "server=localhost;database=test;user=user;password=secret"
  },
```

To run the development server

`docker-compose up`

## Run the application
The below command runs the dotnet application and exposes the endpoint

`dotnet run`


# Prerequisite

* dotnet core - https://dotnet.microsoft.com/download
* docker (optional) - https://www.docker.com/get-started


# Useful Links
* Example Application - Tutorial https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.2&tabs=visual-studio-code
* Dotnet core commands - https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore21
* NuGet Repository - https://www.nuget.org/packages/
* C# Tutorial on using Auth0 - https://auth0.com/docs/quickstart/backend/aspnet-core-webapi
* Angular Tutorial on using Auth0 - https://auth0.com/docs/quickstart/spa/angular2
