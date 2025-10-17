using System;

namespace ejemplo
{
	public class alumno
	{
		// Atributos privados
		private string nombre;
		private int legajo;
		private double nota;
		
		// Constructor vacío la clase alumno
		public Alumno()
		{
			// Inicializacion para ver los los string int y double 
			this.nombre = "";
			this.legajo = 0;
			this.nota = 0.0;
		}
		
		// Construimos los parametros 
		public alumno(string nombre, int legajo, double nota):base(nombre, apellido, dni)
		{
			this.nombre = nombre;
			this.legajo = legajo;
			this.nota = nota;
		}
		
		// Métodos públicos para leer los datos con get 
		public string Getnombre()
		{
			return nombre;
		}
		
		public int Getlegajo()
		{
			return legajo;
		}
		
		public double Getnota()
		{
			return nota;
		}
		
		public void mostrardatos()
		{
			Console.WriteLine("Alumno: " + nombre + " | Legajo: " + legajo + " | Nota: " + nota);
		}
	}
}

