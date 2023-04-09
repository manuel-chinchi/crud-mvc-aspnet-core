# Crud MVC

 Sistema b�sico con operaciones CRUD hecho en MVC .Net Core 3.1 y Entity Framework.

## �De qu� trata esta aplicaci�n?

Este proyecto consiste en un peque�o sistema de inventario con una base de datos 
lista para usar y l�gica de negocio m�nima. 
Todos los componentes usados en mayor o menos medida se listan a continuaci�n

  - [Entity Framework Core 3.1.0](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/3.1.0) (back-end)
  - [datatables 1.13.3](https://datatables.net/) (front-end)
  - [FluentValidation.AspNetCore 11.0.0](https://www.nuget.org/packages/FluentValidation.AspNetCore/11.0.0) (back-end/front-end)

## �C�mo pruebo esto?

Para poder ejecutar la aplicaci�n se necesita tener previamente instalado los siquientes 
programas

  - [SQL Server Express LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16)
  - IIS Express 10
  - [Net Core 3.1 runtime](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)

## Modelo de datos

El modelo de datos de la aplicaci�n cuenta con 2 entidades, Art�culo y Categor�a. Puede ver la relaci�n 
entre estas en el archivo (.edmx) dentro de la aplicaci�n. Aqu� la representaci�n gr�fica del mismo

![Diagrama](Images/png/)
  
## Capturas

- Animaci�n de una operaci�n agregar/editar/eliminar art�culo.  

  ![](Images/gif/article_crud_operation.gif)

- Pagina de lista de art�culos.  

  ![](Images/png/articles-list_details-responsive.png)

- P�gina de detalles de un art�culo.  

  ![](Images/png/article-details.png)
