# SWSEC-INTRO .NET 6.0 backend

## Setup

Be sure to use a .NET 6.0 SDK. This project has been tested in a Fedora Linux
machine with dotnet installed (`sudo dnf install dotnet-sdk-6.0`). Create the
database and build the app using:

```shell
dotnet tool restore
dotnet build
dotnet ef database update
```

## Run

```shell
dotnet run
```

If you want to run the app in Development mode (which includes Swagger data):

```shell
ASPNETCORE_ENVIRONMENT=Development dotnet run
```

There¿'s a Makefile available if you want better support for this.

## Reset database

```
dotnet ef database drop
dotnet ef database update
```

