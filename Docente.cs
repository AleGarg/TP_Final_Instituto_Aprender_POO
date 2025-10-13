using System;

namespace InstitutoAprender
{
    public class Docente : Persona{
        public double Sueldo { get; set; }

        public Docente(string nombre, string apellido, int dni, double sueldo):base(nombre, apellido, dni)
        {
            this.Sueldo = sueldo;
        }
    }
}