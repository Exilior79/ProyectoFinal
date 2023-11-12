using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe agregar un nombre")]
        [Display(Name ="Nombre del producto: ")]
        public string nombreProducto { get; set; }
        [Range(1, 20)]
        [Display(Name = "Cantidad de Kg: ")]
        [Required(ErrorMessage = "Ingrese un numero del 1 al 20")]
        public int cantidad { get; set; }
        [Required(ErrorMessage = "Debe agregar un precio")]
        [Display(Name = "Precio por kilo: ")]
        public double precio { get; set; }


    }
}
