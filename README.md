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

## Restore Dependencies
There are dependencies in the application that need to be pulled from NuGet

`dotnet restore`

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

# Other Notes
* This application was created using the command `dotnet new webapi -o appName`
* Also consider using `dotnet new angular -o appName` if you want the front and backend in the same application.
* When adding dependencies look at the NuGet repository above. New dependencies can be added with `dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.15`. On the Nuget site, choose the .NET CLI tab to get the command to add any dependency.

# Future Consideration

* Show OAuth working to secure the API
* Connect with a Frontend