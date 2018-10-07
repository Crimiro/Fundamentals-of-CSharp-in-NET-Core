namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre; //la variable que se encapsula y no puede ser vistar desde fuera de la propieda
        public string Nombre //Propiedas que accede a la variable encapsulada en forma laga tradicional
        {
            get { return "Copia : " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoDeCreacion { get; set; } //forma corta

        public string Pais { get; set; }
        public string Ciudad { get; set; } 

        // public Escuela(string nombre, int año)
        // {
        //     this.nombre = nombre; // si tiene el mismo nombre que el componente de la clase se utliza this para diferenciarlo
        //     AñoDeCreacion = año;
        // }

        public Escuela(string nombre, int año) => (this.nombre, AñoDeCreacion) = (nombre, año);
    }
}