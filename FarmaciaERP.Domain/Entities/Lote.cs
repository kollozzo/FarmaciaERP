namespace FarmaciaERP.Domain.Entities
{
    public class Lote
    {
        public int Id { get; set; }
        public string CodigoLote { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        
        // Propiedad de navegación
        public virtual Producto Producto { get; set; }
        
        // Reglas de negocio
        public bool EstaVencido => FechaVencimiento < DateTime.Now;
        
        public bool EstaPróximoAVencer => 
            !EstaVencido && 
            (FechaVencimiento - DateTime.Now).TotalDays <= 30;
    }
}
