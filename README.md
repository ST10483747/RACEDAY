# RaceDay Event Management API — Part 2

## 1. Project Overview

RaceDay is a RESTful API developed to support South African running, walking and cycling events. It allows event organisers to manage events, categories and race results, while participants can browse events, enrol in categories and view their enrolments and results.

The system is developed using ASP.NET Core Web API and Entity Framework Core with a SQL Server database.

## 2. User Roles

### Organiser
- Create, view, update and manage events.
- Manage event categories.
- View enrolments for their events.
- Record and manage race results.

### Participant
- Browse available events and categories.
- Register for an account and log in.
- Enrol in event categories.
- View their profile, enrolments and results.

Access to protected functionality depends on the authentication and authorisation rules implemented by the API.

## 3. Technologies Used

- C#
- ASP.NET Core Web API
- .NET 8
- Entity Framework Core Code-First
- Microsoft SQL Server
- Swagger / OpenAPI
- xUnit for unit testing
- GitHub Actions for CI/CD

## 4. Main API Endpoints

### Authentication and Profile
- `POST /api/auth/register`
- `POST /api/auth/login`
- `POST /api/auth/logout`
- `GET /api/profile`

### Events
- `GET /api/events`
- `GET /api/events/{id}`
- `POST /api/events`
- `PUT /api/events/{id}`
- `DELETE /api/events/{id}`

### Event Categories
- `GET /api/events/{eventId}/categories`
- `POST /api/events/{eventId}/categories`

### Enrolments
- `POST /api/enrolments`
- `GET /api/enrolments/my`
- `GET /api/enrolments/event/{eventId}`

### Results
- `POST /api/results`
- `GET /api/results/my`
- `GET /api/results/event/{eventId}`

Other implemented endpoints, including routes and weather, can be explored through Swagger.

## 5. Requirements

Before running the project, install:
- .NET 8 SDK
- SQL Server or SQL Server LocalDB
- Visual Studio with ASP.NET and web development support

## 6. Running the Project Locally

1. Clone or download this repository.
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string in `appsettings.json` or the appropriate development configuration.
4. Restore the NuGet packages.
5. Apply the existing Entity Framework Core migrations to create or update the database. In Visual Studio's Package Manager Console, run:

   `Update-Database`

   If migrations do not exist yet, create them first using the appropriate EF Core migration command.
6. Run the API project.
7. Open the Swagger URL displayed by Visual Studio to explore and test the endpoints.

**Important:** Use the connection string and migration setup that match this repository. Do not create a second initial migration if one already exists.

## 7. Unit Testing

The project includes an xUnit test project. To run the tests in Visual Studio:

1. Open Test Explorer.
2. Select **Run All Tests**.
3. Review the results and correct any failed tests.

The test suite should be expanded to cover important API functionality, validation and access control.

## 8. Continuous Integration and Continuous Delivery (CI/CD)

GitHub Actions is configured to restore dependencies, build the API and run unit tests when changes are pushed or pull requests are opened for the configured branches.

The workflow is running successfully


## 9. Video Demonstration

Add the unlisted YouTube link after recording the demonstration. The video should show the API running, selected endpoints being tested and the relevant project functionality.

