using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academia", 2012, TiposDeEscuela.Primaria, pais:"Colombia", ciudad:"Bogotá");
            Console.WriteLine(escuela);
        }
    }
}
