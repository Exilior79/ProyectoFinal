using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ProyectoFinal.Controllers;
using ProyectoFinal.Context;

namespace ProyectoFinal.Models
{
    public class CarritoDeCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Nro de Factura")]
        public int Id { get; set; }
        
        [Display(Name = "Cliente: ")]
        [Required(ErrorMessage = "Seleccione un cliente")]
        public int ClienteId { get; set; } // Identificador del cliente

        
        public Cliente ?Cliente { get; set; }

        [Display(Name = "Producto: ")]
        [Required(ErrorMessage = "Seleccione un producto")]
        public int ProductoId { get; set; } 
        
        
        public Producto ?Producto { get; set; }

        [Range(1, 20)]
        [Display(Name = "Cantidad de Kg: ")]
        [Required(ErrorMessage = "Ingrese un numero del 1 al 20")]
        public int Cantidad { get; set; }

        [Display(Name = "Metodo de pago: ")]
        [Required(ErrorMessage = "Seleccione un metodo de pago")]
        public MetodoDePago MetodoDePago { get; set; }

        public double Total { get; set; } 

        public DateTime FechaCreacion { get; set; }

        public CarritoDeCompra()
        {
           

                //Total = Cantidad * Producto.Precio;
                FechaCreacion = DateTime.Now;
            

        }








    }
}
