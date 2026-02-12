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
```
## 🚀 Ejecución del Proyecto

Sigue estos pasos para poner en marcha la API en tu entorno local:

### 1. Base de Datos
* Ejecutar el script SQL ubicado en `/Database/script.sql`.
* Asegurarse de que la base de datos `BibliotecaDb` se haya creado correctamente.

### 2. Configuración
* Validar la cadena de conexión (**Connection String**) en el archivo `appsettings.json` del proyecto **Biblioteca.API**.

### 3. Lanzamiento
* Establecer **Biblioteca.API** como proyecto de inicio.
* Ejecutar mediante Visual Studio (F5) o usando el comando `dotnet run` desde la terminal.

### 4. Pruebas
* Acceder a la interfaz de **Swagger** desde el navegador para interactuar con los endpoints:
    > `https://localhost:{puerto}/swagger`

---

## ✅ Características Implementadas

- [x] **Separación de responsabilidades:** Arquitectura limpia y organizada.
- [x] **Inyección de Dependencias:** Uso del contenedor nativo de .NET.
- [x] **Manejo de excepciones personalizado:** Respuestas claras ante errores.
- [x] **Mapeo de datos (DTOs):** Uso de objetos de transferencia para proteger las entidades.
