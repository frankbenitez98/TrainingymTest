# TrainingymTest
  ### Tecnologias Usadas:
  Para la creacion de esta prueba se utilizo Asp.Net Core, SQLServer y EntityFrameworkCore, usando como editor de codigo Visual Studio 2022. 
  
  # Instalar
  * Abrir Visual Studio 2022.
  * Clonar repositorio de la siguiente url `https://github.com/frankbenitez98/TrainingymTest.git`
  * Moverse la rama **develop** donde se realizaron todos los ejercicios. 
  * Abrir el NugetPackage Console y actualizar la DB con el comando
  ```bash
Update-Database
```
  * Correr la App.
  
  ### Primeros pasos:
  1. Se creo un nuevo proyecto en Visual Studio 2022 con la arquitectura de Rest Api usando Asp.Net core y C#.
  2. Se instalaron todos paquetes necesarios como EntityFrameworkCore.SqlServer y EntityFrameworkCore.Tools.
  3. Se configuro la ConnectionString en el appsettings.json para poderse conectar a la DB y luego se creo el Application Context.
  4. Se Crearon las respectivas Entidades en la carpeta Models para posteriormente crear nuestras tablas con nuestra primera migracion.
  5. Se creo un repositorio en github donde se subio el proyecto y se separo en la rama `main` y la rama `develop`.
     
  ### Generacion de Script SQL:
  luego de haber creado todas las tablas con sus respectivas relaciones se utilizo el comando 
   ```bash
Script-Migration -Idempotent
```
  para crear el script y este porteriormente se guardo en el archivo **SQLScript.sql** para   para que quede disponible en caso de un uso futuro. 

  ###  Repository Layer:
  Se opto por utilizar la capa de repositorio para separar la logica de las consultas a la base de datos con la del resto del controlador, de esta manera se mantiene un codigo mucho mas escalable haciendo uso de la   inyeccion de dependiencias en nuestra aplicacion. 
  
  ### Llenar la DB: 
  Para este paso se creo un **Seeder** y un endpoint el cual al ejecutarlo verifica si la DB esta vacia y posteriormente procede a llenarla con datos de prueba.
  
  ### Controladores: 
  El uso de controladores nos permite separar la logica en modulos de nuestra aplicacion, optando asi por crear dos controladores, uno para los endpoint relacionados con la DB y otro para el endpoint del ejercicio    de los comentarios. 
 
  ### DTOs: 
  Se realizo el uso de DTOs para mantener un orden en el tipado de la data externa que necesitamos enviar o recibir. 
  
  ### Request a APi externa: 
  Para realizar esta request se instalaron los paquetes RestSharp y Newtonsoft.Json los cuales nos ayudaron a realizar la peticion y a serealizar la respuesta JSON a nuestro DTO. 
