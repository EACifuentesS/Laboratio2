# Proyecto de Administración Hotelera

Este proyecto tiene como objetivo desarrollar un sistema para gestionar las operaciones de un hotel, incluyendo la administración de habitaciones, salones de convenciones, reservaciones y clientes. El sistema está diseñado con arquitectura en N capas y se utiliza ASP.NET para el desarrollo de la interfaz web y SQL Server para la base de datos.

## Funcionalidades del Sistema

### 1. Gestión de Habitaciones
- El hotel tiene 100 habitaciones divididas en:
  - **70 habitaciones simples** con un costo de USD12 por noche y una capacidad máxima de 2 adultos.
  - **30 habitaciones dobles** con un costo de USD20 por noche y capacidad máxima de 4 adultos y 2 niños.
  
- El sistema permite:
  - Ver habitaciones disponibles por tipo y fechas.
  - Reservar habitaciones para los clientes de acuerdo a la cantidad de adultos y niños.
  - Cambiar reservaciones, con un recargo del 10% si se modifica la fecha de reservación.
  - Realizar check-in y check-out de las habitaciones.

### 2. Gestión de Salones de Convenciones
- El hotel cuenta con dos salones:
  - **Salón Luna** con capacidad para 100 personas.
  - **Salón Sol** con capacidad para 300 personas.
  
- El sistema permite reservar los salones y gestionar su disponibilidad.

### 3. Reservaciones
- Los clientes pueden hacer reservaciones para habitaciones o salones.
- El sistema calcula el costo total de la reservación basado en el tipo de habitación o salón y la cantidad de noches o días reservados.
- El sistema permite cambiar una reservación existente con recargo si se modifica la fecha de inicio o fin.

### 4. Clientes Frecuentes
- Se lleva un registro de todos los clientes y las reservaciones que realizan.
- Los clientes que alcancen un número determinado de reservaciones se les otorga una **insignia de cliente frecuente**.

### 5. Visualización de Calendarios
- El sistema tiene una funcionalidad de calendario para visualizar las habitaciones y salones reservados, en uso o disponibles por fechas.
- Los usuarios pueden hacer reservaciones directamente desde el calendario.

### 6. Reportes
El sistema genera los siguientes reportes:
- **Habitaciones reservadas** por tipo y fecha específica o por mes.
- **Habitaciones en uso** por tipo y fecha específica o por mes.
- **Habitaciones libres** por tipo y fecha específica o por mes.
- **Horarios de salones** reservados o libres por mes.
- **Listado de clientes** con la cantidad de reservaciones que han realizado.
- **Top 3 clientes** con más reservaciones.

## Estructura del Proyecto

El proyecto sigue una arquitectura en N capas para facilitar la escalabilidad y el mantenimiento. Las principales capas son:

- **Capa de presentación (UI)**: Interfaz web desarrollada con Razor Pages en ASP.NET.
- **Capa de negocio (BLL)**: Contiene la lógica del negocio relacionada con la administración de habitaciones, salones, reservaciones y clientes.
- **Capa de acceso a datos (DAL)**: Maneja las interacciones con la base de datos SQL Server utilizando Entity Framework o consultas directas SQL.
- **Modelos (Models)**: Define las entidades y clases que representan las habitaciones, salones, clientes, y reservaciones.

## Requisitos del Sistema

- **Lenguaje**: C#
- **Framework**: ASP.NET Core
- **Base de Datos**: SQL Server
- **Herramientas**:
  - Visual Studio
  - SQL Server Management Studio

## Uso del Sistema

- Acceder a la aplicación web para ver las habitaciones, salones y realizar reservaciones.
- Utilizar las opciones del calendario para visualizar el estado de las habitaciones y salones por fechas.
- Generar reportes desde el panel de administración.
