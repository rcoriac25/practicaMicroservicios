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
    [ApiController]
    [Route("api/autores")]
    /// <summary>
    /// Controlador para obtencion de datos relacionados
    /// A los autortes 
    /// </summary>
    public class AutorController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        /// <summary>
        /// Método con el que agregamos la configuracion de los servicios 
        /// </summary>
        /// <param name="context">interecion con la base de Datos </param>
        /// <param name="mapper">configuracion del mapero</param>
        public AutorController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        /// <summary>
        /// Método para la obtencion de los autores
        /// Guardados en la base de datos
        /// </summary>
        /// <returns>Autores</returns>
        [HttpGet(Name ="ObtenerAutores")]
        
        public async Task<ActionResult<List<Autor>>> GetAutores()
        {
            try
            {
                return Ok(await context.Autores.ToListAsync());
            } catch (Exception e) {
                return BadRequest($"Error {e}");
            }
            
        }
        /// <summary>
        /// Método para agregar Autores
        /// </summary>
        /// <param name="autorDTO">Autor a guardar</param>
        /// <returns>Respuesta correcta o error</returns>
        [HttpPost(Name="AgregarAutor")]
        public async Task<ActionResult> PostAutor([FromBody]AutorDTO autorDTO)
        {
            var existeAutor = await context.Autores.AnyAsync(x => x.Nombre == autorDTO.Nombre);
            if (existeAutor)
            {
                return BadRequest($"Ya existe un autor con el jnombre {autorDTO.Nombre}");
            }
            try {
                var autor = mapper.Map<Autor>(autorDTO);
                context.Add(autor);
                await context.SaveChangesAsync();
                return Ok("Operacion Correcta");
            } catch(Exception e) {

                return BadRequest($"Error {e}");
            }
            
            

        }
        /// <summary>
        /// Método para Actulizar Autor
        /// </summary>
        /// <param name="autorDTO">Nuevo Autor</param>
        /// <param name="id">id a modificar</param>
        /// <returns>Respuesta correcta o error/returns>
        [HttpPut("Put",Name ="ActualizarAutor")]
        public async Task<ActionResult> PutAutor([FromBody] AutorPutDTO autorDTO, [FromQuery]int id)
        {
            var autor = mapper.Map<Autor>(autorDTO);
            if (autor.Id != id) 
            {
                return BadRequest("El id no coincide");
            }
            try {
                var existe = await context.Autores.AnyAsync(x => x.Id == id);
                if (!existe)
                {
                    return NotFound("No existe el autor");
                }

                context.Update(autor);
                await context.SaveChangesAsync();
                return Ok("Operacion Correcta");
            }
            catch (Exception e) {
                return BadRequest($"Error {e}");
            }
           

        }
        /// <summary>
        /// Método para Borrar Autor 
        /// </summary>
        /// <param name="id">id a borrar</param>
        /// <returns>Respuesta correcta o error</returns>
        [HttpDelete("delete",Name ="BorrarAutor")]
        public async Task<ActionResult> DeleteAutor([FromQuery] int id)
        {
            try {
                var existe = await context.Autores.AnyAsync(x => x.Id == id);
                if (!existe)
                {
                    return NotFound("No existe el autor");
                }
                context.Remove(new Autor() { Id = id });
                await context.SaveChangesAsync();
                return Ok("Operacion Correcta");
            }
            catch (Exception e)
            {
                return BadRequest($"Error {e}");
            }
           

        }
    }
}
