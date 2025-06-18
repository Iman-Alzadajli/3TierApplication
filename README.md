# 🛒 ShopLayeredMVC – ASP.NET Core MVC Project (3-Tier Architecture)

## 💡 Project Summary

This project is a simple **layered ASP.NET Core MVC application** following the **3-Tier Architecture**:

- 🧱 **DAL (Data Access Layer):** Manages database models and the EF Core database context.
- 🧠 **BLL (Business Logic Layer):** Contains business logic, generic repository interfaces, and their implementations.
- 🎨 **Presentation Layer (MVC):** Handles the user interface, controllers, and views using ASP.NET Core MVC.

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
- `Microsoft.EntityFrameworkCore.Tools` 🛠️: Tools to run migrations and update database.

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
