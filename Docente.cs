using System;

namespace InstitutoAprender
{
    public class Docente : Persona{
        private double sueldo;
        public double Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }

        public Docente(string nombre, string apellido, int dni, double sueldo) : base(nombre, apellido, dni)
        {
            Sueldo = sueldo;
        }
        public override void MostrarDatos()
		{
			Console.WriteLine($"Docente: {Nombre} {Apellido} | DNI: {Dni} | Sueldo: ${Sueldo}");
		}
    }
}