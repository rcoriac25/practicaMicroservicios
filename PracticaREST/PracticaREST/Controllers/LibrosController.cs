using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaREST.DTO;
using PracticaREST.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.Controllers
{
    /// <summary>
    /// Controlador para obtener los libros de los autores
    /// de la base de datos
    /// </summary>
    [ApiController]
    [Route("api/libros")]
    public class LibrosController:ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        /// <summary>
        /// Método con el que agregamos la configuracion de los servicios 
        /// </summary>
        /// <param name="context">interecion con la base de Datos </param>
        /// <param name="mapper">configuracion del mapero</param>
        public LibrosController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        /// <summary>
        /// Método para obtener los libros del autor 
        /// </summary>
        /// <param name="id">id del autor</param>
        /// <returns>Libros del autor</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Libro>> Get(int id)
        {
            return await context.Libros.FirstOrDefaultAsync(x => x.Id == id);
        
        }
        /// <summary>
        /// Agregar Libros a un Autor
        /// </summary>
        /// <param name="libroDTO">Datos del libro</param>
        /// <returns>Respuesta correcta o error</returns>
        [HttpPost(Name ="CrearLibro")]
        public async Task<ActionResult> Post(LibroDTO libroDTO)
        {
            var libro = mapper.Map<Libro>(libroDTO);
            var existeAutor = await context.Autores.AnyAsync(x => x.Id == libro.AutorId);
            if (!existeAutor)
            {
                return BadRequest($"No existe el autor de Id:{libro.AutorId}");
            }
            context.Add(libro);
            await context.SaveChangesAsync();
            return Ok("Operacion Correcta");

        }


    }
}
