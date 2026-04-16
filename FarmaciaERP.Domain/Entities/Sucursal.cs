namespace FarmaciaERP.Domain.Entities
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activa { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        // Propiedad de navegación
        public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
    }
}
