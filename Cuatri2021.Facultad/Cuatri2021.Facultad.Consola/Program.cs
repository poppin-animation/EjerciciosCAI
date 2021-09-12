using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuatri2021.Facultad.Biblioteca;
using Cuatri2021.Facultad.Biblioteca.Utilidades;



namespace Cuatri2021.Facultad.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona();
            persona.Nombre = "Florencia Soledad";
            persona.Apellido = "Sueiro";
            Console.WriteLine(persona.GetNombreCompleto());
            Console.ReadLine();

        }
    }
}
