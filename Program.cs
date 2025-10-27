using System;
using System.Collections.Generic;

namespace InstitutoAprender
{
    class Program
    {
        static void Main(string[] args)
        {

            // PREGUNTAR POR LO DEL DICCIONARIO PARA NOTAS

            Console.WriteLine("======== Comienzo ========");

            Console.WriteLine("¿Desea precargar datos para verificar el funcionamiento del sistema? Escriba SI o NO");
            string precargar = Console.ReadLine();

            // Instituto
            Instituto AprenderMas = new Instituto("Aprender+", new List<Curso>(), new List<Alumno>());

            if (precargar.ToUpper() == "SI")
            {
                // Docentes
                Docente Docente1 = new Docente("Diego", "Luparello", 44226688, 500000);
                Docente Docente2 = new Docente("Viviana", "Canosa", 88559911, 450000);
                Docente Docente3 = new Docente("Ana", "Montana", 77223311, 550000);
                Docente Docente4 = new Docente("Sebastian", "Perdicaro", 66995511, 690000);
                Docente Docente5 = new Docente("Julian", "Álvarez", 42260908, 9000.35);

                // Alumnos
                Alumno alumno1 = new Alumno("Pignata", "Agustin", 2520620, 1001, 9);
                Alumno alumno2 = new Alumno("Alejo", "Brandan", 42568921, 1002, 10);
                Alumno alumno3 = new Alumno("Fabrizio", "Insarrualde", 4552364, 1003, 10);
                Alumno alumno4 = new Alumno("Pepito", "Grillo", 48234652, 1004, 8);
                Alumno alumno5 = new Alumno("David", "Quint", 48220123, 1005, 6);
                Alumno alumno6 = new Alumno("Lautaro", "del Campo", 43453942, 1006, 10);

                // Inscribir alumnos al instituto
                AprenderMas.InscribirAlumno(alumno1);
                AprenderMas.InscribirAlumno(alumno2);
                AprenderMas.InscribirAlumno(alumno3);
                AprenderMas.InscribirAlumno(alumno4);
                AprenderMas.InscribirAlumno(alumno5);
                AprenderMas.InscribirAlumno(alumno6);

                // Crear cursos y asignar alumnos/docentes
                List<Alumno> alumnosProg = new List<Alumno>() { alumno1, alumno2, alumno4 };
                List<Alumno> alumnosMat = new List<Alumno>() { alumno2, alumno3 };
                List<Alumno> alumnosAlg = new List<Alumno>() { alumno1, alumno3, alumno4 };
                List<Alumno> alumnosTaller = new List<Alumno>() { alumno2, alumno3, alumno4 };

                Curso progObjetos = new Curso("Programación con Objetos", Docente1, 5, alumnosProg);
                Curso mat = new Curso("Matemática", Docente2, 20, alumnosMat);
                Curso alg = new Curso("Álgebra", Docente3, 20, alumnosAlg);
                Curso tallerIng = new Curso("Taller de Ingeniería", Docente4, 20, alumnosTaller);

                AprenderMas.AgregarCurso(progObjetos);
                AprenderMas.AgregarCurso(mat);
                AprenderMas.AgregarCurso(alg);
                AprenderMas.AgregarCurso(tallerIng);
            }

            // Menú principal
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("===== TRABAJO FINAL - PROGRAMACIÓN CON OBJETOS =====");
                Console.WriteLine("1. Cargar datos desde archivo JSON");
                Console.WriteLine("2. Guardar datos en archivo JSON");
                Console.WriteLine("3. Inscribir alumno");
                Console.WriteLine("4. Eliminar alumno");
                Console.WriteLine("5. Listar alumnos del instituto");
                Console.WriteLine("6. Mostrar cursos");
                Console.WriteLine("7. Agregar alumno a curso");
                Console.WriteLine("8. Eliminar alumno de curso");
                Console.WriteLine("9. Calcular promedio de curso");
                Console.WriteLine("10. Registrar nota de alumno");
                Console.WriteLine("11. Transferir alumno entre cursos");
                Console.WriteLine("12. Mostrar cantidad de inscriptos");
                Console.WriteLine("13. Mostrar docentes");
                Console.WriteLine("14. Mostrar resumen general del instituto");
                Console.WriteLine("15. Listar alumnos inscriptos en más de un curso");
                Console.WriteLine("16. Salir");
                Console.Write("\nSeleccione una opción (1-16): ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número válido.");
                    continue;
                }

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la ruta del archivo JSON a cargar: ");
                        string rutaCargar = Console.ReadLine();
                        AprenderMas = Instituto.CargarJson(rutaCargar);
                        break;

                    case 2:
                        Console.Write("Ingrese la carpeta donde guardar el archivo JSON: ");
                        string rutaGuardar = Console.ReadLine();
                        AprenderMas.GuardarJson(rutaGuardar);
                        break;

                    case 3:
                        Console.WriteLine("=== Inscribir nuevo alumno ===");
                        Console.Write("Nombre: ");
                        string nombreA = Console.ReadLine();
                        Console.Write("Apellido: ");
                        string apellidoA = Console.ReadLine();
                        Console.Write("DNI: ");
                        int dniA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Legajo: ");
                        int legajoA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nota inicial: ");
                        double notaA = Convert.ToDouble(Console.ReadLine());

