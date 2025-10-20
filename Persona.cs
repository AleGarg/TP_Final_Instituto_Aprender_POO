using System;

namespace InstitutoAprender
{
    public abstract class Persona{
        protected int dni;
        protected string nombre;
        protected string apellido;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        // Public para que todos puedan leerlo, pero protected set para que solo las clases derivadas los puedan modificar
        // protected string Nombre { get => nombre; set => nombre = value; }
        // protected string Apellido { get; set; }
        // protected int Dni { get => dni; set => dni = value; }

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public abstract void MostrarDatos();
    }
}