# PercipoBookChapter11

PercipoBookChapter11 is an **ASP.NET Core Razor Pages** sample application developed for learning and demonstrating modern ASP.NET Core concepts.  
The project focuses on **Razor Pages architecture**, **Entity Framework Core**, and working with **multiple DbContexts** (SQL Server + InMemory).

This repository represents a **self-contained chapter** of a larger learning solution and is intentionally isolated for clarity and focus.

---

## 📌 Key Concepts Covered

- Razor Pages page-based architecture
- Razor syntax (`@` transition between HTML and C#)
- Page Models and Page Handlers
- Model Binding with `[BindProperty]`
- Entity Framework Core (Code First)
- SQL Server integration
- EF Core InMemory database
- Multiple DbContext usage in a single application
- Routing and URL generation
- Basic CRUD operations

---

## 🧱 Project Structure

```
PercipoBookChapter11
│
├── Context
│ ├── CustomerDbContext.cs
│ └── CustomerDbForMemoryContext.cs
│
├── Models
│ ├── Customer.cs
│ └── Product.cs
│
├── Pages
│ ├── Customers
│ │ ├── Index.cshtml
│ │ └── Index.cshtml.cs
│ └── Shared
│
├── Program.cs
├── PercipoBookChapter11.csproj
└── README.md
```
---

## ⚙️ Technologies Used

- ASP.NET Core Razor Pages
- Entity Framework Core
- SQL Server (LocalDB)
- EF Core InMemory Provider
- C#

---

## 🗄️ Database Design

This project intentionally uses **two different DbContexts** to demonstrate real-world scenarios.

---

### 1️⃣ SQL Server DbContext (Persistent Data)

```csharp
public class CustomerDbContext : DbContext
{
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
        : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
}
