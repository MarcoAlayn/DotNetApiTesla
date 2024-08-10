### **Guía para la API de Especificaciones de Modelos Tesla utilizando .NET Core**

Esta API fue creada utilizando la plantilla de **ASP.NET Core Web API** en Visual Studio, y está construida sobre .NET 8. El propósito de esta API es proporcionar un endpoint para obtener todas las especificaciones de los modelos Tesla disponibles.

#### **Endpoint Disponible**

1. **Obtener Especificaciones de Modelos Tesla**
   - **Método:** GET
   - **URL:** `https://dotnetapiteslax.azurewebsites.net/ModelSpecifications`
   - **Descripción:** Este endpoint devuelve una lista con las especificaciones de los diferentes modelos Tesla. No se requiere ningún parámetro en el cuerpo de la solicitud (body).
   - **Respuesta:** Un array JSON con las especificaciones de cada modelo Tesla disponible.
   
   **Ejemplo de Respuesta:**
   ```json
   [
     {
       "guid": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
       "model": "string",
       "autonomyKm": "string",
       "quarterMile": "string",
       "maximumPowerHp": "string",
       "acceleration0100Kmh": "string",
       "rims": "string",
       "loadCapacityL": "string",
       "weightKg": "string",
       "maximumSpeedKmh": "string",
       "dragCoefficient": "string",
       "propulsionSystem": "string",
       "maxSuperchargerKW": 0,
       "warranty": "string"
     }
   ]
   ```

#### **Estructura del Proyecto**

El proyecto sigue la estructura básica generada por Visual Studio para una API en ASP.NET Core, la cual incluye controladores, modelos y otros archivos esenciales.

- **Controllers/**
  - **ModelSpecificationsController.cs**: Contiene la lógica del endpoint para obtener las especificaciones de los modelos Tesla.
  
- **Models/**
  - **ModelSpecifications.cs**: Define la estructura del modelo que representa las especificaciones de un modelo Tesla.

- **Program.cs**: Configura el middleware y los servicios de la aplicación.

- **appsettings.json**: Archivo de configuración donde se definen parámetros importantes como la conexión a bases de datos o configuraciones de API.

#### **Detalles Adicionales**

- **Framework:** ASP.NET Core 8
- **Plantilla Utilizada:** ASP.NET Core Web API
- **Editor:** Visual Studio

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

4. **Compila la Aplicación:**
   ```bash
   dotnet build
   ```

5. **Ejecuta la API:**
   ```bash
   dotnet run
   ```

6. **Accede al Endpoint:**
   Abre tu navegador y ve a `https://localhost:5001/ModelSpecifications` para ver las especificaciones de los modelos Tesla.

Puedes acceder al código fuente de la API en este [repositorio de GitHub](https://github.com/MarcoAlayn/DotNetApiTesla).

---