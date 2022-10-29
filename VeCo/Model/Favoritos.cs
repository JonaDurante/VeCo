namespace VeCo.Clases
{
    public class Favoritos
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Productos> Productos { get; set; }

    }
}

