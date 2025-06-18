# 🛒 PAL.Shop – Simple MVC Project with Identity User

Hi there! 👋 This is a basic ASP.NET Core MVC project where we worked on the **Presentation Layer (PAL)** and focused on **Authentication** using `IdentityUser` from .NET Core.

---

## 📁 What We Worked On (PAL Layer)

We mainly worked on the **Presentation Layer**, which is where we manage:

- Controllers (C# logic for each page)
- Views (HTML pages using Razor)
- ViewModels (to carry user input data)

---

## 📦 NuGet Packages We Installed & Why

- `Microsoft.EntityFrameworkCore.Tools`  
  → Helps run Migrations and update the database

---

## 🎮 Controllers We Added

- `AuthController`  
  → Handles **Register** and **Login** functionality using `UserManager` and `SignInManager`.

- `XShopController`  
  → Temporary page after login success, just to test redirection.

---

## 🖼️ Views We Created

We created a total of **4 views** inside the `Views/Auth` folder:

- `Register.cshtml` → User registration form
- `Login.cshtml` → User login form  
- Both use **Bootstrap** and simple validation ✨

Also:

- `XShop/Index.cshtml` → Just a placeholder for the landing page after login.
- We updated `Home/Index.cshtml` with a welcome message and info about the tech used.

---

## 🔐 What We Did With Identity

- We used **ASP.NET Core Identity** with `ApplicationUser` inherited from `IdentityUser`.
- This gives us:
  - Secure registration ✅  
  - Password hashing ✅  
  - Login with cookie-based authentication ✅  
  - Ability to extend user fields like `Name`, `PhoneNumber`, etc.

---

## 📦 Classes and ViewModels We Created

- `RegisterViewModel` → For handling registration inputs
- `LoginViewModel` → For handling login inputs
---

