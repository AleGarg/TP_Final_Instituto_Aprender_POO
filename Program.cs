using System;
using System.Text.Json;

namespace InstitutoAprender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Comienzo ========");

            Docente bestiaDeCalchin = new Docente("Julian", "Álvarez", 42260908, 9000.35);

            // PARA PROBAR DATOS Y SI FUNCIONA
            // \n es el salto de línea (hace un enter)
            Console.WriteLine($"Nombre: {bestiaDeCalchin.Nombre} {bestiaDeCalchin.Apellido}\nDNI: {bestiaDeCalchin.Dni}\nSueldo: {bestiaDeCalchin.Sueldo}");
            
            Console.WriteLine($"Nombre: {bestiaDeCalchin.Nombre} {bestiaDeCalchin.Apellido}\nDNI: {bestiaDeCalchin.Dni}\nSueldo: {bestiaDeCalchin.Sueldo}");
        }

        public void GuardarJson(string rutaArchivo)
        {
            // acá iría el código
        }
    }
}