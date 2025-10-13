using System;

namespace InstitutoAprender
{
    public class Persona{

        // Public para que todos puedan leerlo, pero protected set para que solo las clases derivadas los puedan modificar
        public string Nombre { get; protected set; }
        public string Apellido { get; protected set; }
        public int Dni { get; protected set; }

        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }
    }
}