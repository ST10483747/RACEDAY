# RaceDay Event Management API — Part 2

RaceDay is a RESTful API for South African running, walking and cycling events. Organisers manage their own events, categories and results. Participants browse events, enrol in a category and view their enrolments and results.

## Roles
- **Organiser:** creates and manages their own events and categories, views enrolments for their events and records results.
- **Participant:** views events and categories, enrols in events and views their own profile, enrolments and results.

## Technology
- C# / ASP.NET Core Web API (.NET 8)
- Entity Framework Core Code-First
- SQL Server
- Swagger
- GitHub Actions

## Run locally
1. Install the .NET 8 SDK and SQL Server/LocalDB.
2. Open `RaceDay.Api.csproj` in Visual Studio.
3. Edit `appsettings.json` if your SQL Server connection string differs.
4. In Package Manager Console run `Add-Migration InitialCreate` and then `Update-Database` (or use `dotnet ef migrations add InitialCreate` and `dotnet ef database update` after installing the EF CLI tool).
5. Run the project. In Development, Swagger is available at `/swagger`.

## Main API routes
- `POST /api/auth/register`, `POST /api/auth/login`, `POST /api/auth/logout`
- `GET /api/profile`
- `GET /api/events`, `GET /api/events/{id}`, `POST /api/events`, `PUT /api/events/{id}`, `DELETE /api/events/{id}`
- `GET /api/events/{eventId}/categories`, `POST /api/events/{eventId}/categories`
- `POST /api/enrolments`, `GET /api/enrolments/my`, `GET /api/enrolments/event/{eventId}`
- `POST /api/results`, `GET /api/results/my`, `GET /api/results/event/{eventId}`

## CI/CD
GitHub Actions restores and builds the API on each push and pull request. Add a screenshot of a successful green workflow run here after it passes.

## Video demonstration
Add the unlisted YouTube video link here after recording the API walkthrough.

## AI assistance disclosure
AI assistance was used to help draft and explain parts of the starter code. The student reviewed, tested, adapted and should understand all submitted code in accordance with the module's academic integrity requirements.
