using System;
using System.Collections.Generic;
using System.Data;

namespace InstitutoAprender
{
    class Program
    {
        static void Main(string[] args)
        {

            // PREGUNTAR POR LO DEL DICCIONARIO PARA NOTAS

            Console.WriteLine("======== Comienzo ========");

            Console.WriteLine("¿Desea precargar datos para verificar el funcionamiento del sistema? Escriba SI o NO");
            string precargar;
            while (true)
            {
                try
                {
                    precargar = Console.ReadLine();

                    if (precargar.ToUpper() != "SI" && precargar.ToUpper() != "NO")
                    {
                        throw new Exception("Ingrese SI o NO.");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    continue; // Vuelve al inicio del while
                }
            }


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
                Docente Docente6 = new Docente("frionel", "fressi", 38456912, 696969.99);

                // Alumnos
                // Ya no pedimos la nota acá, depende de cada curso
                Alumno alumno1 = new Alumno("Pignata", "Agustin", 2520620, 1001);
                Alumno alumno2 = new Alumno("Alejo", "Brandan", 42568921, 1002);
                Alumno alumno3 = new Alumno("Fabrizio", "Insarrualde", 4552364, 1003);
                Alumno alumno4 = new Alumno("Pepito", "Grillo", 48234652, 1004);
                Alumno alumno5 = new Alumno("David", "Quint", 48220123, 1005);
                Alumno alumno6 = new Alumno("Lautaro", "del Campo", 43453942, 1006);
                Alumno alumno7 = new Alumno("Sofia", "Marin", 40123456, 1007);
                Alumno alumno8 = new Alumno("Camila", "Lopez", 42345678, 1008);
                Alumno alumno9 = new Alumno("Martina", "Gomez", 43456789, 1009);
                Alumno alumno10 = new Alumno("Lucas", "Fernandez", 44567890, 1010);
                Alumno alumno20 = new Alumno("Mateo", "Sanchez", 45678901, 1011);
                Alumno alumno11 = new Alumno("Valentina", "Ramirez", 46789012, 1012);
                Alumno alumno12 = new Alumno("Diego", "Torres", 47890123, 1013);
                Alumno alumno13 = new Alumno("Santiago", "Flores", 48901234, 1014);
                Alumno alumno14 = new Alumno("Nicolas", "Rivera", 49012345, 1015);
                Alumno alumno15 = new Alumno("Joaquin", "Vega", 50123456, 1016);
                Alumno alumno16 = new Alumno("Emilia", "Cruz", 51234567, 1017);
                Alumno alumno17 = new Alumno("Isabella", "Morales", 52345678, 1018);
                Alumno alumno18 = new Alumno("Camilo", "Ortiz", 53456789, 1019);
                Alumno alumno19 = new Alumno("Adrian", "Gutierrez", 54567890, 1020);
                Alumno alumno21 = new Alumno("Javier", "Rojas", 55678901, 1021);

                // Inscribir alumnos al instituto
                AprenderMas.InscribirAlumno(alumno1);
                AprenderMas.InscribirAlumno(alumno2);
                AprenderMas.InscribirAlumno(alumno3);
                AprenderMas.InscribirAlumno(alumno4);
                AprenderMas.InscribirAlumno(alumno5);
                AprenderMas.InscribirAlumno(alumno6);
                AprenderMas.InscribirAlumno(alumno7);
                AprenderMas.InscribirAlumno(alumno8);
                AprenderMas.InscribirAlumno(alumno9);
                AprenderMas.InscribirAlumno(alumno10);
                AprenderMas.InscribirAlumno(alumno11);
                AprenderMas.InscribirAlumno(alumno12);
                AprenderMas.InscribirAlumno(alumno13);
                AprenderMas.InscribirAlumno(alumno14);
                AprenderMas.InscribirAlumno(alumno15);
                AprenderMas.InscribirAlumno(alumno16);
                AprenderMas.InscribirAlumno(alumno17);
                AprenderMas.InscribirAlumno(alumno18);
                AprenderMas.InscribirAlumno(alumno19);
                AprenderMas.InscribirAlumno(alumno20);
                AprenderMas.InscribirAlumno(alumno21);

                // Crear cursos y asignar alumnos/docentes
                List<Alumno> alumnosProg = new List<Alumno>() { alumno1, alumno2, alumno4, alumno7, alumno15 };
                List<Alumno> alumnosMat = new List<Alumno>() { alumno2, alumno3, alumno5, alumno14, alumno15, alumno17 };
                List<Alumno> alumnosAlg = new List<Alumno>() { alumno1, alumno3, alumno4, alumno5, alumno16 };
                List<Alumno> alumnosTaller = new List<Alumno>() { alumno2, alumno3, alumno4, alumno11, alumno16, alumno8 };
                List<Alumno> alumnosFisica = new List<Alumno>() { alumno5, alumno6, alumno7, alumno18, alumno19, alumno20 };
                List<Alumno> alumnosQuimica = new List<Alumno>() { alumno8, alumno9, alumno10, alumno11, alumno12, alumno13 };

                Curso progObjetos = new Curso(AprenderMas.ListaCursos.Count(), "Programación con Objetos", Docente1, 5, alumnosProg);
                AprenderMas.AgregarCurso(progObjetos);

                Curso mat = new Curso(AprenderMas.ListaCursos.Count(), "Matemática", Docente2, 20, alumnosMat);
                AprenderMas.AgregarCurso(mat);

                Curso alg = new Curso(AprenderMas.ListaCursos.Count(), "Álgebra", Docente3, 42, alumnosAlg);
                AprenderMas.AgregarCurso(alg);

                Curso tallerIng = new Curso(AprenderMas.ListaCursos.Count(), "Taller de Ingeniería", Docente4, 20, alumnosTaller);
                AprenderMas.AgregarCurso(tallerIng);

                Curso fisica = new Curso(AprenderMas.ListaCursos.Count(), "Física", Docente5, 32, alumnosFisica);
                AprenderMas.AgregarCurso(fisica);

                Curso quimica = new Curso(AprenderMas.ListaCursos.Count(), "Química", Docente6, 12, alumnosQuimica);
                AprenderMas.AgregarCurso(quimica);

                // Asignamos notas para cada alumno en cada curso

                // Curso: Programación con Objetos (ID = 0)
                // Alumnos: { alumno1, alumno2, alumno4, alumno7, alumno15 }
                alumno1.RegistrarNota(0, 9);
                alumno2.RegistrarNota(0, 10);
                alumno4.RegistrarNota(0, 7);
                alumno7.RegistrarNota(0, 8);
                alumno15.RegistrarNota(0, 9);

                // Curso: Matemática (ID = 1)
                // Alumnos: { alumno2, alumno3, alumno5, alumno14, alumno15, alumno17 }
                alumno2.RegistrarNota(1, 8);
                alumno3.RegistrarNota(1, 7);
                alumno5.RegistrarNota(1, 9);
                alumno14.RegistrarNota(1, 10);
                alumno15.RegistrarNota(1, 8);
                alumno17.RegistrarNota(1, 7);

                // Curso: Álgebra (ID = 2)
                // Alumnos: { alumno1, alumno3, alumno4, alumno5, alumno16 }
                alumno1.RegistrarNota(2, 7);
                alumno3.RegistrarNota(2, 8);
                alumno4.RegistrarNota(2, 9);
                alumno5.RegistrarNota(2, 10);
                alumno16.RegistrarNota(2, 6);



                // Curso: Taller de Ingeniería (ID = 3)
                // Alumnos: { alumno2, alumno3, alumno4, alumno11, alumno16, alumno8 }
                alumno2.RegistrarNota(3, 10);
                alumno3.RegistrarNota(3, 9);
                alumno4.RegistrarNota(3, 8);
                alumno11.RegistrarNota(3, 7);
                alumno16.RegistrarNota(3, 6);
                alumno8.RegistrarNota(3, 9);

                // Curso: Física (ID = 4)
                // Alumnos: { alumno5, alumno6, alumno7, alumno18, alumno19, alumno20 }
                alumno5.RegistrarNota(4, 5);
                alumno6.RegistrarNota(4, 3);
                alumno7.RegistrarNota(4, 9);
                alumno18.RegistrarNota(4, 10);
                alumno19.RegistrarNota(4, 6);
                alumno20.RegistrarNota(4, 4);

                // Curso: Química (ID = 5)
                // Alumnos: { alumno8, alumno9, alumno10, alumno11, alumno12, alumno13 }
                alumno8.RegistrarNota(5, 10);
                alumno9.RegistrarNota(5, 8);
                alumno10.RegistrarNota(5, 7);
                alumno11.RegistrarNota(5, 10);
                alumno12.RegistrarNota(5, 6);
                alumno13.RegistrarNota(5, 10);
            }

            // Menú principal
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("===== TRABAJO FINAL - PROGRAMACIÓN CON OBJETOS =====");
                Console.WriteLine("1. Inscribir alumno en instituto y un curso");
                Console.WriteLine("2. Eliminar alumno de un curso");
                Console.WriteLine("3. Registrar nota de alumno");
                Console.WriteLine("4. Listar alumnos de un curso");
                Console.WriteLine("5. Mostrar cursos con docentes e inscriptos");
                Console.WriteLine("6. Listar alumnos inscriptos en más de un curso");
                Console.WriteLine("7. Transferir alumno entre cursos");
                Console.WriteLine("8. Calcular promedio de notas de un curso");
                Console.WriteLine("9. Guardar datos en archivo JSON");
                Console.WriteLine("10. Cargar datos desde archivo JSON");

                Console.WriteLine("11. Eliminar alumno del instituto");
                Console.WriteLine("12. Listar alumnos del instituto");
                Console.WriteLine("13. Agregar alumno existente a curso");
                Console.WriteLine("14. Mostrar cantidad de inscriptos");
                Console.WriteLine("15. Mostrar docentes");
                Console.WriteLine("16. Mostrar resumen general del instituto");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opción (1-16): ");

                int opcion;

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingrese una opción válida.");
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey(true);
                    continue; // Vuelve al inicio del while
                }

