# Analizador-Lexico-Basico-2024

Aplicacion de escritorio desarrollada en C# (.NET Framework 4.7.2) con Windows Forms para el analisis lexico de codigo fuente.

## Descripcion

Este proyecto permite cargar, editar y analizar fragmentos de codigo en lenguajes como C#, Java, C y C++. Cuenta con un motor de tokenizacion que identifica palabras reservadas, operadores, delimitadores y variables, generando una tabla detallada con la posicion y clasificacion de cada elemento en el codigo.

## Caracteristicas principales

- Editor de codigo integrado para abrir, editar y guardar archivos de texto/fuente.
- Analisis lexico linea por linea con identificacion de tokens y variables.
- Modulo de diccionario configurable con capacidad de importar y exportar en CSV.
- Exportacion de tablas de resultados a PDF (mediante iTextSharp) y CSV.

## Requisitos

- Windows 10/11
- .NET Framework 4.7.2 o superior
- Visual Studio 2019, 2022 o herramientas de compilacion de MSBuild

## Ejecucion

1. Abrir la solucion `Analizador-Lexico-Basico-2024.sln` en Visual Studio.
2. Compilar el proyecto en modo Debug o Release.
3. Iniciar la aplicacion (F5 o Ctrl + F5).
