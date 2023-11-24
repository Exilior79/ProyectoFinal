using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProyectoFinal.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nombre Completo:")]
        [Required(ErrorMessage = "Ingrese un nombre valido")]
        public String NombreCompleto { get; set; }
        [Display(Name = "Dni del Cliente: ")]
        [Required(ErrorMessage = "Ingrese un dni")]
        public int Dni { get; set; }
        [Display(Name = "Mail: ")]
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese un mail valido")]
        public String Mail { get; set; }
        
        [Display(Name = "Fecha de creacion: ")]
        public DateTime FechaCreacion { get; set; } = DateTime.Now;



    }
}
