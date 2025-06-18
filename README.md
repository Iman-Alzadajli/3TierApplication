# 🛒 ShopMVC – ASP.NET Core MVC Project (3-Tier Architecture)

## 💡 Project Summary

This project is a simple **layered ASP.NET Core MVC application** following the **3-Tier Architecture**:

- 🧱 **DAL (Data Access Layer):** Manages database models and the EF Core database context.
- 🧠 **BLL (Business Logic Layer):** Contains business logic, generic repository interfaces, and their implementations.
- 🎨 **Presentation Layer (MVC):** Handles the user interface, controllers, and views using ASP.NET Core MVC.

---

## 🔄 Layered References – How Layers Interact

This project follows a strict 3-Tier Architecture, ensuring clear separation of concerns and minimizing tight coupling between components.

### 🔗 Reference Structure:

| Layer                         | Depends On                  | Description                                                                 |
|------------------------------|-----------------------------|-----------------------------------------------------------------------------|
| 🎨 Presentation Layer (MVC)  | 🧠 BLL (Business Logic Layer) | Uses services and repositories from BLL via Dependency Injection.           |
| 🧠 Business Logic Layer (BLL) | 🧱 DAL (Data Access Layer)     | Uses models and `ApplicationDbContext` from DAL to apply business logic.    |
| 🧱 Data Access Layer (DAL)    | ❌ None                        | The lowest layer. It does not reference any other layer.                    |

### 🧠 Why this matters:

- The **Presentation Layer** should not access the database directly – it only communicates with BLL.
- The **BLL** contains all the logic and rules, and interacts with data through DAL.
- The **DAL** is isolated – it only holds models and context to access the database.

This layered reference system helps in writing testable, scalable, and clean applications.

---

The application models two entities:

- 📂 `Category`
- 📦 `Product`

This structure helps keep code clean, maintainable, and scalable.

---

## 📂 Project Structure and Explanation

### 1. 🧱 DAL – Data Access Layer

The **DAL** folder contains:

- 📜 **Database models (entities):** Classes representing tables (`Category`, `Product`, and `BaseModel` as a base class).
- 🗄️ **ApplicationDbContext:** The EF Core database context class that manages database connection and entities.

#### 📦 Installed NuGet Packages in DAL:

- `Microsoft.EntityFrameworkCore` ⚙️: Core Entity Framework functionality.
- `Microsoft.EntityFrameworkCore.SqlServer` 🖥️: SQL Server database provider.

These packages allow EF Core to communicate with SQL Server and manage migrations.

#### 🗂️ Main files in DAL:

| 📄 File                     | 📝 Description                                           |
|----------------------------|---------------------------------------------------------|
| `BaseModel.cs`             | 🏗️ Base entity with a common `Id` property (primary key). |
| `Category.cs`              | 🗃️ Represents a category, contains `Name` and list of `Products`. |
| `Product.cs`               | 📦 Represents a product with `Name`, `Price`, and foreign key `CategoryId`. |
| `ApplicationDbContext.cs`  | 🗄️ Inherits from `DbContext` and holds `DbSet<Category>` and `DbSet<Product>`. Connects models to the database. |

**Example of `ApplicationDbContext`:**

```csharp
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
```

# 🧠 BLL – Business Logic Layer

## Overview

The **BLL (Business Logic Layer)** is responsible for encapsulating the core business rules and logic of the application. It acts as a middle layer between the data access (DAL) and the presentation layers, ensuring that business rules are consistently applied.

---

## 📂 Folder Structure and Responsibilities

### Folder: `BLL`

This folder contains:

- 🧾 **Interfaces:** Define contracts for repositories and business operations.
- 🏭 **Repositories:** Concrete implementations of those interfaces using EF Core through `ApplicationDbContext`.

---

## 📦 NuGet Packages Used in BLL

- No additional packages are usually required here.

---

# 🎨 Presentation Layer (MVC)

## Overview

The **Presentation Layer** (sometimes called PAL) contains the user interface components:

- ASP.NET Core MVC Controllers handle HTTP requests and responses.
- Razor Views render HTML pages dynamically.
- Optionally, ViewModels to shape data between controllers and views.

This layer uses the MVC pattern and leverages Dependency Injection to access the BLL repositories.

---

## 📂 Folder Structure and Responsibilities

### Typical folders:

| Folder           | Description                              |
|------------------|----------------------------------------|
| `Controllers`    | Contains MVC controllers.               |
| `Views`          | Contains Razor view files (`.cshtml`). |
| `ViewModels`     | (Optional) classes for UI data shaping. |

---

## 📋 Key Points and Files

- **Controllers:**  
  Receive requests, call BLL repositories to get data or perform operations, then pass data to Views.

- **Views:**  
  Use Razor syntax to dynamically generate HTML using model data.

- **ViewModels:**  
  Not mandatory, but recommended for cleaner separation between domain models and UI.

---

## 🛠️ NuGet Packages Used

--- Microsoft.EntityFrameworkCore.Tools 🛠️: t must be installed in the **startup project** .


---

## 🔧 Program.cs and appsettings.json Adjustments

### In **Program.cs**:

- Register MVC services (`AddControllersWithViews`) so the app can process controllers and views.
- Register `ApplicationDbContext` with the SQL Server connection string from **appsettings.json** to enable database connectivity.
- Register the generic repository and any other BLL services for dependency injection.
- Configure routing for proper URL mapping.

### In **appsettings.json**:

- Add your database connection string under the `ConnectionStrings` section.
- Update server and database names to your local or hosted SQL Server instance.

---

## 🛠 Database Migrations and Updating the Database

- After cloning or pulling the project, open a terminal in the project directory.
- Run `dotnet ef migrations add InitialCreate` to create migration files based on your models.
- Run `dotnet ef database update` to apply migrations and create/update the database schema.
- This process syncs your code models with the physical database.

## 🛠 If You will use this project use update-database only

---

## 🚀 How to Clone and Run

```
git clone https://github.com/your-username/ShopLayeredMVC.git
```
