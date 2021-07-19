using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.DTO
{
    /// <summary>
    /// Clase que define el formato de nuestro HATEOAS
    /// </summary>
    public class DatoHATEOAS
    {
        public string Enlace { get; private set; }
        public string Descripcion { get; private set; }
        public string Metodo { get; private set; }
        /// <summary>
        /// Método que mapea los datos a nuestro
        /// </summary>
        /// <param name="enlace">ruta donde se encuentra</param>
        /// <param name="descripcion">Descripcion de que hace</param>
        /// <param name="metodo">que método REST es</param>
        public DatoHATEOAS(string enlace, string descripcion, string metodo)
        {
            Enlace = enlace;
            Descripcion = descripcion;
            Metodo = metodo;
        }
    }
}
