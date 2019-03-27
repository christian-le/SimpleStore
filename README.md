# SimpleStore
A Simple store on .Net Core 2.2

VERSIONS

The master branch is currently running ASP.NET Core 2.2.

Ensure your connection strings in appsettings.json point to a local SQL Server instance.

Open a command prompt in the Web folder and execute the following commands:

dotnet restore
dotnet ef database update -c identitydbcontext -p ../SimpleStore/SimpleStore.csproj -s SimpleStore.csproj
dotnet ef database update -c simplestoredbcontext -p ../SimpleStore/SimpleStore.Infrastructure/SimpleStore.Infrastructure.csproj -s SimpleStore.csproj
