using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Display(Name ="Nombre del producto: ")]
        public string nombreProducto { get; set; }
        
        public int cantidad { get; set; }
        
        public double precio { get; set; }


    }
}
