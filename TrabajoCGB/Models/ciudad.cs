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

    public partial class ciudad
    {
        public ciudad()
        {
            this.oficina = new HashSet<oficina>();
        }
    
        public int id_ciudad { get; set; }

        [Required]
        [Display(Name = "Código postal")]
        [Range(1, 100000000, ErrorMessage = "No puede superar los 8 caracteres")] //para asegurarme que sea número
        //[MaxLength(8, ErrorMessage = "No puede superar los 8 caracteres")] No se puede poner un MaxLength para int      
        public int codigo_postal { get; set; }//convendria ser tipo short

        [Required]
         [Display(Name = "Nombre de la ciudad")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]       
        //[RegularExpression("[a-zA-Z' ']", ErrorMessage = "Use solamente letras")]
        [RegularExpression("^[A-Z0-9 a-z]*$", ErrorMessage = "Use solamente letras")]
        public string nombre_ciudad { get; set; }
    
        public virtual ICollection<oficina> oficina { get; set; }
    }
}
