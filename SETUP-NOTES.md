# Important setup notes

This is a starter scaffold, not a verified final submission. It has not been compiled in this environment because the .NET SDK is not installed here. Build it in Visual Studio and resolve any compiler/runtime issues before submission.

## Create database with EF Core
Open Tools > NuGet Package Manager > Package Manager Console and run:

```powershell
Install-Package Microsoft.EntityFrameworkCore.Tools
Add-Migration InitialCreate
Update-Database
```

The default connection string uses SQL Server LocalDB. If you use SQL Server Express or another SQL Server instance, change `RaceDayConnection` in `appsettings.json`.

## Before submission
- Add any missing endpoints required by the approved Part 1 endpoint plan (especially full update/delete for categories and results, plus routes and weather CRUD).
- Review whether your ERD/SQL script has the same property names and relationship cardinalities. EF Code-First creates its own schema; don't also run a separate SQL CREATE script against the same database.
- Expand the starter unit tests to cover registration/login, role rejection, organiser event ownership and participant enrolments; confirm the GitHub Actions workflow passes.
- Ensure the session cookie is retained by Swagger/browser during login and subsequent calls. Session auth here is a teaching scaffold and should be tested locally.
- Never commit real passwords, connection secrets or real personal ID numbers.
