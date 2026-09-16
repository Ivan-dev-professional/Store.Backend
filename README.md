# Store.Backend — E-Commerce Web API Core

A high-performance ASP.NET Core Web API demonstrating **Clean Architecture**, **CQRS pattern** via MediatR, and modern C# 12 features.

## 🚀 Architectural Highlights

- **Clean Architecture & Separation of Concerns**: Decoupled presentation layer keeping Controllers lightweight.
- **CQRS Pattern with MediatR**: Complete segregation of Read (Queries) and Write (Commands) operations.
- **C# 12 Primary Constructors**: Clean, concise dependency injection.
- **RESTful API Standards**: Explicit routing, HTTP verbs, and status codes across Product, Order, and Basket domains.

## 🛠 Tech Stack

- **Framework**: .NET 10 / ASP.NET Core
- **Pattern**: CQRS, Clean Architecture
- **Library**: MediatR
- **Language**: C# 12

## 📁 Project Structure

```text
Store.Backend/
├── Controllers/
│   ├── BasketController.cs   # Cart management
│   ├── OrdersController.cs   # Order placement and flow
│   └── ProductsController.cs # Catalog queries and admin actions
└── Contracts.cs             # CQRS Commands & Queries definitions