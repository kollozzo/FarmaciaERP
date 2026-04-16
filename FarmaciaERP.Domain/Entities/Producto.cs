namespace FarmaciaERP.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string RegistroSanitario { get; set; }
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
        
        // Propiedades de navegación
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();
        public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();
    }
}
