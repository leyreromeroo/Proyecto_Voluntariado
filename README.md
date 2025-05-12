# Proyecto Voluntariado – Programación 3ª Evaluación (Curso 2024–2025)

## ✨ Desarrollado por:
**Leyre Romero**, **Markel Alvarado** y **Javier Renzulli**

---

## 📌 Descripción

Este proyecto tiene como objetivo el desarrollo de una aplicación informática para la **gestión de acciones de voluntariado** realizadas en el centro educativo Cuatrovientos, como parte de la asignatura de Programación en 1º DAM.

La aplicación permite registrar, consultar, modificar y eliminar acciones de voluntariado, así como gestionar su relación con **ODS (Objetivos de Desarrollo Sostenible)**, organizaciones participantes y personas voluntarias.

---

## 🧠 Funcionalidades principales

- ✅ **Añadir una acción** con múltiples ODS, organizaciones y voluntarios
- 🔍 **Consultar información completa** de una acción por su identificador único
- ✏️ **Modificar la descripción** de una acción existente
- ❌ **Eliminar una acción** por su identificador
- 📆 **Consultar acciones por curso académico**
- 🌍 **Consultar acciones por curso académico y ODS**
- 🎓 **Consultar acciones por curso académico y grupo**

---

## 🗃️ Estructura de la base de datos

El proyecto incluye una **base de datos relacional** que contiene tablas como:

- `acciones`
- `organizaciones`
- `voluntarios`
- `ods`
- Tablas intermedias para gestionar relaciones **N:N** (acciones-ods, acciones-voluntarios, etc.)

Además, se han desarrollado **procedimientos almacenados** para automatizar ciertas operaciones complejas.

---

## 💻 Tecnologías utilizadas

- **Lenguaje:** C# (.NET Framework / Windows Forms)
- **Base de datos:** SQL Server
- **Control de versiones:** Git + GitHub

---

## 🚀 Cómo usar el proyecto

1. **Clona este repositorio**
   ```bash
   git clone https://github.com/leyreromeroo/Proyecto_Voluntariado.git
