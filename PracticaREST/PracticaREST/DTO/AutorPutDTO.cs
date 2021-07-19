using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.DTO
{
    public class AutorPutDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} no debe de tener mas de 50 caracteres")]
        public string Nombre { get; set; }
    }
}