                        Alumno nuevo = new Alumno(nombreA, apellidoA, dniA, legajoA, notaA);
                        AprenderMas.InscribirAlumno(nuevo);
                        Console.WriteLine("Alumno inscripto correctamente.");
                        break;

                    case 4:
                        Console.Write("Ingrese el legajo del alumno a eliminar: ");
                        int legajoEliminar = Convert.ToInt32(Console.ReadLine());
                        Alumno alumnoEliminar = AprenderMas.BuscarAlumnoPorLegajo(legajoEliminar);
                        if (alumnoEliminar != null)
                        {
                            AprenderMas.EliminarAlumno(alumnoEliminar);
                            Console.WriteLine("Alumno eliminado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Alumno no encontrado.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("=== Lista de alumnos del instituto ===");
                        AprenderMas.ListarTodosLosAlumnos();
                        break;

                    case 6:
                        Console.WriteLine("=== Lista de cursos ===");
                        AprenderMas.ListarCursos();
                        break;

                    case 7:
                        Console.WriteLine("=== Agregar alumno a curso ===");
                        Console.Write("Legajo del alumno: ");
                        int legajoAgregar = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre del curso: ");
                        string nombreCursoA = Console.ReadLine();

                        Alumno alumnoAgregar = AprenderMas.BuscarAlumnoPorLegajo(legajoAgregar);
                        Curso cursoA = AprenderMas.BuscarCursoPorNombre(nombreCursoA);

                        if (alumnoAgregar != null && cursoA != null)
                        {
                            try
                            {
                                cursoA.AgregarAlumno(alumnoAgregar);
                                Console.WriteLine("Alumno agregado al curso correctamente.");
                            }
                            catch (CupoLlenoException ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Alumno o curso no encontrado.");
                        }
                        break;

                    case 8:
                        Console.WriteLine("=== Eliminar alumno de curso ===");
                        Console.Write("Legajo del alumno: ");
                        int legajoEliminarC = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nombre del curso: ");
                        string nombreCursoE = Console.ReadLine();

                        Alumno alumnoEliminarC = AprenderMas.BuscarAlumnoPorLegajo(legajoEliminarC);
                        Curso cursoE = AprenderMas.BuscarCursoPorNombre(nombreCursoE);

                        if (alumnoEliminarC != null && cursoE != null)
                        {
                            try
                            {
                                cursoE.EliminarAlumno(alumnoEliminarC);
                                Console.WriteLine("Alumno eliminado del curso.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Alumno o curso no encontrado.");
                        }
                        break;

                    case 9:
                        Console.Write("Ingrese el nombre del curso: ");
                        string nombreCursoP = Console.ReadLine();
                        Curso cursoP = AprenderMas.BuscarCursoPorNombre(nombreCursoP);
                        if (cursoP != null)
                        {
                            Console.WriteLine("Promedio del curso " + cursoP.Nombre + ": " + cursoP.Promedio().ToString("F2"));
                        }
                        else
                        {
                            Console.WriteLine("Curso no encontrado.");
                        }
                        break;

                    case 10:
                        Console.Write("Legajo del alumno: ");
                        int legajoNota = Convert.ToInt32(Console.ReadLine());
                        Alumno alumnoNota = AprenderMas.BuscarAlumnoPorLegajo(legajoNota);
                        if (alumnoNota != null)
                        {
                            Console.Write("Ingrese nueva nota: ");
                            double nuevaNota = Convert.ToDouble(Console.ReadLine());
                            alumnoNota.Nota = nuevaNota;
                            Console.WriteLine("Nota actualizada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Alumno no encontrado.");
                        }
                        break;

                    case 11:
                        Console.WriteLine("=== Transferir alumno entre cursos ===");
                        Console.Write("Legajo del alumno: ");
                        int legajoT = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Curso origen: ");
                        string cursoO = Console.ReadLine();
                        Console.Write("Curso destino: ");
                        string cursoD = Console.ReadLine();

                        Alumno alumnoT = AprenderMas.BuscarAlumnoPorLegajo(legajoT);
                        Curso origen = AprenderMas.BuscarCursoPorNombre(cursoO);
                        Curso destino = AprenderMas.BuscarCursoPorNombre(cursoD);

                        if (alumnoT != null && origen != null && destino != null)
                        {
                            origen.transferirAlumnos(destino, alumnoT);
                        }
                        else
                        {
                            Console.WriteLine("Alumno o curso no encontrado.");
                        }
                        break;

                    case 12:
                        Console.WriteLine("Cantidad total de alumnos inscriptos: " + AprenderMas.CantidadTotalInscriptos());
                        break;

                    case 13:
                        Console.WriteLine("=== Docentes del instituto ===");
                        AprenderMas.MostrarDocentes();
                        break;

                    case 14:
                        Console.WriteLine("=== Resumen general del instituto ===");
                        AprenderMas.MostrarResumen();
                        break;

                    case 15:
                        Console.WriteLine("Lista de alumnos que están en más de 1 curso: ");
                        AprenderMas.ListarAlumnosMultiplesCursos();
                        break;

                    case 16:
                        Console.WriteLine("Saliendo del sistema...");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (!salir);
        }
    }
}
