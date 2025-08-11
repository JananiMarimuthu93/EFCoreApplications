# EF Core Database-First Approach - Scaffold-DbContext Guide

## Overview

This project uses **Entity Framework Core (EF Core)** with the **Database-First** approach. The database schema already exists, and EF Core's **scaffolding** feature is used to generate C# model classes and the `DbContext` class based on the existing database tables.

---

## Scaffold-DbContext Command

The following command is used to reverse engineer the existing SQL Server database into EF Core model classes:

```powershell
Scaffold-DbContext "Server=KDJ-LAPTOP\SQLEXPRESS;Database=EfCore;Integrated Security=True;trustservercertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```
## Explanation of Command Parameters

### Connection String:
- **Server=KDJ-LAPTOP\SQLEXPRESS:** Specifies the local SQL Server instance name.  
- **Database=EfCore:** The target database to scaffold.  
- **Integrated Security=True:** Uses Windows Authentication for connecting to the database.  
- **trustservercertificate=True:** Trusts the SQL Server SSL certificate, useful for local development or self-signed certificates.

### Provider:
`Microsoft.EntityFrameworkCore.SqlServer`  
Indicates EF Core SQL Server database provider.

### Output Directory:
`-OutputDir Models`  
Specifies that the generated entity classes and DbContext will be placed inside the `Models` folder.

---

## How to Use

### Prerequisites

- Visual Studio or Visual Studio Code installed  
- .NET SDK installed  
- SQL Server running locally or accessible remotely  
- A database named **EfCore** already created and containing tables  
- EF Core tools installed (via NuGet packages or CLI tools)  

### Scaffolding Steps

1. Open **Package Manager Console** in Visual Studio:  
   `Tools` → `NuGet Package Manager` → `Package Manager Console`

2. Run the scaffold command:

```powershell
Scaffold-DbContext "Server=KDJ-LAPTOP\SQLEXPRESS;Database=EfCore;Integrated Security=True;trustservercertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

```
3.After running, EF Core will generate:

A DbContext class (EfcoreContext.cs by default) representing your database context.

Entity classes for each table in the database inside the Models folder.

4.You can now use these generated classes in your application to query and update the database using EF Core.

Summary
Database-First allows you to generate EF Core models from an existing database schema.

The scaffold command saves time by auto-generating DbContext and entity classes.

You can re-run scaffolding to sync changes made directly to the database.

The generated code enables you to use LINQ queries and EF Core features seamlessly.
