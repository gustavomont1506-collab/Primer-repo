# SOLID Task Manager - Learning Project

Este es un proyecto pequeño diseñado para aprender los principios **SOLID** y practicar el flujo de trabajo en **GitHub**.

## Principios SOLID Aplicados

1.  **S - Single Responsibility (Responsabilidad Única)**:
    - `Task`: Solo representa los datos de una tarea.
    - `InMemoryRepository`: Solo se encarga de cómo se guardan las tareas.
    - `TaskManager`: Solo se encarga de la lógica de negocio.
2.  **O - Open/Closed (Abierto/Cerrado)**:
    - El sistema es abierto a nuevas formas de almacenamiento (bases de datos, archivos) sin modificar el `TaskManager`, gracias a la interfaz `ITaskRepository`.
3.  **L - Liskov Substitution (Sustitución de Liskov)**:
    - Cualquier implementación de `ITaskRepository` puede ser usada indistintamente.
4.  **I - Interface Segregation (Segregación de Interfaz)**:
    - La interfaz `ITaskRepository` es simple y solo tiene los métodos necesarios.
5.  **D - Dependency Inversion (Inversión de Dependencias)**:
    - `TaskManager` no depende de una clase concreta (`InMemoryRepository`), sino de una abstracción (`ITaskRepository`).

## ¿Cómo aprender GitHub con este proyecto?

Para practicar, te sugiero seguir estos pasos:

1.  **Crea una Rama (Branch)**:
    ```bash
    git checkout -b feat/task-delete
    ```
2.  **Modifica el código**: Implementa la función de borrar tareas siguiendo SOLID.
    - Agrega `delete(id: number): void` a la interfaz `ITaskRepository`.
    - Implementa `delete` en `InMemoryRepository`.
    - Agrega un método `removeTask` en `TaskManager`.
3.  **Haz un Commit**:
    ```bash
    git add .
    git commit -m "feat: implementar borrado de tareas"
    ```
4.  **Sube tus cambios**:
    ```bash
    git push origin feat/task-delete
    ```
5.  **Crea un Pull Request** en la web de GitHub y fusiónalo.

## Ejecución

Asegúrate de tener instalado el SDK de .NET. Luego, en la carpeta raíz:

```bash
# Compilar y ejecutar
dotnet run
```

