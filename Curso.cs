using System;
namespace InstitutoAprender;

public class Curso
{
    private string Nombre;
    private Docente Docente;
    private int CupoMaximo;
    private List<Alumno> Inscriptos;

    public Curso(string nombrecurso, Docente docente, int cupomaximo)
    {
        this.Nombre = nombrecurso;
        this.Docente = docente;
        this.CupoMaximo = cupomaximo;
        this.Inscriptos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        if (Inscriptos.Count >= CupoMaximo)
            throw new Exception("Curso lleno");
        Inscriptos.Add(alumno);

    }
    public void EliminarAlumno(Alumno alumno)
    {
        if (!Inscriptos.Remove(alumno))
            throw new Exception("Alumno no encontrado");
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

}
