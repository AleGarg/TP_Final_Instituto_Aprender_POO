🎓 Proyecto Final: Instituto Educativo "Aprender+"
Este repositorio contiene la implementación del sistema de gestión para el Instituto Educativo "Aprender+", una aplicación desarrollada utilizando Programación Orientada a Objetos (POO) en C#.

El sistema permite la administración completa de cursos, inscripciones de alumnos, bajas, registro de calificaciones y generación de diversos listados e informes académicos.

🏗️ Arquitectura del Sistema (Clases Principales)
El diseño se basa en un conjunto de clases interconectadas que modelan las entidades del instituto, siguiendo los principios de la Programación Orientada a Objetos:

| Clase              | Atributos Clave (Propiedades)                                                   | Métodos Clave (Funcionalidad)                                                        | Relación                                                          |
| ------------------ | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------ | ----------------------------------------------------------------- |
| Persona            | nombre (string), apellido (string), dni (int)                                   | (Clase base)                                                                         | Herencia para Alumno y Docente.                                   |
| Alumno             | legajo (int), nota (double)                                                     | (Hereda de Persona)                                                                  | Agregado en Curso e Instituto.                                    |
| Docente            | sueldo (double)                                                                 | (Hereda de Persona)                                                                  | Agregado a Curso.                                                 |
| Curso              | nombre (string), docente (Docente), cupoMaximo (int), inscriptos (List<Alumno>) | agregarAlumno(), eliminarAlumno(), registrarNota(), promedio(), cantInscriptos()     | El Instituto gestiona una lista de Cursos.                        |
| Instituto          | nombre (string), listaCursos (List<Curso>), listaAlumnos (List<Alumno>)         | cargarJson(), guardarJson(), inscribirAlumno(), eliminarAlumno(), transferirAlumno() | Clase controladora que maneja la lógica de negocio y colecciones. |
| CupoLlenoException | mensaje (string)                                                                | (Excepción personalizada)                                                            | Se lanza al exceder la capacidad de un curso.                     |

⚙️ Funcionalidades del Sistema
La aplicación principal se ejecuta a través de un menú de opciones  que permite acceder a las siguientes funcionalidades:

1. Gestión de Inscripciones y Alumnos
| Opción                       | Descripción                                                                                           | Validación Clave                                                                             |
| ---------------------------- | ----------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| Inscribir alumno en un curso | Permite registrar un nuevo alumno en el instituto si no existe, e inscribirlo en un curso específico. | Lanza CupoLlenoException si el curso excede su cupo.                                         |
| Eliminar alumno de un curso  | Remueve la inscripción de un alumno de un curso.                                                      | Si el alumno ya no cursa en ningún otro curso, se da de baja automáticamente del instituto.  |
| Transferir alumno            | Mueve un alumno de un curso origen a un curso destino.                                                | Valida la existencia del alumno en el curso origen y el cupo disponible en el curso destino. |

2. Gestión Académica y Calificaciones
| Opción                    | Descripción                                                             |
| ------------------------- | ----------------------------------------------------------------------- |
| Registrar nota de examen  | Permite asignar una calificación a un alumno para un curso específico.  |
| Promedio general de notas | Muestra el promedio general de las notas para cada curso del instituto. |

3. Listados e Informes
| Opción                     | Descripción del Reporte                                                                     |
| -------------------------- | ------------------------------------------------------------------------------------------- |
| Listar alumnos de un curso | Muestra el nombre, DNI y la nota (si está registrada) de cada alumno inscripto en un curso. |
| Listar cursos              | Detalla cada curso, su docente responsable y la cantidad de inscriptos actuales.            |
| Listar alumnos multi-curso | Identifica y lista a los alumnos que se encuentran inscriptos en más de un curso.           |

4. Persistencia de Datos
El sistema está diseñado para guardar y cargar el estado completo del instituto, incluyendo alumnos, cursos e inscripciones.

Guardar/Cargar Datos: Implementa la funcionalidad para persistir los datos completos del instituto. La información puede guardarse en archivos de texto o, preferiblemente, utilizando el formato JSON para facilitar la serialización y deserialización de objetos complejos.

🚀 Implementación en C#
La implementación en C# debe utilizar las capacidades del lenguaje para:
Colecciones Genéricas: Usar List<T> (ej: List<Curso>, List<Alumno>) para gestionar dinámicamente las entidades.
Excepciones Personalizadas: Implementar y lanzar CupoLlenoException para manejar el flujo de control ante una inscripción no válida.
Serialización JSON: Utilizar librerías como System.Text.Json o Newtonsoft.Json para los métodos de guardarJson() y cargarJson().
