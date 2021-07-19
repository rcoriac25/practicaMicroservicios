using AutoMapper;
using PracticaREST.DTO;
using PracticaREST.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaREST.Utilidades
{
    /// <summary>
    /// Creacion de perfiles de mapeo
    /// </summary>
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AutorDTO, Autor>();
            CreateMap<AutorPutDTO, Autor>();
            CreateMap<LibroDTO, Libro>();
        }
    }
}
