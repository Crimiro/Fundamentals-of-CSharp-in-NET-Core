using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academia", 2012, TiposDeEscuela.Primaria, pais:"Colombia", ciudad:"Bogotá");

            escuela.Cursos = new Curso[] {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };
            WriteLine(escuela);
            WriteLine("===============");
            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("---------------------");
            WriteLine("Cursos de la escuela");
            WriteLine("---------------------");
            if(escuela?.Cursos !=null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, ID {curso.UniqueID}");
                }
            }
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            var contador = 0;
            while (contador < arregloCursos.Length)
            {
                WriteLine($"Nombre {arregloCursos[contador].Nombre}, ID {arregloCursos[contador].UniqueID}");
                contador++;
            }
        }
    }
}
