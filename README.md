# Caso de Estudio: Árboles y Grafos en C#

## Visión General del Proyecto

Este repositorio contiene la solución al "Caso de Estudio: Árboles y Grafos en C#" de la Universidad Americana (UAM).

El objetivo principal es desarrollar un programa en C# para el parque tecnológico "Innovatec". El programa gestiona dos componentes principales:

1. **Jerarquía Organizativa:** Administra la estructura del personal del parque mediante un **Árbol General**.
2. **Rutas Internas:** Modela las conexiones y distancias entre los edificios del parque utilizando un **Grafo Ponderado No Dirigido**.

---

## Implementación y Funcionalidades

El proyecto está dividido en las dos partes principales requeridas por el caso de estudio.

### Parte A: Árbol - Jerarquía Organizativa

Se implementó una estructura de Árbol General para representar la jerarquía de la organización. Esta estructura incluye las siguientes funcionalidades requeridas:

* **Construcción e Inserción:** Métodos para crear y agregar nodos (departamentos, empleados) al árbol.
* **Recorridos:** Implementación de algoritmos de recorrido para navegar la jerarquía.
* **Búsqueda:** Funcionalidad para buscar nodos específicos dentro del árbol.
* **Conteo y Niveles:** Utilidades para contar elementos y determinar los niveles de la estructura.

### Parte B: Grafo - Sistema de Rutas del Parque

Para modelar las rutas entre edificios, se utilizó un Grafo Ponderado y No Dirigido.

* [cite_start**Representación:** Almacena los edificios (vértices) y las rutas/distancias (aristas ponderadas).
* **Gestión de Conexiones:** Funciones para mostrar las adyacencias, conexiones y aristas del grafo.
* **Validación de Conexidad:** Un método para verificar si el grafo está completamente conectado.
* **Cálculo de Rutas:** Implementación de un algoritmo (como Dijkstra o BFS) para calcular la ruta más corta entre dos edificios.

---

## Tecnología Utilizada

* **Lenguaje:** C#. Windows Forms .Net Framework

---

## Autor

* *Hendrix Devadip Aguirre Zamora*
