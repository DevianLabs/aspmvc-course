# Módulo 6
## Depuración y pruebas

-==========-

## Objetivo

El objetivo de este módulo es aprender a aumentar la resistencia y la calidad de una aplicación mediante la localización y corrección de errores de código, bugs, y otros resultados inesperados aplicando técnicas de pruebas unitarias. 

Además, se explicarán las herramientas de depuración y control de excepciones disponibles en Visual Studio.

-==========-

## Temas a tratar

-==========-

## Pruebas unitarias

Una prueba unitaria es una porción de código o programa que tiene como objetivo analizar la funcionalidad y comportamiento de un programa divido en unidades individuales, es decir, analizar unidades de código.

Una prueba unitaria idealmente debe ser automatizables, reutilizables e independientes.

-==========-

## TDD (Test Driven Development)

El desarrollo dirigido por pruebas es una metodología de programación que involucra 2 prácticas: **pruebas unitarias y refactorización.**

-==========-

## Ciclo de TDD

<div class="image">
  <img class="no-border" data-src="../assets/images/slides/tdd-diagram.png"/>
</div>

-==========-

## Ciclo de TDD

1.- Escribir una prueba e intentar compilar, aunque no sea posible dado que no hay funcionalidad aún.

2.- Escribir la mínima cantidad de código posible para que la prueba compile y ejecutarla. Deberá fallar dado que aún no tiene la funcionalidad requerida.

3.- Escribir la prueba, de tal forma, que al ejecutarlo no falle. La funcionalidad escrita no deberá ser lo más elegante/óptimo, simplemente debe permiter pasar el test.

4.- Refactorizar el código de la funcionalidad para que sea lo más óptimo posible. Esta refactorización puede estar presente en diferentes etapas del proyecto.

-==========-

## Beneficios de TDD

* Facilita los cambios
* Simplifica la [integración continua](https://www.martinfowler.com/articles/continuousIntegration.html)
* Documenta el código
* Errores más acotados
* Acelera el desarrollo
* Código desacoplado

<p class="annotation"><a href="http://agiledata.org/essays/tdd.html"> TDD - Agile data </a></p>

-==========-

## Pruebas unitarias en .NET

* Built-in Visual Studio testing tools
* [NUnit](https://www.nunit.org/)
* [XUnit](https://xunit.github.io/)