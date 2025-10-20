using System;

namespace InstitutoAprender
{
    public class Curso
    {
        public string Nombre { get; private set; }
        public Docente Docente { get; private set; }
        private int CupoMaximo { get; set; }
        public List<Alumno> Inscriptos { get; set; }

        public Curso(string nombre, Docente docente, int cupomaximo, List<Alumno> inscriptos)
        {
            Nombre = nombre;
            Docente = docente;
            CupoMaximo = cupomaximo;
            Inscriptos = inscriptos;
        }

        // 1. Inscribir alumno en un curso.
        public void AgregarAlumno(Alumno alumno)
        {
            // 1. Si el curso ya se encuentra lleno, se debe lanzar una excepción (CupoLlenoException).
            if (Inscriptos.Count >= CupoMaximo)
            {
                throw new CupoLlenoException("Curso lleno");
            }
            Inscriptos.Add(alumno);
        }
        public void EliminarAlumno(Alumno alumno)
        {
            if (!Inscriptos.Remove(alumno))
            {
                throw new Exception("Alumno no encontrado");
            }
        }

        public double RegistrarNotas()
        {
            double sumaNotas = 0;
            foreach (Alumno alumno in Inscriptos)
            {
                sumaNotas += alumno.Nota;
            }
            return sumaNotas;
        }

        public double Promedio()
        {
            if (Inscriptos.Count == 0)
                return 0;
            return RegistrarNotas() / Inscriptos.Count;
        }

        public int CantidadInscriptos()
        {
            return Inscriptos.Count;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"\nCurso: {Nombre} | Docente: {Docente.Nombre} {Docente.Apellido} | Cupo Máximo: {CupoMaximo}");
        }

        public void MostrarInscriptos()
        {
            foreach (Alumno alumnoInscripto in Inscriptos)
            {
                alumnoInscripto.MostrarDatos();
            }
        }
    }

    public class CupoLlenoException : Exception
    {
        public CupoLlenoException(string mensaje) : base(mensaje) { }
    }
}