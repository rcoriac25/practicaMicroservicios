using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.DTO
{
    /// <summary>
    /// Formato de los json de entrada para agregar un libro
    /// </summary>
    public class LibroDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} no debe de tener mas de 50 caracteres")]
        public string Titulo { get; set; }
        public int AutorId { get; set; }
    }
}
