using System;
using InstitutoAprender;

namespace InstitutoAprender
{
	public class Alumno : Persona
	{
		// Atributos privados
		private int legajo;

		// Diccionario = Valor notas 
		// Llave (TKey) = Identificador del curso
		// Valor (TValue) = Nota
		private Dictionary<int, double> notasporcurso;
		
		public int Legajo
        {
			set {
				legajo = value;
			}
			get
			{
				return legajo;
			} 
        }
		public Dictionary<int, double> NotasPorCurso
		{
		    get
			{ 
			    return notasporcurso; 
			}
			set
			{
			   notasporcurso = value;
			}
		
		}

		// Construimos los parametros 
		public Alumno(string nombre, string apellido, int dni, int legajo) : base(nombre, apellido, dni)
		{
			Legajo = legajo;

			// Hacemos un diccionario vacío para almacenar las notas, pero no lo pedimos obligatoriamente al crear un alumno
			NotasPorCurso = new Dictionary<int, double>();
		}

        // 3. Registrar nota de examen para un alumno en un curso
		public void RegistrarNota(int idCurso, double nota)
        {
            // Si la nota no existe la agrega, sino la actualiza
            NotasPorCurso[idCurso] = nota;
        }

		// double? para que pueda devolver null
		public double? ObtenerNota(int idCurso)
        {
            // TryGetValue se usa para buscar un valor en un diccionario
            if (NotasPorCurso.TryGetValue(idCurso, out double nota))
            {
                // Si la encontró, devuelve la nota
                return nota;
            }
            
            // Si no encontró alguna nota para ese curso, devuelve null
            return null; 
        }
		
		// Mostramos datos (sin la nota ahora)
		public override void MostrarDatos()
		{
			Console.WriteLine("Alumno: " + Nombre + " " + Apellido + " | DNI: " + Dni + " | Legajo: " + Legajo);
		}
	}
}