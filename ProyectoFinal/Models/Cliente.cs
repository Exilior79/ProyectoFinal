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
        [Required(ErrorMessage = "Ingrese un nombre valido")]
        public String nombreCompleto { get; set; }
        [Display(Name = "Dni del Cliente: ")]
        [Required(ErrorMessage = "Ingrese un dni")]
        public int dni { get; set; }
        [Display(Name = "Mail: ")]
        [EmailAddress]
        [Required(ErrorMessage = "Ingrese un mail valido")]
        public String mail { get; set; }
        [Display(Name = "Contraseña: ")]
        [PasswordPropertyText]
        [MinLength(4)]
        [Required(ErrorMessage = "Ingresa una contaseña, minimo 4 caracteres")]
        public String contraseña { get; set; }
        

    }
}
