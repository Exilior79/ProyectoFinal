using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProyectoFinal.Models
{
    public class CarritoDeCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Display(Name = "Cliente: ")]
        [Required(ErrorMessage = "Seleccione un cliente")]
        public int ClienteId { get; set; } // Identificador del cliente

        
        public Cliente ?Cliente { get; set; }

        [Display(Name = "Producto: ")]
        [Required(ErrorMessage = "Seleccione un producto")]
        public int ProductoId { get; set; } // Lista de identificadores de productos
        
        
        public Producto ?Producto { get; set; }

        

   


    }
}
