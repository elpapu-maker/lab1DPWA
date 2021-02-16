using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LabCrud.Models
{
    public class Materia : EntityBase
    {
        [Required(ErrorMessage ="El campo codigo no puede quedar vacio")]
        [MinLength(1)]
        [MaxLength(10)]
        [Display(Name = "Codigo de materia")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El Nombre codigo no puede quedar vacio")]
        [MinLength(1)]
        [MaxLength(10)]
        [Display(Name = "Nombre de materia")]
        public string Descripcion { get; set; }
        public bool Habilitada { get; set; }
    }
}
