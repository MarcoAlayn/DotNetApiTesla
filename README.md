### **Guía para la API de Especificaciones de Modelos Tesla utilizando .NET Core**

Esta API fue creada utilizando la plantilla de **ASP.NET Core Web API** en Visual Studio, y está construida sobre .NET 8. El propósito de esta API es proporcionar un endpoint para obtener todas las especificaciones de los modelos Tesla disponibles.

#### **Estructura del Proyecto**

El proyecto sigue una estructura organizada en capas que separa las responsabilidades de la aplicación, lo que facilita la mantenibilidad y escalabilidad. A continuación, se describen las principales carpetas y archivos del proyecto:

- **Controllers/**
  - **ModelSpecificationsController.cs**: Contiene la lógica para el manejo de las solicitudes HTTP dirigidas al endpoint de especificaciones de modelos Tesla. Este controlador utiliza un servicio para recuperar las especificaciones desde la base de datos.

- **Services/**
  - **ModelSpecificationsService.cs**: Implementa la lógica de negocio para interactuar con la base de datos y obtener las especificaciones de los modelos Tesla. Este servicio se comunica con la base de datos a través de Entity Framework Core, ejecutando procedimientos almacenados para obtener los datos.

- **Interfaces/**
  - **IModelSpecifications.cs**: Define la interfaz para el servicio de especificaciones de modelos, asegurando que cualquier implementación del servicio siga el contrato especificado.

- **Models/**
  - **ModelSpecification.cs**: Define el modelo de datos que representa las especificaciones de un modelo Tesla. Esta clase corresponde a las entidades que se obtienen de la base de datos.
  - **CarSalesDbContext.cs**: Este archivo fue generado mediante scaffolding utilizando Entity Framework Core. Representa el contexto de la base de datos, permitiendo interactuar con las tablas y ejecutar procedimientos almacenados.

#### **Detalles Técnicos**

- **Framework:** ASP.NET Core 8
- **ORM Utilizado:** Entity Framework Core
  - Se utiliza EF Core para realizar el mapeo objeto-relacional y facilitar las operaciones de consulta sobre la base de datos. El contexto de la base de datos (CarSalesDbContext) maneja la conexión y las operaciones con las tablas correspondientes.
  - Las consultas a la base de datos se realizan mediante procedimientos almacenados ejecutados a través de EF Core.

- **DI (Inyección de Dependencias):** 
  - El servicio de especificaciones (ModelSpecificationsService) es inyectado en el controlador utilizando el patrón de inyección de dependencias, lo que facilita la prueba y el mantenimiento del código.

- **Arquitectura:** Basada en la separación de responsabilidades (Controlador, Servicio, Interfaz y Modelo) que sigue el patrón de diseño MVC (Model-View-Controller).

#### **Endpoint Disponible**

1. **Obtener Especificaciones de Modelos Tesla**
   - **Método:** GET
   - **URL:** `https://dotnetapiteslax.azurewebsites.net/ModelSpecifications`
   - **Descripción:** Este endpoint devuelve una lista con las especificaciones de los diferentes modelos Tesla. No se requiere ningún parámetro en el cuerpo de la solicitud (body).
   - **Respuesta:** Un array JSON con las especificaciones de cada modelo Tesla disponible.

#### **Instalación**

Para clonar y ejecutar esta API localmente, sigue los siguientes pasos:

1. **Clona el Repositorio:**
   ```bash
   git clone https://github.com/MarcoAlayn/DotNetApiTesla.git
   ```

2. **Navega al Directorio del Proyecto:**
   ```bash
   cd DotNetApiTesla
   ```

3. **Restaura las Dependencias del Proyecto:**
   ```bash
   dotnet restore
   ```

4. **Configura la Base de Datos:**
   - Asegúrate de tener una base de datos configurada y actualiza la cadena de conexión en el archivo `appsettings.json` si es necesario.

5. **Compila la Aplicación:**
   ```bash
   dotnet build
   ```

6. **Ejecuta la API:**
   ```bash
   dotnet run
   ```

7. **Accede al Endpoint:**
   Abre tu navegador y ve a `https://localhost:5001/ModelSpecifications` para ver las especificaciones de los modelos Tesla.

Puedes acceder al código fuente de la API en este [repositorio de GitHub](https://github.com/MarcoAlayn/DotNetApiTesla).

---

Esta guía proporciona toda la información necesaria para interactuar con la API de especificaciones de modelos Tesla, entender su estructura básica en .NET Core, y configurarla en tu entorno local. La separación en capas del proyecto, el uso de Entity Framework Core, y la inyección de dependencias aseguran que la API sea escalable, fácil de mantener, y flexible para futuras modificaciones o extensiones.