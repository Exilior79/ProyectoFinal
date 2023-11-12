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
        [Display(Name = "Producto: ")]
        [Required(ErrorMessage = "Seleccione un producto")]
        public int ProductosIds { get; set; } // Lista de identificadores de productos
        

        // Otras propiedades y métodos que puedas necesitar...

   


    }
}
