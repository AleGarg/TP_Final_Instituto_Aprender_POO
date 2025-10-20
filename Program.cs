using System;
// using System.Collections.Generics;
using System.Text.Json;

namespace InstitutoAprender
{
    class Program
    {
        static void Main(string[] args)
        {
            // PREGUNTAR SI ES NECESARIO USAR EL DNI Y QUE SALGA CUANDO PONEMOS LOS DATOS (por curiosidad)

            Console.WriteLine("======== Comienzo ========");

            Docente bestiaDeCalchin = new Docente("Julian", "Álvarez", 42260908, 9000.35);

            // PARA PROBAR DATOS Y SI FUNCIONA
            // \n es el salto de línea (hace un enter)
            Console.WriteLine($"Nombre: {bestiaDeCalchin.Nombre} {bestiaDeCalchin.Apellido}\nDNI: {bestiaDeCalchin.Dni}\nSueldo: {bestiaDeCalchin.Sueldo}");

            // CREAR INSTITUTO
            // Al parecer se puede hacer un constructor sobrecargado, ver luego
            Instituto AprenderMas = new Instituto("Aprender+", new List<Curso>(), new List<Alumno>());


            // Fijate si podes modificar de otra manera capaz agregar add porque quedo repetitivo
            //crear docentes

            // Creo que a docentes no le podés asignar materia, sino que desde Curso se asigna un Docente
            Docente Docente1 = new Docente("Diego", "Luparello", 44226688, 500000);
            Docente1.MostrarDatos();
            Docente Docente2 = new Docente("Viviana", "Canosa", 88559911, 450000);
            Docente2.MostrarDatos();
            Docente Docente3 = new Docente("Ana", "Montana", 77223311, 550000);
            Docente3.MostrarDatos();
            Docente Docente4 = new Docente("Sebastian", "Perdicaro", 66995511, 690000);
            Docente4.MostrarDatos();

            // Crear Alumnos 
            Alumno alumno1 = new Alumno("Pignata", "Agustin", 2520620, 1001, 9);
            alumno1.MostrarDatos();
            Alumno alumno2 = new Alumno("Alejo", "Brandan", 42568921, 1002, 10);
            alumno2.MostrarDatos();
            Alumno alumno3 = new Alumno("Fabrizio", "Insarrualde", 4552364, 1003, 10);
            alumno3.MostrarDatos();
            Alumno alumno4 = new Alumno("Pepito", "Grillo", 48234652, 1004, 8);
            alumno4.MostrarDatos();

            // Inscribir alumnos 
            AprenderMas.InscribirAlumno(alumno1);
            AprenderMas.InscribirAlumno(alumno2);
            AprenderMas.InscribirAlumno(alumno3);
            AprenderMas.InscribirAlumno(alumno4);

            List<Alumno> alumnosProgramacion = new List<Alumno>() { alumno1, alumno2, alumno3, alumno4 };
            
            // List<Alumno> alumnosProgramacion = new List<Alumno>();

            // Crear cursos
            Curso progObjetos = new Curso("Programación con objetos", Docente1, 5, alumnosProgramacion);
            Curso mat = new Curso("Matemática", Docente2, 20, alumnosProgramacion);
            Curso alg = new Curso("Algebra", Docente3, 20, alumnosProgramacion);
            Curso tallerIng = new Curso("Taller de Ingenieria", Docente4, 20, alumnosProgramacion);

            Console.WriteLine($"CANTIDAD DE ALUMNOS PROG OBJ {progObjetos.CantidadInscriptos}");


            // TRANSFERIR UN ALUMNO DE PROGRAMACION A MATEMATICA
            Console.WriteLine("\n\n\n");
            // progObjetos.transferirAlumnos(mat, alumno1);
            Console.WriteLine("\n\n\n");

            // Crear instituto
            AprenderMas.AgregarCurso(progObjetos);
            AprenderMas.AgregarCurso(mat);
            AprenderMas.AgregarCurso(alg);
            AprenderMas.AgregarCurso(tallerIng);

            Console.WriteLine("\nMOSTRANDO INSCRIPTOS: \n");
            progObjetos.MostrarInscriptos();

            Console.WriteLine($"CANTIDAD DE ALUMNOS PROG OBJ {progObjetos.CantidadInscriptos()}");
            // Agregar alumnos al curso
            Console.WriteLine($"Intentando añadir alumnos...");
            try
            {
                progObjetos.AgregarAlumno(alumno1);
                mat.AgregarAlumno(alumno2);
                alg.AgregarAlumno(alumno3);
                tallerIng.AgregarAlumno(alumno4);
            }
            catch (CupoLlenoException ex)
            {
                Console.WriteLine($"⚠️ Error: {ex.Message}");
                // throw new CupoLlenoException("⚠️ Error: Cupo Lleno");
            }
            finally
            {
                Console.WriteLine($"Alumno cargado correctamente.");
            }

            // Mostrar datos
            Console.WriteLine("\n=== Alumnos inscriptos ===");
            progObjetos.MostrarDatos();
            progObjetos.MostrarInscriptos();

            mat.MostrarDatos();
            mat.MostrarInscriptos();

            alg.MostrarDatos();
            alg.MostrarInscriptos();

            tallerIng.MostrarDatos();
            tallerIng.MostrarInscriptos();

            // Mostrar promedio
            Console.WriteLine($"\nPromedio del curso {progObjetos.Nombre}: {progObjetos.Promedio():F2}");
        }
    }
}