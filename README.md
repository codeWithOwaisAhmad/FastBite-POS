# 🍔 FastBite POS
### Point of Sale System for Fast Food Restaurant

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp)
![SQL Server](https://img.shields.io/badge/SQL_Server-2017-CC2927?style=for-the-badge&logo=microsoftsqlserver)
![Status](https://img.shields.io/badge/Status-Complete-success?style=for-the-badge)

---

## 📋 About The Project

**FastBite POS** is a fully functional Point of Sale desktop application built for a fast food restaurant. It was developed as a semester project for the **Advanced Programming (.NET)** course at **Islamia University of Bahawalpur**.

The application allows restaurant staff to manage the menu, register customers, place orders, and view business analytics through an interactive dashboard — all backed by a **SQL Server** database using **ADO.NET**.

---

## ✨ Features

### Core Features
- 📊 **Dashboard** — Real-time stats and 3 interactive charts
- 🍔 **Menu Management** — Full CRUD for food items with category and status
- 👤 **Customer Management** — Register and manage customer profiles
- 🧾 **Order Management** — Create orders, pick customers, add items, track status

### Bonus Features (All 6 Implemented)
- 🔍 **Search & Filter** — Text search with dropdown filters on every view
- 📈 **Dashboard Charts** — Bar, Pie and Line charts with live database data
- ⚡ **Async Loading** — Non-blocking data load with loading indicator
- 📌 **Status Bar** — Shows current section, record count and last action
- 🔃 **Column Sorting** — Click any column header to sort the grid
- ⏳ **Loading Indicator** — UI disabled during data fetch with visual feedback

---

## 🖥️ Screenshots

### Dashboard
```
┌─────────────────────────────────────────────────────────┐
│  💰 Total Revenue   🧾 Total Orders   🍔 Menu   ⏳ Pending │
│  Rs. 5,940          10                14         1       │
│                                                         │
│  [Bar Chart — Revenue by Category]  [Pie — By Status]  │
│                                                         │
│  [Line Chart — Daily Revenue Last 7 Days]               │
└─────────────────────────────────────────────────────────┘
```

### Navigation
```
┌──────────────┬──────────────────────────────────────────┐
│ 🍔 FastBite  │                                          │
│ POS System   │         Content Area                     │
│              │    (Changes based on nav click)          │
│ 📊 Dashboard │                                          │
│ 🍔 MenuItems │                                          │
│ 👤 Customers │                                          │
│ 🧾 Orders    │                                          │
│──────────────│                                          │
│ Status Bar   │                                          │
└──────────────┴──────────────────────────────────────────┘
```

---

## 🏗️ Project Architecture

```
FastBite-POS (Solution)
│
├── FastBite.Core (Class Library — No UI dependency)
│   ├── Models/
│   │   ├── FoodItem.cs
│   │   ├── Customer.cs
│   │   ├── Order.cs
│   │   └── OrderItem.cs
│   │
│   ├── Contracts/
│   │   ├── IMenuItemService.cs
│   │   ├── ICustomerService.cs
│   │   └── IOrderService.cs
│   │
│   ├── Services/
│   │   ├── DBMenuItemService.cs
│   │   ├── DBCustomerService.cs
│   │   └── DBOrderService.cs
│   │
│   └── Utilities/
│       ├── MenuCategoryEnum.cs
│       ├── MenuItemStatusEnum.cs
│       ├── OrderStatusEnum.cs
│       └── PaymentMethodEnum.cs
│
└── FastBite.App (WinForms Application)
    ├── Forms/
    │   ├── MainForm.cs
    │   ├── MenuItemForm.cs
    │   ├── CustomerForm.cs
    │   ├── OrderForm.cs
    │   └── CustomerPickerForm.cs
    │
    ├── Views/
    │   ├── DashboardView.cs
    │   ├── MenuItemView.cs
    │   ├── CustomerView.cs
    │   └── OrderView.cs
    │
    └── Program.cs
```

---

## 🗄️ Database Schema

**Database:** `FastBitePOS` on SQL Server

```sql
Customers
├── Id           NVARCHAR(20)  PK
├── Name         NVARCHAR(100)
├── Phone        NVARCHAR(20)
├── Email        NVARCHAR(100) NULL
└── Address      NVARCHAR(250) NULL

MenuItems
├── Id           NVARCHAR(20)  PK
├── Name         NVARCHAR(100)
├── Category     NVARCHAR(50)   -- Enum as string
├── Price        DECIMAL(10,2)
└── Status       NVARCHAR(50)   -- Enum as string

Orders
├── Id             NVARCHAR(20)  PK
├── CustomerId     NVARCHAR(20)  FK → Customers
├── CustomerName   NVARCHAR(100)
├── OrderDate      DATETIME
├── Status         NVARCHAR(50)
├── PaymentMethod  NVARCHAR(50)
└── TotalAmount    DECIMAL(10,2)

OrderItems
├── Id             INT           PK IDENTITY
├── OrderId        NVARCHAR(20)  FK → Orders (CASCADE DELETE)
├── MenuItemId     NVARCHAR(20)  FK → MenuItems
├── MenuItemName   NVARCHAR(100)
├── UnitPrice      DECIMAL(10,2)
└── Quantity       INT
```

---

## ⚙️ Design Patterns Used

| Pattern | Where Used |
|---|---|
| **2-Project Architecture** | Core (logic) + App (UI) separation |
| **Interface / Contract** | IMenuItemService, ICustomerService, IOrderService |
| **Constructor Injection** | Services injected into Views via MainForm |
| **Shell + Content Pattern** | MainForm as shell, UserControls as pages |
| **View Caching** | Dictionary<Type, UserControl> in MainForm |
| **Repository Pattern** | DB Services implement interface contracts |
| **DRY Principle** | MapRow() helper in every DB service |
| **Mode-Driven Forms** | Add / Edit / View modes in all forms |

---

## 🛠️ Technologies Used

| Technology | Version | Purpose |
|---|---|---|
| C# | 10.0 | Primary language |
| .NET | 10.0 | Runtime platform |
| WinForms | .NET 10 | Desktop UI framework |
| SQL Server | 2017 | Database |
| ADO.NET | Built-in | Database connectivity |
| System.Windows.Forms.DataVisualization | 1.0.0-prerelease | Charts |
| System.Data.SqlClient | 4.8.6 | SQL connection |

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET 10 SDK
- SQL Server 2017 or later (or LocalDB)
- SQL Server Management Studio (optional)

### Installation

**Step 1 — Clone the repository**
```bash
git clone https://github.com/YourUsername/FastBite-POS.git
cd FastBite-POS
```

**Step 2 — Set up the database**
- Open SQL Server Management Studio
- Connect to your SQL Server instance
- Open `FastBite_DB_Schema.sql`
- Press F5 to execute
- Database `FastBitePOS` will be created with seed data

**Step 3 — Update connection string**

Open `FastBite.App/Forms/MainForm.cs` and update:
```csharp
private readonly string _connStr =
    "Server=YOUR_SERVER_NAME; Database=FastBitePOS;" +
    "Integrated Security=True; TrustServerCertificate=True;";
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name.

**Step 4 — Restore NuGet packages**
```bash
dotnet restore
```

**Step 5 — Build and run**
```bash
dotnet build
dotnet run --project FastBite.App
```

Or press **F5** in Visual Studio.

---

## 👨‍💻 Author

**Owais Ahmad**
- 6th Semester BS Computer Science
- Islamia University of Bahawalpur
- GitHub: [@YourUsername](https://github.com/codeWithOwaisahmad)
- LinkedIn: [Owais Ahmad](https://linkedin.com/in/owais-ahmad-ai)

---

## 📄 Course Information

- **Course:** Advanced Programming (COSC-5136)
- **Semester:** Spring 2026
- **University:** Islamia University of Bahawalpur
- **Project Type:** Semester Project 

---

## 📝 License

This project is for educational purposes as part of the Advanced Programming course at IUB.

---

*Built with ❤️ using C# .NET WinForms and SQL Server*