                Console.WriteLine();

                // MOSTRAR TODOS LOS ALUMNOS DE UN CURSO ESPECÍFICO
                switch (opcion)
                {
                    case 1: // INSCRIBIR NUEVO ALUMNO AL INSTITUTO Y PREGUNTAR SI QUIERE AÑADIRLO A UN CURSO

                        string nombreA;
                        string apellidoA;
                        int dniA;
                        int legajoA;
                        double notaA;

                        Console.WriteLine("=== Inscribir nuevo alumno ===");

                        while (true)
                        {
                            Console.Write("Nombre: ");
                            nombreA = Console.ReadLine();

                            // Revisamos si está vacío
                            if (string.IsNullOrEmpty(nombreA))
                            {
                                Console.WriteLine("Error: El nombre no puede estar vacío. Presione una tecla para continuar.\n");
                                Console.ReadKey(true);
                                continue;
                            }

                            // Revisamos si tiene algún dígito o número
                            if (nombreA.Any(char.IsDigit))
                            {
                                Console.WriteLine("Error: El nombre no puede contener números. Presione una tecla para continuar.\n");
                                Console.ReadKey(true);
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            Console.Write("Apellido: ");
                            apellidoA = Console.ReadLine();

                            // Revisamos si está vacío
                            if (string.IsNullOrEmpty(apellidoA))
                            {
                                Console.WriteLine("Error: El apellido no puede estar vacío. Presione una tecla para continuar.\n");
                                Console.ReadKey(true);
                                continue;
                            }

                            // Revisamos si tiene algún dígito o número
                            if (apellidoA.Any(char.IsDigit))
                            {
                                Console.WriteLine("Error: El apellido no puede contener números. Presione una tecla para continuar.\n");
                                Console.ReadKey(true);
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            try
                            {
                                Console.Write("DNI: ");
                                dniA = Convert.ToInt32(Console.ReadLine());

                                // Verificamos si hay algún alumno con el mismo DNI
                                foreach (Alumno a in AprenderMas.ListaAlumnos)
                                {
                                    if (a.Dni == dniA)
                                    {
                                        throw new DuplicateNameException("Ya existe un alumno con ese DNI.");
                                    }
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                            catch (DuplicateNameException ex)
                            {
                                Console.WriteLine("\nError: " + ex.Message);
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.Write("Legajo: ");
                                legajoA = Convert.ToInt32(Console.ReadLine());

                                // VERIFICAR SI EL LEGAJO YA EXISTE
                                foreach (Alumno a in AprenderMas.ListaAlumnos)
                                {
                                    if (a.Legajo == legajoA)
                                    {
                                        throw new DuplicateNameException("Ya existe un alumno con ese legajo.");
                                    }
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                            catch (DuplicateNameException ex)
                            {
                                Console.WriteLine("\nError: " + ex.Message);
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                        }

                        Alumno nuevo = new Alumno(nombreA, apellidoA, dniA, legajoA);
                        AprenderMas.InscribirAlumno(nuevo);
                        Console.WriteLine("\n=== Alumno inscrito en el instituto correctamente ===\n");

                        // AÑADIR A CURSO?
                        Console.WriteLine("¿Desea añadir el alumno a un curso? Escriba SI o NO");
                        string anadirOpcion;
                        int iteracion = 0;

                        // Intentamos añadir alumno a un curso por primera vez
                        while (true)
                        {
                            Console.WriteLine("\nITERACIÓN " + iteracion + "\n");
                            try
                            {
                                if (iteracion == 0)
                                {
                                    while (true)
                                    {
                                        Console.Write("Ingrese SI o NO: ");
                                        anadirOpcion = Console.ReadLine().Trim().ToUpper();

                                        if (anadirOpcion == "SI" || anadirOpcion == "NO")
                                            break;

                                        Console.WriteLine("Error: Ingrese SI o NO.");
                                    }

                                    if (anadirOpcion == "SI")
                                    {
                                        Console.WriteLine("\nCursos disponibles:");
                                        AprenderMas.ListarCursos();
                                    }
                                    else
                                    {
                                        break; // NO: salís y no agregás cursos
                                    }
                                }

                                string anadirOtro;
                                bool agregar = true;
                                if (iteracion >= 1)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("\n¿Desea añadir el alumno a otro curso? Escriba SI o NO.");
                                        try
                                        {
                                            anadirOtro = Console.ReadLine();

                                            // Si el usuario escribe algo distinto a SI o NO hay excepción y lo pide de vuelta
                                            if (anadirOtro.ToUpper() != "SI" && anadirOtro.ToUpper() != "NO")
                                            {
                                                throw new Exception("Ingrese SI o NO.");
                                            }

                                            // Si escribió SI:
                                            if (anadirOtro.ToUpper() == "SI")
                                            {
                                                agregar = true;
                                                // MOSTRAMOS CURSOS
                                                Console.WriteLine("\nCursos disponibles: ");
                                                AprenderMas.ListarCursos();
                                                break;
                                            }
                                            // Si escribió NO:
                                            if (anadirOtro.ToUpper() == "NO")
                                            {
                                                agregar = false;
                                                break;
                                            }
                                        }
                                        catch (Exception)
                                        {
                                            Console.WriteLine("Error: Ingrese SI o NO.");
                                            continue; // Vuelve al inicio del while
                                        }
                                    }

                                }

                                if (agregar == false)
                                {
                                    break;
                                }

                                int identificadorCursoAnadir;
                                while (true)
                                {
                                    try
                                    {
                                        Console.Write("\nIdentificador del curso: ");
                                        identificadorCursoAnadir = Convert.ToInt32(Console.ReadLine());
                                        break;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                        Console.WriteLine("Presione una tecla para continuar...\n");
                                        Console.ReadKey(true);
                                        continue; // Vuelve al inicio del while
                                    }
                                }

                                Curso cursoAnadir = AprenderMas.BuscarCursoPorIdentificador(identificadorCursoAnadir);

                                if (nuevo != null && cursoAnadir != null)
                                {
                                    // Intentamos añadir el nuevo alumno al curso indicado
                                    try
                                    {
                                        cursoAnadir.AgregarAlumno(nuevo);
                                        Console.WriteLine("\n=== Alumno agregado al curso correctamente ===\n");

                                        // ======== PEDIR NOTA =========
                                        string anadirNota;

                                        Console.WriteLine("\n¿Desea añadir la nota del alumno para este curso? Escriba SI o NO.");
                                        while (true)
                                        {
                                            // Intentamos pedir un "SI" o "NO"
                                            try
                                            {
                                                anadirNota = Console.ReadLine();

                                                // Si el usuario escribe algo distinto a SI o NO hay excepción y lo pide de vuelta
                                                if (anadirNota.ToUpper() != "SI" && anadirNota.ToUpper() != "NO")
                                                {
                                                    throw new Exception("Ingrese SI o NO.");
                                                }

                                                // Si escribió SI:
                                                if (anadirNota.ToUpper() == "SI")
                                                {
                                                    while (true)
                                                    {
                                                        // Pedimos la nota con try-catch
                                                        try
                                                        {
                                                            Console.Write("\nNota inicial: ");
                                                            notaA = Convert.ToDouble(Console.ReadLine());

                                                            if (notaA < 1 || notaA > 10)
                                                            {
                                                                throw new ArgumentOutOfRangeException();
                                                            }

                                                            nuevo.RegistrarNota(cursoAnadir.Identificador, notaA);
                                                            Console.WriteLine("¡Nota registrada exitosamente!");
                                                            break;
                                                        }
                                                        catch (FormatException)
                                                        {
                                                            Console.WriteLine("Error: Solo se pueden ingresar números.");
                                                            Console.WriteLine("\nPresione una tecla para continuar...");
                                                            Console.ReadKey(true);
                                                            continue; // Vuelve al inicio del while
                                                        }
                                                        catch (ArgumentOutOfRangeException)
                                                        {
                                                            Console.WriteLine("\nError: El valor debe estar entre 1 y 10.");
                                                            Console.WriteLine("Presione una tecla para continuar...");
                                                            Console.ReadKey(true);
                                                            continue; // Vuelve al inicio del while
                                                        }
                                                    }
                                                    break;
                                                }
                                                // Si escribió NO:
                                                if (anadirNota.ToUpper() == "NO")
                                                {
                                                    Console.WriteLine("El alumno se agregó sin nota inicial.");
                                                    break;
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                Console.WriteLine("Error: Ingrese SI o NO.");
                                                continue; // Vuelve al inicio del while
                                            }
                                        }
                                    }
                                    // Error: el cupo está lleno
                                    catch (CupoLlenoException ex)
                                    {
                                        Console.WriteLine("\nError: " + ex.Message);
                                        Console.WriteLine("EL ALUMNO NO FUE AÑADIDO AL CURSO.");
                                        iteracion++;
                                        continue;
                                    }
                                    // Error: el alumno ya estaba en el curso
                                    catch (AlumnoEnCursoException ex)
                                    {
                                        Console.WriteLine("\nError: " + ex.Message);
                                        Console.WriteLine("EL ALUMNO NO FUE AÑADIDO AL CURSO.");
                                        iteracion++;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nAlumno o curso no encontrado.");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                                continue; // Vuelve al inicio del while
                            }

                            iteracion++;
                        }

                        break;

                    case 2: // ELIMINAR ALUMNO DE UN CURSO

                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para eliminar.");
                            break;
                        }

                        Console.WriteLine("=== Eliminar alumno de curso ===");

                        int legajoEliminarC;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Legajo del alumno: ");
                                legajoEliminarC = Convert.ToInt32(Console.ReadLine());

                                // VERIFICAR SI EL LEGAJO YA EXISTE
                                bool existe = false;
                                foreach (Alumno a in AprenderMas.ListaAlumnos)
                                {
                                    if (a.Legajo == legajoEliminarC)
                                    {
                                        existe = true;
                                    }
                                }
                                if (existe == false)
                                {
                                    throw new Exception("El alumno con legajo " + legajoEliminarC + " no se ha encontrado.");
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                        }

                        bool estaEnAlgunCurso = false;
                        bool tituloImpreso = false;
                        foreach (Curso c in AprenderMas.ListaCursos)
                        {
                            foreach (Alumno a in c.Inscriptos)
                            {
                                if (a.Legajo == legajoEliminarC)
                                {
                                    if (!tituloImpreso)
                                    {
                                        Console.WriteLine("\nEl alumno está en estos cursos:");
                                        tituloImpreso = true;
                                    }

                                    estaEnAlgunCurso = true;
                                    c.MostrarDatos();

                                    break;
                                }
                            }
                        }

                        if (estaEnAlgunCurso == false)
                        {
                            Console.WriteLine("El alumno no está en ningún curso.\n");
                            break;
                        }

                        int identificadorCursoE;
                        while (true)
                        {
                            try
                            {
                                Console.Write("\nIdentificador del curso: ");
                                identificadorCursoE = Convert.ToInt32(Console.ReadLine());

                                // VERIFICAR SI EL LEGAJO YA EXISTE
                                bool estaEnCurso = false;
                                foreach (Curso c in AprenderMas.ListaCursos)
                                {
                                    if (c.Identificador == identificadorCursoE)
                                    {
                                        foreach (Alumno a in c.Inscriptos)
                                        {
                                            if (a.Legajo == legajoEliminarC)
                                            {
                                                estaEnCurso = true;
                                            }
                                        }
                                    }
                                }
                                if (estaEnCurso == false)
                                {
                                    throw new Exception("El alumno no está en ese curso o el curso no existe.");
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                        }

                        Alumno alumnoEliminarC = AprenderMas.BuscarAlumnoPorLegajo(legajoEliminarC);
                        Curso cursoE = AprenderMas.BuscarCursoPorIdentificador(identificadorCursoE);

                        if (alumnoEliminarC != null && cursoE != null)
                        {
                            try
                            {
                                cursoE.EliminarAlumno(alumnoEliminarC);
                                Console.WriteLine("Alumno eliminado del curso.");

                                estaEnAlgunCurso = false;
                                foreach (Curso c in AprenderMas.ListaCursos)
                                {
                                    foreach (Alumno a in c.Inscriptos)
                                    {
                                        if (a.Legajo == legajoEliminarC)
                                        {
                                            estaEnAlgunCurso = true;
                                            break;
                                        }
                                    }
                                }

                                if (estaEnAlgunCurso == false)
                                {
                                    AprenderMas.EliminarAlumno(alumnoEliminarC);
                                    Console.WriteLine("El alumno no está en ningún curso: El alumno fue eliminado del instituto.");

                                    break;
                                }
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

                    case 3: // CAMBIAR NOTA DE ALUMNO (Registrar nota de examen para un alumno en un curso.)

                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para cambiar su nota.");
                            break;
                        }

                        // Para poner nota de un alumno, necesitamos:
                        // Legajo del alumno - Identificador del curso - Nueva nota (double) - VERIFICAR SI EL ALUMNO ESTÁ EN ESE CURSO

                        Alumno alumnoNota;
                        Curso cursoNota;
                        double nuevaNota;

                        // PEDIMOS UN ALUMNO 
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("=== Registrar Nota ===");
                                AprenderMas.ListarTodosLosAlumnos(); // Mostramos alumnos
                                Console.Write("\nLegajo del Alumno: ");

                                int legajo = Convert.ToInt32(Console.ReadLine());
                                alumnoNota = AprenderMas.BuscarAlumnoPorLegajo(legajo);

                                if (alumnoNota == null)
                                {
                                    throw new Exception("No se encontró ningún alumno con ese legajo.");
                                }
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("\nError: " + ex.Message);
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                            }
                        }

                        // PEDIMOS UN CURSO VÁLIDO (Y QUE EL ALUMNO ESTÉ EN ÉL)
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("\nCursos disponibles:");
                                AprenderMas.ListarCursos(); // Mostramos cursos
                                Console.Write("\nIdentificador del Curso: ");

                                int idCurso = Convert.ToInt32(Console.ReadLine());
                                cursoNota = AprenderMas.BuscarCursoPorIdentificador(idCurso);

                                if (cursoNota == null)
                                {
                                    throw new Exception("No se encontró ningún curso con ese identificador.");
                                }

                                // Verificamos si el alumno está inscrito en el curso. Si no lo está, tiramos error.
                                if (!cursoNota.Inscriptos.Contains(alumnoNota))
                                {
                                    throw new Exception("El alumno " + alumnoNota.Nombre + " " + alumnoNota.Apellido + " no está inscripto en el curso " + cursoNota.Nombre + ".");
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("\nError: " + ex.Message);
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                            }
                        }

                        // PEDIR NOTA VÁLIDA (1-10)
                        while (true)
                        {
                            try
                            {
                                Console.Write("Ingrese la nueva nota para " + alumnoNota.Nombre + " " + alumnoNota.Apellido + " en " + cursoNota.Nombre + ": ");

                                nuevaNota = Convert.ToDouble(Console.ReadLine());

                                if (nuevaNota < 1 || nuevaNota > 10)
                                {
                                    throw new ArgumentOutOfRangeException();
                                }

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("\nError: La nota debe estar entre 1 y 10.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                            }
                        }

                        // REGISTRAR LA NOTA
                        alumnoNota.RegistrarNota(cursoNota.Identificador, nuevaNota);

                        Console.WriteLine("\nNota actualizada correctamente.");
                        Console.WriteLine("Alumno: " + alumnoNota.Legajo + " | Curso: " + cursoNota.Identificador + " (" + cursoNota.Nombre + ") | Nueva Nota: " + nuevaNota);

                        break;

                    case 4: // LISTAR ALUMNOS DE UN CURSO

                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para listar.");
                            break;
                        }

                        Console.WriteLine("Cursos: ");
                        foreach (Curso c in AprenderMas.ListaCursos)
                        {
                            c.MostrarDatos();
                        }

                        int identificadorCurso;
                        while (true)
                        {
                            try
                            {
                                Console.Write("\nIngrese el identificador del curso para ver sus alumnos: ");
                                identificadorCurso = Convert.ToInt32(Console.ReadLine());

                                // VERIFICAR SI EL CURSO EXISTE
                                bool cursoExiste = false;
                                foreach (Curso c in AprenderMas.ListaCursos)
                                {
                                    if (c.Identificador == identificadorCurso)
                                    {
                                        cursoExiste = true;
                                    }
                                }
                                if (cursoExiste == false)
                                {
                                    throw new Exception("El curso no existe.");
                                }

                                Console.WriteLine("\n=== Alumnos del curso ===");
                                Curso curso = AprenderMas.BuscarCursoPorIdentificador(identificadorCurso);

                                curso.MostrarInscriptos();

                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                                break; // Vuelve al inicio del while
                            }
                        }
                        break;

                    case 5: // LISTAR CURSOS

                        if(AprenderMas.ListaCursos.Count() == 0)
                        {
                            Console.WriteLine("No hay cursos ni docentes para mostrar.");
                            break;
                        }

                        Console.WriteLine("=== Lista de cursos ===");
                        AprenderMas.ListarCursos();
                        break;

                    case 6: // MOSTRAR ALUMNOS EN 1 CURSO O MÁS
                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para listar.");
                            break;
                        }

                        Console.WriteLine("Lista de alumnos que están en más de 1 curso: ");
                        AprenderMas.ListarAlumnosMultiplesCursos();
                        break;

                    case 7: // TRANSFERIR ALUMO DE UN CURSO A OTRO

                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para transferir.");
                            break;
                        }

                        Console.WriteLine("=== Transferir alumno entre cursos ===");

                        AprenderMas.ListarTodosLosAlumnos();

                        // LEGAJO
                        int legajoTransferir;
                        while (true)
                        {
                            Console.Write("\nLegajo del alumnno: ");
                            try
                            {
                                legajoTransferir = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                            }
                        }

                        // CURSO ORIGEN
                        AprenderMas.ListarCursos();
                        int cursoOrigen;
                        while (true)
                        {
                            Console.Write("\nCurso origen: ");
                            try
                            {
                                cursoOrigen = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                            }
                        }

                        // CURSO DESTINO
                        int cursoDestino;
                        while (true)
                        {
                            Console.Write("Curso destino: ");
                            try
                            {
                                cursoDestino = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: ingrese solo números.\n");
                            }
                        }

                        Alumno alumnoTransferir = AprenderMas.BuscarAlumnoPorLegajo(legajoTransferir);
                        Curso origen = AprenderMas.BuscarCursoPorIdentificador(cursoOrigen);
                        Curso destino = AprenderMas.BuscarCursoPorIdentificador(cursoDestino);

                        if (alumnoTransferir == null)
                        {
                            Console.WriteLine("ERROR: No existe un alumno con ese legajo.");
                            break;
                        }

                        if (origen == null)
                        {
                            Console.WriteLine("ERROR: El curso de origen no existe.");
                            break;
                        }

                        if (destino == null)
                        {
                            Console.WriteLine("ERROR: El curso destino no existe.");
                            break;
                        }

                        if (!origen.Inscriptos.Contains(alumnoTransferir))
                        {
                            Console.WriteLine("ERROR: El alumno no está inscripto en el curso de origen.");
                            break;
                        }
                        if (destino.Inscriptos.Contains(alumnoTransferir))
                        {
                            Console.WriteLine("ERROR: El alumno ya está inscripto en el curso destino.");
                            break;
                        }

                        origen.Inscriptos.Remove(alumnoTransferir);
                        destino.Inscriptos.Add(alumnoTransferir);

                        Console.WriteLine("Transferencia realizada correctamente.");
                        break;


                    case 8: // MOSTRAR PROMEDIO DEL CURSO
                     
                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para mostrar promedio.");
                            break;
                        }

                        Console.WriteLine("=== Mostrar promedio del curso ===");

                        int identificadorCursoPromedio;
                        AprenderMas.ListarCursos();
                        while (true)
                        {
                            try
                            {
                                Console.Write("\nIngrese el identificador del curso: ");
                                identificadorCursoPromedio = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                          {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                            }
                        }

                        Curso cursoPromedio = AprenderMas.BuscarCursoPorIdentificador(identificadorCursoPromedio);

                        if (cursoPromedio == null)
                        {
                            Console.WriteLine("No se encontró ningún curso con ese identificador.");
                            break;
                        }

                        double promedio = cursoPromedio.Promedio();

                        if (double.IsNaN(promedio))
                        {
                            Console.WriteLine("No hay notas registradas en este curso.");
                        }
                        else
                        {
                            Console.WriteLine($"El promedio del curso {cursoPromedio.Nombre} es: {promedio:F2}");
                        }

                        break;

                    case 9: // GUARDAR JSON
                        Console.Write("Ingrese la carpeta donde guardar el archivo JSON: ");
                        string rutaGuardar = Console.ReadLine();
                        AprenderMas.GuardarJson(rutaGuardar);
                        break;

                    case 10: // CARGAR JSON
                        Console.Write("Ingrese la ruta del archivo JSON a cargar: ");
                        string rutaCargar = Console.ReadLine();
                        AprenderMas = Instituto.CargarJson(rutaCargar);
                        break;

                    // ============================== EXTRAS ==============================

                    case 11: // ELIMINAR ALUMNO DE INSTITUTO

                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para eliminar.");
                            break;
                        }

                        Console.Write("Ingrese el legajo del alumno a eliminar: ");

                        int legajoEliminar;
                        while (true)
                        {
                            try
                            {
                                legajoEliminar = Convert.ToInt32(Console.ReadLine());
                                break; // Es correcto si llega hasta aca 
                            }
                            catch
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.Write("\nIngrese nuevamente el legajo: ");
                            }
                        }

                        try
                        {
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
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error inesperado: " + ex.Message);
                        }
                        break;

                    case 12: // LISTAR TODOS LOS ALUMNOS DEL INSTITUTO

                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para listar.");
                            break;
                        }

                        Console.WriteLine("=== Lista de alumnos del instituto ===");
                        AprenderMas.ListarTodosLosAlumnos();
                        break;

                    case 13: // AGREGAR ALUMNO EXISTENTE A UN CURSO

                        if(AprenderMas.CantidadTotalInscriptos() == 0)
                        {
                            Console.WriteLine("No hay alumnos para agregar.");
                            break;
                        }

                        Console.WriteLine("=== Agregar alumno a curso ===");

                        int legajoAgregar;
                        while (true)
                        {
                            try
                            {
                                Console.Write("\nLegajo del alumno: ");
                                legajoAgregar = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                        }

                        int identificadorCursoA;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Identificador del curso: ");
                                identificadorCursoA = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nError: Solo se pueden ingresar números.");
                                Console.WriteLine("Presione una tecla para continuar...\n");
                                Console.ReadKey(true);
                                continue; // Vuelve al inicio del while
                            }
                        }

                        Alumno alumnoAgregar = AprenderMas.BuscarAlumnoPorLegajo(legajoAgregar);
                        Curso cursoA = AprenderMas.BuscarCursoPorIdentificador(identificadorCursoA);

                        if (alumnoAgregar != null && cursoA != null)
                        {
                            try
                            {
                                cursoA.AgregarAlumno(alumnoAgregar);
                                Console.WriteLine("\nAlumno agregado al curso correctamente.");
                            }
                            catch (AlumnoEnCursoException ex)
                            {
                                Console.WriteLine("\nError: " + ex.Message);
                            }
                            catch (CupoLlenoException ex)
                            {
                                Console.WriteLine("\nError: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Alumno o curso no encontrado.");
                        }
                        break;

                    case 14: // MOSTRAR SOLO CANTIDAD DE ALUMNOS INSCRIPTOS EN EL INSTITUTO
                        Console.WriteLine("Cantidad total de alumnos inscriptos: " + AprenderMas.CantidadTotalInscriptos());
                        break;

                    case 15: // MOSTRAR TODOS LOS DOCENTES DEL INSTITUTO
                        if(AprenderMas.ListaCursos.Count() == 0)
                        {
                            Console.WriteLine("No hay cursos ni docentes para mostrar.");
                            break;
                        }

                        Console.WriteLine("=== Docentes del instituto ===");
                        AprenderMas.MostrarDocentes();
                        break;

                    case 16: // RESUMEN DEL INSTITUTO
                        Console.WriteLine("=== Resumen general del instituto ===");
                        AprenderMas.MostrarResumen();
                        break;

                    case 0: // SALIR
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
                    Console.ReadKey(true);
                }

            } while (!salir);
        }
    }
}
