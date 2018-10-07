using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academia", 2012);//Siempre ;
            escuela.Pais = "Colombia";
            escuela.Ciudad = "Bogota";
            Console.WriteLine(escuela.Nombre);
        }
    }
}
