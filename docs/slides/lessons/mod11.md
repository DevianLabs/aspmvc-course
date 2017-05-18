# Módulo 11
## Manejo de solicitudes

-==========-

## Objetivo

El objetivo de este módulo es describir cómo construir componentes que capturen las solicitudes del cliente antes de que sean recibidos por los controladores de ASP.NET MVC. Estos componentes incluyen módulos HTTP, controladores y web sockets Web.

-==========-

## Temas a tratar

* Filtros
* ASP.NET Identity
* Web Sockets

-==========-

## ASP.NET Identity

ASP.NET Identity provee un conjunto de clases y configuraciones para el manejo de credenciales. Identity reemplaza las versiones previas de ASP.NET que cubrían estas capacidades: ASP.NET Membership. 

-==========-

## Filtros

Los controladores son métodos de acción que el cliente puede "invocar" en base a la demanda del usuario. Sin embargo, en ocasiones, requerimos algún mecanismo que sea invocado antes o después de que un controlador sea ejecutado. 

.NET provee los filtros para solventar estas situaciones.

-==========-

## Tipos de filtros en .NET

* Filtros de autorización: Implementan `IAuthorizationFilter` para la toma de decisiones relacionadas con la seguridad acerca de cuando se puede o no ejecutar un método.
* Filtros de acción: Implementa  `IActionFilter` con la finalidad de "envolver" un método.
* Filtros de resultado: Estos implementan `IResultFilter` para "envolver" un objeto `ActionResult`.
* Filtros de excepción: Estos implementan `IExceptionFilter` y se ejecutan si existe una excepción no controlada.

-==========-

## Aplicaciones en tiempo real

Para el desarrollo de aplicaciones en tiempo real, existen diversos enfoques:

* Polling constante vía XHR (AJAX o XML Http Request (XHR))
* Long Polling: El servidor mantiene una petición HTTP hasta que hay información disponible para retornar al cliente
* [Protocolo Websocket](https://developer.mozilla.org/en-US/docs/Web/API/WebSockets_API/Writing_WebSocket_servers)

-==========-

## Web Sockets

En .NET existen diferentes tipos de implementaciones para el uso de web sockets:

* System.NET.WebSocket
* SignalR

-==========-

## SignalR

* Conexión persistente de cliente y servidor vía HTTP
* Facil construcción de conexión multi-usuario
* Transporte con auto-negociación