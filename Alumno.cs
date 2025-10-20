using System;
using InstitutoAprender;

namespace InstitutoAprender
{
	public class Alumno : Persona
	{
		// Atributos privados
		private int Legajo { get; }

		// PREGUNTAR SI ESTO ESTÁ BIEN (sino no me deja acceder a Nota desde Curso)
		public double Nota { get; private set; }

		// Constructor vacío la clase alumno

		// Alejo 17-10: No sé si haga falta esto, por si las dudas no lo borro pero lo comento

		// public Alumno()
		// {
		// 	// Inicializacion para ver los los string int y double 
		// 	this.nombre = "";
		// 	this.legajo = 0;
		// 	this.nota = 0.0;
		// }

		// Construimos los parametros 
		public Alumno(string nombre, string apellido, int dni, int legajo, double nota) : base(nombre, apellido, dni)
		{
			this.Legajo = legajo;
			this.Nota = nota;
		}
		
		// Métodos públicos para leer los datos con get 
		
		// Alejo 17-10: Esto también se puede simplificar arriba (poniendo solo {get; set;} )
		// public string Getnombre()
		// {
		// 	return nombre;
		// }
		
		// public int Getlegajo()
		// {
		// 	return legajo;
		// }
		
		// public double Getnota()
		// {
		// 	return nota;
		// }
		
		public void mostrardatos()
		{
			Console.WriteLine("Alumno: " + Nombre + " " + Apellido + "| Legajo: " + Legajo + " | Nota: " + Nota);
		}
	}
}

