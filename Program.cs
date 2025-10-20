using System;
using System.Text.Json;

namespace InstitutoAprender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Comienzo ========");

            Docente bestiaDeCalchin = new Docente("Julian", "Álvarez", 42260908, 9000.35);

            // PARA PROBAR DATOS Y SI FUNCIONA
            // \n es el salto de línea (hace un enter)
            Console.WriteLine($"Nombre: {bestiaDeCalchin.Nombre} {bestiaDeCalchin.Apellido}\nDNI: {bestiaDeCalchin.Dni}\nSueldo: {bestiaDeCalchin.Sueldo}");
            
            Console.WriteLine($"Nombre: {bestiaDeCalchin.Nombre} {bestiaDeCalchin.Apellido}\nDNI: {bestiaDeCalchin.Dni}\nSueldo: {bestiaDeCalchin.Sueldo}");
        }

        public void GuardarJson(string rutaArchivo)
        {
            {// Fijate si podes modificar de otra manera capaz agregar add porque quedo repetitivo
		//crear docentes 	
		Docente Docente1 = new Docente("Diego,  Luparello", 44226688 , 500000 , "Programacion con objetos");
		Docente1.Mostrardatos();
		Docente Docente2 = new Docente("Viviana , Canosa", 88559911 , 450000 , "Matematica");
		Docente2.MostrarDatos();
		Docente Docente3 = new Docente("Ana , Montana" , 77223311 , 550000 , "Algebra");
		Docente3.MostrarDatos();
		Docente Docente4 = new Docente("Sebastian , Perdicaro" , 66995511 , 690000 , "Taller de Ingenieria");
		Docente4.MostrarDatos()
		//crear alumnos 
        docente1.MostrarDatos();
        alumno alumno1 = new alumno("Pignata, Agustin" , 2520620,1001,9);
        alumno1.mostrardatos();
        alumno alumno2= new alumno("Alejo,  Brandan" , 42568921 , 1002 , 10);
        alumno2.mostrardatos();
        alumno alumno3 = new alumno("Fabrizio, Insarrualde" , 4552364 , 1003 , 10);
        alumno3.mostrardatos();
        alumno alumno4 = new alumno("Pepito, Grillo" , 48234652 , 1004 , 8);
        alumno4.mostrardatos();
        // Inscribir alumnos 
        
        
        inst.InscribirAlumno(alumno1);
        inst.InscribirAlumno(alumno2);
        inst.InscribirAlumno(alumno3);
        inst.InscribirAlumno(alumno4);
         // Crear cursos
        Curso curso1 = new Curso("Programación con objetos", prof, 3);
        Curso curso2 = new Curso("Matemática", prof, 3);
        curso curso3 = new curso ("Algebra" , prof, 3);
        curso curso4 = new curso("Taller de Ingenieria" , prof, 3);
        
        // Crear instituto
         Instituto inst = new Instituto("UNAJ");
        inst.AgregarCurso(curso1);
        inst.AgregarCurso(curso2);
        inst.AgregarCurso(curso3);
        inst.AgregarCurso(curso4);
          // Agregar alumnos al curso
        try
        {
            curso1.AgregarAlumno(alumno1);
            curso2.AgregarAlumno(alumno2);
            curso3.AgregarAlumno(alumno3);
            curso4.AgregarAlumno(alumno4);
        }
        catch (CupoLlenoException ex)
        {
            Console.WriteLine($"⚠️ Error: {ex.Mensaje}");
        }

        // Mostrar datos
        Console.WriteLine("\n=== Alumnos inscriptos ===");
        curso1.MostrarInscriptos();
        curso2.Mostrarinscriptos();
        curso3.Mostarinscriptos();
        curso4.Mostrarinscriptos()

        // Mostrar promedio
        Console.WriteLine($"\nPromedio del curso {curso1}: {curso1.Promedio():F2}");

                    }
    }
}
