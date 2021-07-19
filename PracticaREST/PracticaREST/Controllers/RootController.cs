using Microsoft.AspNetCore.Mvc;
using PracticaREST.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.Controllers
{
    /// <summary>
    /// Controlador con las Rutas diosponibles para el autor 
    /// </summary>
    [ApiController]
    [Route("api")]
    public class RootController:ControllerBase
    {
        /// <summary>
        /// Método que despliega las rutas disponibles
        /// </summary>
        /// <returns>Regresa las rutas</returns>
        [HttpGet(Name = "ObtenerRoot")]
        public ActionResult<IEnumerable<DatoHATEOAS>> Get()
        {
            var datosHateoas = new List<DatoHATEOAS>();
            datosHateoas.Add(new DatoHATEOAS(enlace: Url.Link("ObtenerRoot",new { }), descripcion: "self", metodo: "GET"));
            datosHateoas.Add(new DatoHATEOAS(enlace: Url.Link("ObtenerAutores", new { }), descripcion: "autores", metodo: "GET"));
            datosHateoas.Add(new DatoHATEOAS(enlace: Url.Link("AgregarAutor", new { }), descripcion: "autor-crear", metodo: "POST"));
            datosHateoas.Add(new DatoHATEOAS(enlace: Url.Link("ActualizarAutor", new { }), descripcion: "Actualizar-autor-por-id-FromQuery", metodo: "PUT"));
            datosHateoas.Add(new DatoHATEOAS(enlace: Url.Link("BorrarAutor", new { }), descripcion: "Borrar-autor-por-id-FromQuery", metodo: "DELETE"));
            datosHateoas.Add(new DatoHATEOAS(enlace: Url.Link("CrearLibro", new { }), descripcion: "libro-crear", metodo: "POST"));
            return datosHateoas;
        }
    }
}
