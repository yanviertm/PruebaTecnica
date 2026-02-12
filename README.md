# 📚 Biblioteca API – Prueba Técnica .NET

Proyecto desarrollado como prueba técnica para desarrollador **.NET**, enfocado en buenas prácticas, separación de responsabilidades e integridad de datos.

---

## 🛠️ Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 6+
- **Base de datos:** SQL Server
- **ORM:** Entity Framework Core
- **Arquitectura:** Capas (Core / Infrastructure / API)
- **Inyección de dependencias (DI)**

---

## 📂 Estructura del proyecto

```text
Biblioteca
│
├── Biblioteca.Core
│   ├── Entidades
│   ├── DTOs
│   ├── Interfaces
│   └── Excepciones
│
├── Biblioteca.Infrastructure
│   ├── Data
│   │   └── ApplicationDbContext
│   └── Servicios
│
├── Biblioteca.API
│   ├── Controllers
│   └── Program.cs
│
└── Database
    └── script.sql
