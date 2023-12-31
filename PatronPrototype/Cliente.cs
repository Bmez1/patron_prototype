namespace PatronPrototype
{
    public class Cliente : IPrototype
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public IList<int> Telefonos { get; set; }

        public Cliente(int id, string nombres, string apellidos, int edad, IList<int> telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Telefonos = telefonos;
        }

        public Object Clonar() => this.MemberwiseClone();
        
    }
}