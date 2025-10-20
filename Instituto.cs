using System;

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

        public static void cargarJson(string rutaArchivo)
        {
            
        }
        public static void GuardarJson(string rutaArchivo)
        {

        }

        // 1. Si el alumno no está registrado en el instituto, se debe dar de alta:
        public void InscribirAlumno(Alumno alumno)
        {
            ListaAlumnos.Add(alumno);
        }
        public void EliminarAlumno(Alumno alumno)
        {
            // ListaAlumnos.Remove(alumno);
            if (!ListaAlumnos.Remove(alumno))
            {
                throw new Exception("Alumno no encontrado");
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
                Console.WriteLine($"Alumnos del curso {curso.Nombre}:\n");
                foreach (Alumno alumnoInscripto in curso.Inscriptos)
                {
                    alumnoInscripto.MostrarDatos();
                }
            }
        }
    }
}