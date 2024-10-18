# Proyecto Final - IDS340 e IDS340L

Este es mi proyecto final para las materias **IDS340 e IDS340L**.

---

## Índice  
1. [Introducción](#introducción)  
2. [Módulo de libros](#módulo-de-libros)  
3. [Módulo de usuarios](#módulo-de-usuarios)  
4. [Módulo de reservas](#módulo-de-reservas)  
5. [Consultas y reportes](#consultas-y-reportes)  

---

# Introducción  

Este proyecto ha sido desarrollado en **Windows Forms utilizando C#** y funciona con una **base de datos SQLite**. A continuación, se explican los módulos y funcionalidades principales del programa.

**Nota:**  
Si estás leyendo este archivo debido el `MessageBox` que aparece al presionar el botón de **Reportes**, ve directamente aquí 👉 [Consultas y reportes](#consultas-y-reportes).  

---

# Módulo de Libros 📚  

En el módulo de **libros**, el usuario tiene la posibilidad de:  
- **Agregar** un libro: Se le asigna automáticamente un **ID**.  
- **Eliminar** un libro: Selecciónalo en el `DataGridView` y presiona **Eliminar**.  
- **Editar** un libro: Llena todos los campos, selecciona el libro en el `DataGridView` y presiona **Editar**.  

En caso de errores, el programa notificará al usuario a través de mensajes.

---

# Módulo de Usuarios 🧙  

Este módulo funciona de forma similar al de **libros**. Las funcionalidades son:  
- **Agregar, eliminar y editar** usuarios.  
Los campos para este módulo son:  
- **ID, nombre, apellido, email** y **teléfono**.

---

# Módulo de Reservas  

Este es el módulo más complejo del programa. Tiene los siguientes campos:  
- **ID del usuario**  
- **ID del libro**  
- **Fecha de reserva** (con un `DateTimePicker`)  
- **Fecha de devolución esperada** (con otro `DateTimePicker`)  

### Funcionalidades:  
- **Agregar reserva**  
- **Eliminar reserva**  
- **Registrar devolución**

#### Registrar devolución  
Al seleccionar una reserva en el `DataGridView` y presionar **Registrar devolución**, los datos se copiarán de la tabla **Reserva** a la tabla **HistorialReservas**.  
En esta tabla se mantiene un **registro histórico** de todas las reservas realizadas, incluyendo si el usuario devolvió los libros a tiempo o no.  

**Nota:** En la tabla **HistorialReservas** no se pueden **editar ni eliminar** registros. Sin embargo, puedes buscar reservas por **ID, usuario, libro o fechas** desde el botón **Historial** en el módulo de reservas.

---

# Consultas y Reportes  

## Consultas  
No es necesario actualizar las tablas manualmente, ya que estas se **actualizan automáticamente** cada vez que se agrega, edita o elimina un registro. Por eso, no se incluye un botón de actualización.

## Reportes  
### ¿Por qué no hay reportes en mi programa?  

Visual Studio ya no incluye la opción de reportes de forma predeterminada, pero se puede añadir mediante una **extensión**.  

El motivo por el que **no incluí un reporte** es porque **no logré conectar la base de datos SQLite** al reporte. Los tutoriales que encontré eran para SQL Server, y mi programa utiliza **SQLite**.  

Intenté cargar la base de datos a los **orígenes de datos** del proyecto, pero no pude agregar la variable `connectionString` necesaria para la conexión. A pesar de instalar los paquetes relacionados, no logré solucionar este problema.

---

# ¡Gracias por leer!  

Este ha sido el archivo **README** de mi proyecto final. Si tienes alguna pregunta o comentario, no dudes en contactarme. 😊

---
