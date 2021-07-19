using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.Entidades
{
    /// <summary>
    /// Tabla Autor de la base de datos
    /// </summary>
    public class Autor
    {
        public int Id { get; set; }

        public string Nombre{ get; set; }
    

     
    }
}
