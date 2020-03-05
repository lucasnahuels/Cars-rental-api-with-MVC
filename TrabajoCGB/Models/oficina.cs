//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoCGB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class oficina
    {
        public oficina()
        {
            this.coche = new HashSet<coche>();
        }
    
        public int codigo_unico_oficina { get; set; }

        [Required]
        [Display(Name = "Calle")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]
        [RegularExpression("^[A-Z0-9 a-z]*$", ErrorMessage = "Use solamente letras")]
        public string calle { get; set; }

        [Required]
        [Display(Name = "Número")]
        [Range(1, 100000, ErrorMessage = "El rango debe star entre 1 y 100000")]
        public int numero { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]       
        public string telefono { get; set; }

        [Required]
        [Display(Name = "Nombre Ciudad")]
        public int id_ciudad { get; set; }  //convendria ser tipo short

        public virtual ciudad ciudad { get; set; }
        public virtual ICollection<coche> coche { get; set; }
    }
}