Universidad Internacional de las Américas
Escuela de Ingeniería Informática

Información General
Nombre del curso: Tópicos Avanzados de Programación
Nombre del docente: Alejandro Charpentier González
Fecha de entrega: 28/01/2026
Fecha límite en ECAMPUS: 04/02/2026 antes de las 6:00 p.m.
Porcentaje del laboratorio: 5%
Nombre del estudiante: Santiago Solano R
Calificación: (Uso exclusivo del docente)

Competencias por Desarrollar

Desarrollo de un diseño avanzado aplicando las mejores prácticas de Clean Code vistas en clase.
Uso de tecnologías modernas aplicando APIs REST.
Control de versiones utilizando Git.

Descripción del Laboratorio

Usted ha sido contratado para implementar una funcionalidad destinada a una empresa del sector automotriz, la cual desea exponer su inventario de vehículos mediante servicios tecnológicos.
La implementación debe estar desacoplada de la tecnología de exposición, siguiendo los principios revisados en clase.
Estructura de Datos del Vehículo
Cada vehículo debe contener la siguiente información:

Marca:
1 = Tesla
2 = Toyota
3 = BYD
Año: Campo entero
Modelo: Campo tipo string
Doble Tracción: Valor booleano (true o false)

Operaciones Requeridas (CRUD)
Se deben implementar las operaciones CRUD mediante una API REST:

Operación	Descripción
Create (C)	Crear un nuevo vehículo
Read (R)	Leer/Listar vehículos existentes
Update (U)	Actualizar información de un vehículo
Delete (D)	Eliminar un vehículo del inventario

Entregable

Se debe entregar la dirección del repositorio en GitHub.
El profesor debe tener acceso para descargar el código fuente.
De lo contrario, no se podrá evaluar y se asignará una calificación de 0.
No deben existir commits posteriores a la fecha de entrega establecida.
El sistema debe estar en funcionamiento al momento de la evaluación.
Si no corre correctamente, no se podrá probar y se asignará una calificación de 0.
Repositorio Git:

Evaluación (100 puntos)

Criterio	Descripción	Puntaje
Create	Implementa correctamente el método para agregar vehículos (100% funcional)	20%
Read	Permite listar vehículos con formato estructurado (100% funcional)	20%
Update	Actualiza correctamente los datos de un vehículo existente (100% funcional)	20%
Delete	Elimina un vehículo del inventario sin errores (100% funcional)	10%
Desacoplamiento	La lógica de negocio está separada del servicio web	10%
	Implementa la capa DA	2%
	Implementa la capa BL	2%
	Implementa la capa SI	2%
	Implementa la capa Model	2%
	Implementa la capa Test	2%
Uso de estándares REST	Uso correcto de métodos HTTP y códigos de estado	10%
