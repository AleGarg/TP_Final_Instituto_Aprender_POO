using System;

namespace InstitutoAprender
{
    public class Docente : Persona{
        public double Sueldo { get; set; }

        public Docente(string nombre, string apellido, int dni, double sueldo) : base(nombre, apellido, dni)
        {
            Sueldo = sueldo;
        }
        public void MostrarDatos()
		{
			Console.WriteLine($"Docente: {Nombre} {Apellido} | DNI: {Dni} | Sueldo: {Sueldo}");
		}
    }
}