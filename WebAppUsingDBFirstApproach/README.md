# MVC Application with EF Core Database-First Approach

This project demonstrates how to build an ASP.NET Core MVC web application using the **Database-First** approach with Entity Framework Core.

---

## Features

- Scaffolded DbContext and entity classes from an existing SQL Server database
- Full CRUD operations with auto-generated MVC controllers and views
- Uses SQL Server as the backend database
- Clean architecture separating models, views, and controllers

---

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server Express or full SQL Server installed and running
- Visual Studio 2022 or Visual Studio Code
- EF Core packages installed:
  - Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools

---

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/MvcEfCoreDbFirst.git
cd MvcEfCoreDbFirst
```
### 2. Update connection string
Update your connection string in appsettings.json to point to your SQL Server instance:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=KDJ-LAPTOP\SQLEXPRESS;Database=EfCore;Integrated Security=True;trustservercertificate=True" 
}
```
### 3. Scaffold the database
Run the following command in Package Manager Console to scaffold your models and DbContext from the existing database:

```
Scaffold-DbContext "Server=KDJ-LAPTOP\SQLEXPRESS;Database=EfCore;Integrated Security=True;trustservercertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```
4. Register DbContext service
In Program.cs (or Startup.cs), add:

### builder.Services.AddDbContext<EfcoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

### 5. Scaffold MVC Controllers and Views
Use Visual Studio’s scaffolding feature:

Right-click Controllers folder → Add → Controller

Choose MVC Controller with views, using Entity Framework

Select the model (e.g., Standard)

Select the EfcoreContext as the data context

Click Add

6. Run the application
Press F5 and navigate to /Standards (or your controller route) to see the CRUD UI for the table.

### Project Structure

Models/ - Contains the scaffolded entity classes and DbContext.

Controllers/ - MVC controllers with CRUD actions.

Views/ - Razor views for the CRUD UI.

### Troubleshooting
Ensure your database exists and is accessible.

If scaffolding fails, verify connection string and permissions.

Delete existing scaffold files before regenerating to avoid conflicts.

For large databases, consider selective scaffolding with -Tables option.