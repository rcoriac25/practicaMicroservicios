using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.DTO
{
    /// <summary>
    /// Clase que define el json de entrada para agregar o modificart un autor
    /// </summary>
    public class AutorDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} no debe de tener mas de 50 caracteres")]
        public string Nombre { get; set; }
    }
}
