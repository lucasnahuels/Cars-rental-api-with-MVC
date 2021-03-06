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

    public partial class coche
    {
        public coche()
        {
            this.alquiler = new HashSet<alquiler>();
        }
    
        public int id_coche { get; set; }

        [Required]
        [Display(Name = "Patente")]
        [MaxLength(20, ErrorMessage = "No puede superar los 20 caracteres")]
        public string patente { get; set; }

        [Required]
        [RegularExpression(@"^[a-gA-G]+$", ErrorMessage = "Solamente letras de la 'A' a la 'G'")]
        [MaxLength(1, ErrorMessage = "Un solo caracter")]
        [Display(Name = "Grupo")]
        public string grupo { get; set; } //Este campo deberia ser Char

        [Required]
        [RegularExpression("^[A-Z0-9 a-z]*$", ErrorMessage = "Use solamente letras")]
        [Display(Name = "Marca")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]
        public string marca { get; set; }
        
        [Required]
        [Display(Name = "Modelo")]
        [Range(1970, int.MaxValue, ErrorMessage = "El rango comienza desde el año 1970")]
        public int modelo { get; set; } //convendria ser tipo short

        [Required]
        [Range(1, 7, ErrorMessage = "El rango debe star entre 1 y 7")]
        [Display(Name = "Número de puertas")]
        public int numero_puertas { get; set; } //convendria ser tipo short

        [Required]
        [Range(1, 30, ErrorMessage = "El rango debe star entre 1 y 30")]
        [Display(Name = "Número de pasajeros")]
        public int numero_pasajeros { get; set; } //convendria ser tipo short

        [Required]
        [Display(Name = "Capacidad del baúl en litros")]
        [Range(0, int.MaxValue, ErrorMessage = "El valor debe ser numerico")]
        public int capacidad_baúl { get; set; } 

        [Required]
        [Display(Name = "Dirección oficina")]
        public int codigo_unico_oficina { get; set; }
    
        public virtual ICollection<alquiler> alquiler { get; set; }
        public virtual oficina oficina { get; set; }
    }
}
