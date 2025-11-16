using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InstitutoAprender
{
    public class Instituto
    {
        private string nombre;
        private List<Curso> listaCursos;
        private List<Alumno> listaAlumnos;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public List<Curso> ListaCursos
        {
            get
            {
                return listaCursos;
            }
            set
            {
                listaCursos = value;
            }
        }
        public List<Alumno> ListaAlumnos
        {
            get
            {
                return listaAlumnos;
            }
            set
            {
                listaAlumnos = value;
            }
        }

        public Instituto(string nombre, List<Curso> listaCursos, List<Alumno> listaAlumnos)
        {
            Nombre = nombre;
            ListaCursos = listaCursos;
            ListaAlumnos = listaAlumnos;
        }

        // 9. Guardar y cargar los datos del instituto. Los datos pueden persistirse en archivos de texto o en formato JSON.
        // Se usa Instituto? con el ? para que sea un tipo de referencia anulable, o sea que pueda devolver null si falla
        public static Instituto? CargarJson(string rutaArchivo)
        {
            try
            {
                string jsonString = File.ReadAllText(rutaArchivo);

                Instituto? institutoCargado = JsonSerializer.Deserialize<Instituto>(jsonString);

                Console.WriteLine("Datos cargados desde " + rutaArchivo);
                return institutoCargado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el archivo: " + ex.Message);
                return null;
            }
        }

        // Guardar JSON
        public void GuardarJson(string rutaArchivo)
        {
            string rutaCompleta = Path.Combine(rutaArchivo, Nombre + ".json");

            var options = new JsonSerializerOptions { WriteIndented = true };

            try
            {
                // Serializa el objeto Instituto actual a un string JSON
                string jsonString = JsonSerializer.Serialize(this, options);

                // Crea el archivo o lo sobrescribe
                File.WriteAllText(rutaCompleta, jsonString);

                Console.WriteLine("Datos guardados en " + rutaCompleta);
                Console.WriteLine(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el archivo JSON: " + ex.Message);
            }
        }

        // Inscribir alumno en el instituto
        public void InscribirAlumno(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
        }

        // 2. Eliminar alumno del instituto. Si el alumno no cursa en ningún otro curso, también se lo debe dar de baja del instituto.
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
        public Curso BuscarCursoPorIdentificador(int identificador)
        {
            foreach (Curso c in ListaCursos)
            {
                if (c.Identificador.Equals(identificador))
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
            Console.WriteLine("\nCantidad de alumnos en el instituto: " + listaAlumnos.Count());
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

        // 6. Listar alumnos inscriptos en más de un curso
        public void ListarAlumnosMultiplesCursos()
        {
            Dictionary<Alumno, int> conteoInscripciones = new Dictionary<Alumno, int>();
            foreach (Curso c in ListaCursos)
            {
                foreach (Alumno alumno in c.Inscriptos)
                {   
                    // Comprobar si Alumno ya existe
                    if (conteoInscripciones.ContainsKey(alumno))
                    {
                        conteoInscripciones[alumno]++;
                    }
                    else
                    {
                        // Sino, lo agregamos con valor 1 (Está en un curso)
                        conteoInscripciones.Add(alumno, 1);
                    }
                }
            }

            bool seEncontraronAlumnos = false;
            
            // Recorremos el diccionario (pares de Alumno-Conteo)
            foreach (KeyValuePair<Alumno, int> par in conteoInscripciones)
            {
                // Si el contador es mayor a 1, es decir que está en más de un curso:
                if (par.Value > 1)
                {
                    // par.Key es el Alumno, par.Value es el conteo
                    par.Key.MostrarDatos();
                    Console.WriteLine(" (Inscripto en " + par.Value+ " cursos)");
                    seEncontraronAlumnos = true;
                }
            }

            if (!seEncontraronAlumnos)
            {
                Console.WriteLine("No se encontraron alumnos inscriptos en múltiples cursos.");
            }
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