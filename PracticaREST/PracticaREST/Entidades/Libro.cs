using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.Entidades
{
    /// <summary>
    /// Tabal de Libros de la base de datos
    /// </summary>
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }

        public Autor Autor { get; set; }

    }
}
