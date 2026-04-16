namespace FarmaciaERP.Domain.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int SucursalId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaActualizacion { get; set; }
        
        // Propiedades de navegación
        public virtual Producto Producto { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        
        // Regla de negocio: Alerta de stock bajo
        public bool StockBajo => Cantidad < 10;
    }
}
