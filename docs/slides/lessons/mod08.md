# Módulo 8
## Trabajo con Front-End / Javascript

-==========-

## Objetivo

En este módulo se demuestran las técnicas que aumentan la capacidad de respuesta de la aplicación utilizando la biblioteca de scripts jQuery y cómo usarla para llamar a los servicios Web y componentes de interfaz de usuario.

Por otro lado, parte del objetivo de este módulo, es describir cómo las actualizaciones parciales de página utilizando componentes AJAX y el almacenamiento en caché puede optimizar la capacidad de respuesta de una aplicación web.

-==========-

## Temas a tratar

-==========-

## JS

https://github.com/uhub/awesome-javascript

https://github.com/airbnb/javascript

https://vuejs.org/

https://angularjs.org/

https://jquery.com/

https://facebook.github.io/react/

-==========-

## Bundling y Minification

*"Bundling"* y *"minification"* son dos técnicas que pueden utilizarse dentro de ASP.NET para mejorar el rendimiento de las aplicaciones web.

* El proceso de "bundling" consiste en combinar multiples archivos en uno solo.
* El proceso de "minification" es un proceso de combina diferentes tipos de optimización de código de scripts y hojas de estilo donde el resultado son archivos de peso menor. 

-==========-

## Bundling

Reduce el número de peticiones hacia el servidor y que son requeridas para recuperar los recursos web, como lo es una página web completa. Se pueden crear CSS, javascript y otros *"bundles"*. Dicho de otra manera, menos archivos significa menos peticiones HTTP del navegador al servidor.

-==========-

## Minification

```js
AddAltToImg = function (imageTagAndImageID, imageContext) {
  ///<signature>
  ///<summary> Adds an alt tab to the image
  // </summary>
  //<param name="imgElement" type="String">The image selector.</param>
  //<param name="ContextForImage" type="String">The image context.</param>
  ///</signature>
  var imageElement = $(imageTagAndImageID, imageContext);
  imageElement.attr('alt', imageElement.attr('id').replace(/ID/, ''));
}
```

-==========-

Despues del proceso *minification*, la función es reducida a lo siguiente:

```js
AddAltToImg=function(t,a){var r=$(t,a);r.attr("alt",r.attr("id").replace(/ID/,""))};
```

-==========-

Además de eliminar espacios, esapcios en blanco y eliminar los comentarios, los parámetros y nombres de variables son renombrados, por ejemplo:

| Original | Renamed |
|---|---|
| imageTagAndImageID | t |
| imageContext | a |
| imageElement | r |