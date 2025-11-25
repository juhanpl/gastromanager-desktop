# GastroManager

**GastroManager** es una aplicación de escritorio que permite gestionar platos, recetas e ingredientes. Incluye filtros por categoría, nombre, precio y disponibilidad, facilitando la administración del menú de un restaurante o proyecto culinario.

---

## Características principales

- Gestión de platos, recetas e ingredientes  
- Filtros avanzados  
- Visualización detallada de cada plato  
- Administración eficiente del menú  

---

## ️ Tecnologías utilizadas

- **C#**
- **SQL Server**
- Aplicación de escritorio (.NET)

---

## Estructura del proyecto

```text
GastroManager/
│
├── Data/              # Acceso a datos y conexión SQL
├── DTOs/              # Objetos de transferencia de datos
├── Interfaces/        # Interfaces de repositorios
├── Logic/             # Lógica de negocio
├── Models/            # Modelos de base de datos
├── UI/                # Formularios principales
├── UserControls/      # Controles de usuario reutilizables
├── Source/            # Imágenes utilizadas en la aplicación
├── Program.cs         # Punto de entrada
└── GastroManager.csproj
```

## Instalación

1. Clona este repositorio:
   ```bash
   git clone https://github.com/juhanpl/GastroManager.git
   ```
2. Ejecuta el script de la base de datos denominado "DishManagmnentDB_Script" en SQL Server
3. Abre el proyecto en tu IDE favorito para C# (por ejemplo, Visual Studio).
4. Restaura los paquetes y dependencias necesarios.
5. Ejecuta la aplicación.

## Uso

- Utiliza los filtros para encontrar platos o ingredientes fácilmente.
- Visualiza detalles de recetas e ingredientes.
- Administra el menú según la disponibilidad y otras características.

## Autor

- [juhanpl](https://github.com/juhanpl)

## Licencia

Este proyecto actualmente no tiene una licencia especificada.