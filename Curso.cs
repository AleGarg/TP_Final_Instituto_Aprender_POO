using System;

namespace InstitutoAprender
{
    public class Curso
    {
        private int identificador;
        private string nombre;
        private Docente docente;
        private int cupoMaximo;
        private List<Alumno> inscriptos;

        public int Identificador
        {
            get
            {
                return identificador;
            }
            set
            {
                identificador = value;
            }
        }
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
        public Docente Docente
        {
            get
            {
                return docente;
            }
            set
            {
                docente = value;
            }
        }
        public int CupoMaximo
        {
            get
            {
                return cupoMaximo;
            }
            set
            {
                cupoMaximo = value;
            }
        }
        public List<Alumno> Inscriptos
        {
            get
            {
                return inscriptos;
            }
            set
            {
                inscriptos = value;
            }
        }

        public Curso(int identificador, string nombre, Docente docente, int cupomaximo, List<Alumno> inscriptos)
        {
            Identificador = identificador;
            Nombre = nombre;
            Docente = docente;
            CupoMaximo = cupomaximo;
            Inscriptos = inscriptos;
        }

        // 1. Inscribir alumno en un curso.
        public void AgregarAlumno(Alumno alumno)
        {
            // Si el alumno ya está en el curso, lanza una excepción.
            if (Inscriptos.Contains(alumno))
            {
                throw new AlumnoEnCursoException("El alumno ya está en el curso.");
            }
            // 1. Si el curso ya se encuentra lleno, se debe lanzar una excepción (CupoLlenoException).
            if (Inscriptos.Count >= CupoMaximo)
            {
                throw new CupoLlenoException("Curso lleno");
            }
            Inscriptos.Add(alumno);
        }

        // 2. Eliminar alumno de un curso. 
        public void EliminarAlumno(Alumno alumno)
        {
            if (!Inscriptos.Remove(alumno))
            {
                throw new Exception("Alumno no encontrado");
            }
        }

        // 8. Mostrar el promedio general de notas de cada curso.
        public double Promedio()
        {
            double sumaNotas = 0;
            int alumnosConNota = 0;

            foreach (Alumno alumno in Inscriptos)
            {
                double? nota = alumno.ObtenerNota(this.Identificador);

                if (nota.HasValue)
                {
                    sumaNotas += nota.Value;
                    alumnosConNota++;
                }
            }

            if (alumnosConNota == 0)
            {
                return 0;
            }

            return sumaNotas / alumnosConNota;
        }

        public int CantidadInscriptos()
        {
            return Inscriptos.Count;
        }

        // 4. Listar alumnos de un curso, mostrando su nombre, DNI y nota (si la tiene).
        public void MostrarInscriptos()
        {
            foreach (Alumno alumnoInscripto in Inscriptos)
            {
                alumnoInscripto.MostrarDatos();
            }
        }

        // 5. Listar cursos con su docente responsable y la cantidad de inscriptos.
        public void MostrarDatos()
        {
            Console.WriteLine("Curso: " + Identificador + " - " + Nombre + " | Docente: " + Docente.Nombre + " " + Docente.Apellido + " | Cupo Máximo: " + CupoMaximo);
        }

        // 7. Transferir un alumno de un curso a otro. Se debe validar la existencia del alumno en el curso origen y el cupo disponible en el curso destino.
        public void transferirAlumnos(Curso cursoATransferir, Alumno alumnoATransferir)
        {
            try
            {
                // Transferimos el Alumno deseado al curso deseado
                cursoATransferir.AgregarAlumno(alumnoATransferir);

                // Y eliminamos el Alumno del curso actual
                EliminarAlumno(alumnoATransferir);
            }
            catch (CupoLlenoException ex)
            {
                Console.WriteLine("⚠️ Error: " + ex.Message);
                Console.WriteLine("El alumno no fue transferido ni eliminado de ningun curso.");
            }
            finally
            {
                Console.WriteLine("Alumno transferido correctamente de " + Nombre + " a " + cursoATransferir.Nombre + ".");
            }
        }
    }

    public class CupoLlenoException : Exception
    {
        public CupoLlenoException(string mensaje) : base(mensaje) { }
    }
    public class AlumnoEnCursoException : Exception
    {
        public AlumnoEnCursoException(string mensaje) : base(mensaje) { }
    }
}