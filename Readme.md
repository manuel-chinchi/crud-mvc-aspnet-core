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

## Arquitectura de la aplicaci�n

La aplicaci�n cuenta con una estructura tipo MVC (Modelo-Vista-Controlador). Adem�s implementa 
una capa de servicios para el acceso a datos. **Todo esto en un mismo proyecto**. 
Para una vista general, se presenta el diagrama de clases (archivo `ClassDiagram.cd`)

![](Resources/Images/ClassDiagram.png)

## Capturas

Pagina de lista de art�culos.

<!-- ![](Resources/Images/articles-list_details-responsive.png) -->
<p align="center">
  <img src="Resources/Images/articles-list_details-responsive.png" width="650px" height="1236px">
</p>

P�gina de detalles de un art�culo.

<!-- ![](Resources/Images/article-details.png) -->
<p align="center">
  <img src="Resources/Images/article-details.png" width="630px" height="662px">
</p>

Ejemplo de una operaci�n agregar/editar/eliminar art�culo.

<!-- ![](Resources/Video/mov/article_crud_operation.mov) -->
<p align="center">
  <video src="Resources/Video/article_crud_operation2.mov" controls="controls" style="max-width: 730px;">
  </video>
</p>

