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


