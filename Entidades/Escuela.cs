namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre; 
        public string Nombre
        {
            get { return "Copia : " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; } 
        public TiposDeEscuela TipoEscuela { get; set; }
        public Escuela(string nombre, int año, TiposDeEscuela tipoDeEscuela, string pais="", string ciudad="")
        {
            (this.nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public Curso[] Cursos { get; set; }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine}País: {Pais}, Ciudad: {Ciudad}";
        }
    }
}