# Cross platform ASP.NET core
Code sample for a series of articles detailing steps to take towards building an ASP.NET core application from scratch on either Windows, Linux or MacOS.

## Run & Deploy
Clone this repository into your local machine 

```bash
git clone https://github.com/temilaj/cross-platform-asp-net-core.git
```
and then navigate to the application directory
```bash
cd cross-platform-asp-net-core.csproj
```
restore the application dependencies described in the `cross-platform-asp-net-core.csproj` file

```bash
dotnet restore
```

run the application

```bash
dotnet run
```

The `dotnet restore` command first restores the necessary packages required to run the application, 
the `dotnet run` command simultaneously re-compiles and runs the application in the terminal

I would love to hear your [feedback](https://temilajumoke.com)
