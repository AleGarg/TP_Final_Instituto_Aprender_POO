using System;
namespace InstitutoAprender;

    public class Clase
{
      private string Nombrecurso;
      private Docente docente;
      private int cupomaximo;
      private List<Alumno> inscriptos;

    public Clase(string nombrecurso, Docente docente, int cupomaximo)
    {
        this.Nombrecurso = nombrecurso;
        this.docente = docente;
        this.cupomaximo = cupomaximo;
        this.inscriptos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        if (inscriptos.Count >= cupomaximo)
            throw new Exception("Curso lleno");
        inscriptos.Add(alumno);

    }
    public void EliminarAlumno(Alumno alumno)
    {
        if (!inscriptos.Remove(alumno))
        throw new Exception("Alumno no encontrado");
    }

    public double RegistrarNotas()
     {
        double sumaNotas = 0;
        foreach (var alumno in inscriptos)
          {
            sumaNotas += alumno.Nota;
          }
            return sumaNotas;
    }

    public double promedio()
     {
        if (inscriptos.Count == 0)
            return 0;
        return RegistrarNotas() / inscriptos.Count;
     }

    public int cantidadInscriptos()
     {
        return inscriptos.Count;
     }


}
