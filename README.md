# Task Tracker API

A simple Task Tracker REST API built using ASP.NET Core .NET 8.

This project was developed as part of the Junior Full Stack Developer take-home assignment.

## Features

The API allows users to manage projects and tasks.

### Projects

- View all projects
- View a project by ID
- Create a new project
- Update an existing project
- Delete a project
- View tasks belonging to a project
- Create a task for a project

### Tasks

- View a task by ID
- Update an existing task
- Delete a task

## Technologies Used

- .NET 8
- ASP.NET Core Web API
- C#
- Swagger / OpenAPI
- In-memory data using C# Lists

No database is required. The application uses hard-coded sample data stored in memory.

## Sample Data

The application starts with:

- 2 sample projects
- 4 sample tasks

Example projects include:

- Website Redesign
- Mobile App

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/Projects` | Get all projects |
| GET | `/api/Projects/{id}` | Get a project by ID |
| POST | `/api/Projects` | Create a project |
| PUT | `/api/Projects/{id}` | Update a project |
| DELETE | `/api/Projects/{id}` | Delete a project |
| GET | `/api/Projects/{id}/tasks` | Get tasks for a project |
| POST | `/api/Projects/{id}/tasks` | Create a task for a project |
| GET | `/api/Tasks/{id}` | Get a task by ID |
| PUT | `/api/Tasks/{id}` | Update a task |
| DELETE | `/api/Tasks/{id}` | Delete a task |

## How to Run

1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Make sure .NET 8 SDK is installed.
4. Build the solution.
5. Run the project using the HTTPS profile.
6. Swagger UI will open in the browser.
7. Use Swagger to test the API endpoints.

The Swagger URL will be similar to:

`https://localhost:<port>/swagger/index.html`

The port number may be different depending on the local environment.

## Completed

The following requirements have been completed:

- .NET 8 Web API
- Swagger/OpenAPI
- In-memory data
- 2 sample projects
- 4 sample tasks
- Project CRUD operations
- Task CRUD operations
- Project-specific task endpoints
- README documentation

## Notes

The application uses in-memory data, so changes made through the API are temporary. The original sample data will be restored when the application is restarted.