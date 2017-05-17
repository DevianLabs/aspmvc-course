# Módulo 2
## Diseño de las aplicaciones web

-==========-

## Objetivo

El objetivo de este módulo presentar el proceso de diseño típico que los arquitectos deben completar la hora de programar una aplicación MVC 4/5, determinado los detalles de la aplicación, tales como la arquitectura general controladores, vistas, modelos y rutas.

-==========-

## Temas a tratar

* Capas de la aplicación
* Acceso a datos
* MVC

-==========-

## Capas de la aplicación

En términos generales, una aplicación se compone de:

* "Pantalla" o conjunto de "pantallas" para mostrar información
* Una forma de mostrar y persistir información conforme se utiliza la aplicación
* Una forma de tomar decisiones de negocio / reglas de negocio

-==========-

## Capas de la aplicación

<div class="image">
  <img class="no-border" data-src="../assets/images/slides/layered-arch.png"/>
</div>

-==========-

## Opciones de acceso a datos

* ORM
* Componentes personalizados de acceso a datos

-==========-

## Acceso a datos / ORM

Un ORM es un sistema que provee una conversión de datos para un modelo de base de datos relacional. El ORM "hidrata" instancias con datos de un almacén y/o crea sentencias de SQL de manera "automática".

Ejemplos de ORM: 
* Entity Framework
* NHibernate
* Linq-to-SQL

-==========-

## Acceso a datos / ADO .NET

En ocasiones, las necesidades de recuperación de datos y persistencia son tan específicas que no pueden ser tratadas como objetos. Para estos escenarios será necesario crear nuestros propios componentes, sentencias/objetos de SQL, etc.

ADO .NET es la librería por defecto para el trabajo con datos dentro del marco de .NET.

-==========-

## Acceso a datos / Separación de responsabilidades

El primer enfoque y patrón de acceso a datos es el patrón Repositorio, el cual es utilizado para crear una abstracción entre la capa de negocio y la capa de datos.

<div class="image">
  <img class="no-border" data-src="../assets/images/slides/repository-pattern.png"/>
</div>

-==========-

## MVC

<div class="image">
  <img class="no-border" data-src="../assets/images/slides/mvc.png"/>
</div>

-==========-

## MVC / Modelos

Los modelos pueden ser diseñados de múltiples formas. Pueden estar presentes en diferentes capas, por ejemplo: Simples modelos en una sola capa, entidades de negocio mapeadas mediante DTO's hacia ViewModels, etc.

-==========-

## MVC / Controladores

Los controladores son quienes manejan las solicitudes enviadas por el cliente. Deben ser parte de la capa de aplicación y pueden implementar operaciones directas con el modelo. 

En ocasiones será conveniente proveer una capa de servicios y repositorios hacia donde enviar las peticiones de acceso a datos.

Por otro lado, deberá especificarse una estrategia de ruteo según se requiera en la aplicación.

-==========-

## MVC / Vistas

Las vistas son representaciones de los modelos de cara al usuario. Se deben considerar los siguientes tipos de vistas:

* Vistas fuertemente tipadas
* Vistas específicas de un modelo
* Vistas parciales
* Vistas Master o Layout

En ASP.NET MVC es posible utilizar diferentes tipos de motores de vistas. Ejemplo: Web forms, razor.