# 💻 Simulador de Ensamblaje de Computadoras

Este proyecto es una simulación gráfica e interactiva desarrollada en **Unity** con fines académicos. El usuario puede armar una computadora tipo **Desktop** eligiendo componentes internos y externos, validando su ensamblaje paso a paso.

---

## 🧠 Objetivo

Simular el proceso de armado de una PC, reforzando conceptos de compatibilidad, interacción de hardware y control de variables del sistema. El proyecto permite seleccionar, ubicar y validar componentes como CPU, RAM, almacenamiento, GPU, entre otros.

---

## 🚀 Requisitos

- Unity Editor: **2022.3 LTS (Built-in Render Pipeline)**
- IDE recomendado: **JetBrains Rider (2023.1 o superior)** con integración de Unity
- Paquetes de Unity:
  - TextMeshPro (se instala automáticamente al usar UI)
  - Input System (opcional si se extiende a interacción con teclado)
- Sistema operativo: **Windows 10/11**
- Git + GitHub (para control de versiones)
- Target platform: PC (Windows)

---

## 🗂️ Estructura del proyecto

```
/Assets
├── Scenes/
│   ├── MainMenu.unity
│   ├── SelectType.unity
│   └── AssemblyDesktop.unity
├── Prefabs/
│   └── Componentes 3D (CPU, RAM, etc.)
├── Scripts/
│   ├── MainMenuManager.cs
│   ├── SelectTypeManager.cs
│   ├── ComponenteUI.cs
│   ├── ControlVariables.cs
│   ├── ControlComponentes.cs
│   ├── ControlTemperatura.cs
│   └── GlobalState.cs
```

---

## 🧪 Variables de control implementadas

La aplicación maneja variables de control funcionales, evaluadas de forma visual e interactiva:

| Variable                          | Tipo     | Estado          |
|----------------------------------|----------|-----------------|
| 1. Presión aplicada              | Slider   | ✅ Implementada |
| 2. Orientación del componente    | Lógica   | ✅ Implementada |
| 3. Cantidad de componentes       | Contador | ✅ Implementada |
| 6. Tipo de sistema (Desktop)     | Flag     | ✅ Implementada |

---

## 🧩 Funcionalidades clave

- Menú de inicio y selección del tipo de sistema (por ahora solo Desktop)
- Estantería con botones por tipo de componente (CPU, RAM, SSD, GPU)
- Tarjetas visuales con botón "Agregar"
- Evaluación de presión y orientación al colocar componentes
- Contador de piezas agregadas
- Botón “Limpiar Mesa” que reinicia la zona de trabajo

---

## 👥 Autores y créditos

Proyecto académico realizado por el Grupo D para la asignatura **Técnicas de Simulación** – Universidad de El Salvador – 2025.

---

## 📚 Licencia

Uso exclusivo para fines educativos y académicos.
