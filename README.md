# Overview 
This application demonstrates using dotnet core and EF core to build an application.
dotnet core is used to create rest endpoints. EF core is used to communicate with the database.
In this example, Postgres is used as the database of choice.

In front of all this, is an nginx server acting as a reverse proxy. 

Docker is used to help simulate the setup. 

# Setup

## Configure a database
The connection pool information can be found in appsettings.json and/or appsettings.Development.json
```
"ConnectionStrings": {
    "ContactDb": "server=localhost;database=test;user=user;password=secret"
  },
```

Modify the connection string if you need to. Currently it is using a docker container to bring together the components, so there should be no change required.

## To run the development server

`docker-compose up`

# Additional 
If you want to run the application locally, without Docker, you can do the following.

Note - you will need to modify the DB connection string to point to a proper database

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