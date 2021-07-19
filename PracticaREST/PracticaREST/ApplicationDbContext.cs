using Microsoft.EntityFrameworkCore;
using PracticaREST.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST
{
    /// <summary>
    /// Creacion de las tablas SQL
    /// </summary>
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
            
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
