# Console Based Code-First EF Core Application

This is a simple .NET console application demonstrating how to use **Entity Framework Core** with the **Code-First** approach.  
The app allows CRUD (Create, Read, Update, Delete) operations on a `Standard` entity using SQL Server.

---

## Features

- Code-First EF Core setup with `EfCoreContext`
- `Standard` entity with properties:
  - `StandardId` (Primary Key, Identity)
  - `StandardName`
  - `Description`
- CRUD operations implemented in `StandardCrudServices` class
- Console menu UI to interact with the database
- Connection string configured to connect to local SQL Server instance

---

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server Express or full SQL Server installed locally
- Visual Studio 2022 or VS Code
- EF Core Tools installed (`Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.SqlServer`)

---

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/ConsoleBasedCodeFirstEFCore.git
cd ConsoleBasedCodeFirstEFCore
```
### 2. Update connection string
Edit the connection string in Program.cs or EfCoreContext to point to your SQL Server instance:

```
"Data Source=KDJ-LAPTOP\\SQLEXPRESS;Initial Catalog=efcore;Integrated Security=True;TrustServerCertificate=True"
```
### 3. Create and apply migrations
Open Package Manager Console in Visual Studio and run:

```
Add-Migration InitialCreate
Update-Database
```
This creates the database and Standard table.

4. Run the application
Start the console app. Use the menu to perform CRUD operations on Standard data.

### Project Structure
Models/
Contains entity classes (Standard) and EfCoreContext.

Services/
Contains StandardCrudServices which implements the CRUD logic.

Program.cs
Contains the console UI and setup.


### Troubleshooting
Make sure the EF Core tools are installed and your project builds successfully.

Ensure your SQL Server instance is running and accessible.

If migrations fail, try deleting existing migrations and database, then recreate.

Use a Design-Time DbContext Factory if EF Core tools can't create your DbContext instance.
