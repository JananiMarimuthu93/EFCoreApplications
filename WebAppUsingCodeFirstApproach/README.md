
# MVC Code-First Course Application

This project demonstrates an ASP.NET Core MVC application using the Entity Framework Core Code-First approach with a simple `Course` entity.

---

## Features
- Defines a `Course` model.
- Uses `EfCoreContext` with EF Core to manage database operations.
- Uses migrations to create database schema.
- Implements full CRUD operations scaffolded with MVC controllers and views.
- Connects to SQL Server database.

---

## Setup Instructions

### Prerequisites
- Visual Studio 2022 or later with ASP.NET Core development workload.
- SQL Server instance running locally or remotely.
- .NET 8.0 SDK installed.

### Configuration
1. Update the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=KDJ-LAPTOP\\SQLEXPRESS;Database=EfCore;Integrated Security=True;trustservercertificate=True"
   }
   ```

2. Register `AppDbContext` in `Program.cs`:
   ```csharp
   builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
   ```

### EF Core Migrations
Run these commands in the Package Manager Console:
```powershell
Add-Migration InitialCreate
Update-Database
```
This will create the database and `Courses` table.

---

## Running the Application

- Press F5 or run the app.
- Navigate to `/Courses`.
- Perform Create, Read, Update, and Delete operations on Course records.

---

## Troubleshooting

- If you see errors about missing DLLs during migrations, ensure the Package Manager Console Default Project is set correctly.
- Verify your connection string points to the correct database.
- Make sure to apply migrations before running the app.
- Use `-Project` and `-StartupProject` flags if you have multiple projects:
  ```powershell
  Update-Database -Project YourProjectName -StartupProject YourProjectName
  ```

---

## Project Structure

- `Models/` - Contains `Course` entity and `AppDbContext`.
- `Controllers/` - Contains MVC controller for Courses.
- `Views/` - Contains Razor views for CRUD UI.


