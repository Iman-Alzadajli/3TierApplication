# 🧠 BLL – Business Logic Layer (Branch2)

This `README.md` documents the **Business Logic Layer (BLL)** of the project in **Branch2**.  
The BLL acts as the middle layer between the **Data Access Layer (DAL)** and the **Presentation Layer (MVC)**, handling business rules and logic.

---

## 💡 Purpose of the BLL

- Encapsulates all business logic and rules of the application.
- Connects the database layer (DAL) with the UI layer (MVC).
- Promotes a clean, testable, and maintainable architecture.
- Allows services and repositories to be reused or extended easily.

---

## 📁 Folder Structure in BLL

BLL/
│
├── Interfaces/
│ └── IGenericRepository.cs
│
└── Repositories/
└── GenericRepository.cs


---

## 🔌 Interfaces

### 📂 Interfaces/

This folder contains **interfaces** that define contracts for the repositories.

#### 📄 IGenericRepository.cs

Defines basic CRUD operations that any repository should implement:

- `GetAll()`
- `GetById(id)`
- `Add(entity)`
- `Update(entity)`
- `Delete(id)`

✅ **Benefits of using interfaces:**

- Decouples code from concrete implementations.
- Enables easier testing by mocking dependencies.
- Improves flexibility and maintainability.

---

## 🏭 Repositories

### 📂 Repositories/

This folder contains **concrete classes** that implement the interfaces using EF Core and `ApplicationDbContext`.

#### 📄 GenericRepository.cs

This class implements `IGenericRepository<T>` and performs database operations using Entity Framework Core.

It provides actual logic for:

- Retrieving data from the database.
- Adding, updating, and deleting entities.
- Accessing `DbSet<T>` via the context.

✅ **Benefits of repositories:**

- Centralizes data access logic.
- Avoids code duplication across controllers.
- Makes unit testing easier by abstracting EF Core.

---

## 🔗 Layer References

- The **Repositories** in BLL depend on `ApplicationDbContext` from the **DAL**.
- The **Presentation Layer (MVC)** uses **Interfaces** from BLL via Dependency Injection.


