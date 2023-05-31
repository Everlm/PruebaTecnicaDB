## Overview

Desarrollar un sistema web con una interfaz de usuario que permite ingresar, modificar y eliminar usuarios. La capa de negocios se encarga de la lógica de negocio y se comunica con la capa de datos que interactúa con la base de datos. Se deben implementar los métodos necesarios para realizar estas operaciones y utilizar un procedimiento almacenado para ejecutar las operaciones en la base de datos.

A continuación, encontraras el paso a paso de la prueba que necesitamos que ejecutes para la respectiva evaluación del proceso de selección:

Prueba de  conocimientos
Elabore un sistema de arquitectura con capas con las siguientes características:
Capa presentación – Proyecto WEB
• Primera página
Pagina llamada usuario
Campo nombre - Caja de texto
Campo fecha de nacimiento -Tipo calendario
Campo sexo -DropDownlist
• Segunda pagina
Pagina llamada usuario consulta
Debe mostrar en una grilla de consulta, de usuarios insertados, en la grilla para cada consulta insertada, debe existir la opción de modificar y eliminar el usuario
Capa de negocios – Servicio WCF
• Debe crear los siguientes métodos
Agregar
Modificar
Consultar
Eliminar
Debe efectuar la conexión a la base de datos desde esta capa

Capa de datos
• Tendrá una tabla con las siguientes especificaciones
Nombre-tipo texto longitud 100
Fecha de nacimiento-tipo fecha
Sexo- tipo texto fijo longitud 1
Debe crear un procedimiento almacenado donde haga el proceso CRUD para la tabla creada anteriormente.

## Technologies

* [N-Layer Architecture](https://medium.com/design-microservices-architecture-with-patterns/layered-n-layer-architecture-e15ffdb7fa42)
* [Repository Patterns](https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
* [ASP.NET MVC 5](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/)
* [ADO .NET](https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/ado-net-overview)
* [SQL Server](https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16)
* [Stored Procedures](https://learn.microsoft.com/en-us/sql/relational-databases/stored-procedures/stored-procedures-database-engine?view=sql-server-ver16)
* [WCF](https://learn.microsoft.com/es-es/dotnet/framework/wcf/whats-wcf)
* [AutoMapper](https://automapper.org/)
