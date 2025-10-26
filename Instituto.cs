using System;
using System.Text.Json;

namespace InstitutoAprender
{
    public class Instituto
    {
        private string Nombre { get; set; }
        private List<Curso> ListaCursos { get; set; }
        private List<Alumno> ListaAlumnos { get; set; }

        public Instituto(string nombre, List<Curso> listaCursos, List<Alumno> listaAlumnos)
        {
            Nombre = nombre;
            ListaCursos = listaCursos;
            ListaAlumnos = listaAlumnos;
        }

        public void cargarJson(string rutaArchivo)
        {
            using (StreamReader lector = new StreamReader(rutaArchivo))
            {
                if (File.Exists("datos.txt"))
                {
                    Console.WriteLine("El archivo existe.");
                }
                string linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }
            }
        }
        public void GuardarJson(string rutaArchivo)
        {
            string rutaCompleta = Path.Combine(rutaArchivo, Nombre+".json");

            // Opciones para que el JSON esté indentado
            var options = new JsonSerializerOptions { WriteIndented = true };

            try
            {
                // 3. Serializa 'this' (el objeto Instituto actual) a un string JSON
                string jsonString = JsonSerializer.Serialize(this);

                // 4. Escribe ese string al archivo. Esto crea el archivo o lo sobrescribe.
                File.WriteAllText(rutaCompleta, jsonString);

                Console.WriteLine("Datos guardados en " + rutaCompleta);
                Console.WriteLine(jsonString);
                using (StreamWriter escritor = new StreamWriter(rutaCompleta))
                {
                    escritor.WriteLine(jsonString);
                }
            }
            catch (Exception ex)
            {
                // Es buena idea manejar posibles errores al guardar
                Console.WriteLine($"Error al guardar el archivo JSON: {ex.Message}");
            }
        }

        // 1. Si el alumno no está registrado en el instituto, se debe dar de alta:
        public void InscribirAlumno(Alumno alumno)
        {
            // VER QUE NO SE REPITA EL LEGAJO
            ListaAlumnos.Add(alumno);
        }
        public void EliminarAlumno(Alumno alumno)
        {
            // SI BORRAMOS DEL INSTITUTO, BORRAMOS DE LOS CURSOS
            // SI NO ESTÁ EN NINGÚN CURSO, BORRAMOS DEL INSTITUTO

            // ListaAlumnos.Remove(alumno);
            if (!ListaAlumnos.Remove(alumno))
            {
                throw new Exception("Alumno no encontrado");
            }
            foreach (Curso curso in ListaCursos)
            {
                foreach (Alumno alumnoBorrar in curso.Inscriptos)
                {
                    if (alumno.Legajo == alumnoBorrar.Legajo)
                    {
                        curso.EliminarAlumno(alumno);
                    }
                }
            }
        }

        // AGREGAR Y ELIMINAR CURSOS
        public void AgregarCurso(Curso curso)
        {
            ListaCursos.Add(curso);
        }
        public void EliminarCurso(Curso curso)
        {
            ListaCursos.Add(curso);
        }

        // LISTAR CURSOS / ALUMNOS
        public void ListarCursos(Alumno alumno)
        {
            foreach (Curso curso in ListaCursos)
            {
                curso.MostrarDatos();
            }
        }
        public void ListarAlumnoPorCursos(Alumno alumno)
        {
            foreach (Curso curso in ListaCursos)
            {
                Console.WriteLine("Alumnos del curso " + curso.Nombre + ":\n");
                foreach (Alumno alumnoInscripto in curso.Inscriptos)
                {
                    alumnoInscripto.MostrarDatos();
                }
            }
        }
    }
}