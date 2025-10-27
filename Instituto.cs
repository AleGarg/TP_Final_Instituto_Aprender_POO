using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InstitutoAprender
{
    public class Instituto
    {
        public string Nombre { get; set; }
        public List<Curso> ListaCursos { get; set; }
        public List<Alumno> ListaAlumnos { get; set; }

        public Instituto(string nombre, List<Curso> listaCursos, List<Alumno> listaAlumnos)
        {
            Nombre = nombre;
            ListaCursos = listaCursos;
            ListaAlumnos = listaAlumnos;
        }

        public void cargarJson(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo no existe.");
                return;
            }

            using (StreamReader lector = new StreamReader(rutaArchivo))
            {
                string contenido = lector.ReadToEnd();
                Console.WriteLine("Contenido del archivo JSON:");
                Console.WriteLine(contenido);
            }
        }

        // Guardar JSON
        public void GuardarJson(string rutaArchivo)
        {
            string rutaCompleta = Path.Combine(rutaArchivo, Nombre + ".json");

            var options = new JsonSerializerOptions { WriteIndented = true };

            try
            {
                string jsonString = JsonSerializer.Serialize(this, options);
                File.WriteAllText(rutaCompleta, jsonString);

                Console.WriteLine("Datos guardados en " + rutaCompleta);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el archivo JSON: {ex.Message}");
            }
        }

        // Inscribir alumno en el instituto
        public void InscribirAlumno(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
        }

        // Eliminar alumno del instituto
        public void EliminarAlumno(Alumno alumno)
        {
            if (!ListaAlumnos.Remove(alumno))
            {
                throw new Exception("Alumno no encontrado en el instituto.");
            }

            foreach (Curso curso in ListaCursos)
            {
                Alumno encontrado = curso.Inscriptos.Find(a => a.Legajo == alumno.Legajo);
                if (encontrado != null)
                {
                    curso.EliminarAlumno(encontrado);
                }
            }
        }

        // Agregar curso
        public void AgregarCurso(Curso curso)
        {
            ListaCursos.Add(curso);
        }

        // Buscar alumno por legajo
        public Alumno BuscarAlumnoPorLegajo(int legajo)
        {
            foreach (Alumno a in ListaAlumnos)
            {
                if (a.Legajo == legajo)
                    return a;
            }
            return null;
        }

        // Buscar curso por nombre
        public Curso BuscarCursoPorNombre(string nombre)
        {
            foreach (Curso c in ListaCursos)
            {
                if (c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    return c;
            }
            return null;
        }

        // Listar todos los alumnos
        public void ListarTodosLosAlumnos()
        {
            foreach (Alumno a in ListaAlumnos)
            {
                a.MostrarDatos();
            }
        }

        // Listar todos los cursos
        public void ListarCursos()
        {
            foreach (Curso c in ListaCursos)
            {
                c.MostrarDatos();
            }
        }

        // Cantidad total de alumnos
        public int CantidadTotalInscriptos()
        {
            return ListaAlumnos.Count;
        }

        // Mostrar docentes
        public void MostrarDocentes()
        {
            foreach (Curso c in ListaCursos)
            {
                Console.WriteLine("Docente: " + c.Docente.Nombre + " " + c.Docente.Apellido);
            }
        }

        // Mostrar resumen general del instituto
        public void MostrarResumen()
        {
            Console.WriteLine("Instituto: " + Nombre);
            Console.WriteLine("Cursos: " + ListaCursos.Count);
            Console.WriteLine("Alumnos: " + ListaAlumnos.Count);
            Console.WriteLine("\nPromedios por curso:");
            foreach (Curso c in ListaCursos)
            {
                Console.WriteLine("- " + c.Nombre + ": " + c.Promedio());
            }
        }
    }
}