using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entidades;
using Biblioteca.Core.Excepciones;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Biblioteca.Infrastructure.Servicios
{
    public class AutorService : IAutorService
    {
        private readonly ApplicationDbContext _context;

        public AutorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void RegistrarAutor(AutorDto dto)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(dto.CorreoElectronico, pattern))
            {
                throw new BusinessException("Correo electrónico no es válido.");
            }

            if (_context.Autores.Any(a => a.CorreoElectronico == dto.CorreoElectronico))
            {
                throw new BusinessException("El autor ya está registrado.");
            }

            var autor = new Autor
            {
                NombreCompleto = dto.NombreCompleto,
                FechaNacimiento = dto.FechaNacimiento,
                CiudadProcedencia = dto.CiudadProcedencia,
                CorreoElectronico = dto.CorreoElectronico
            };

            _context.Autores.Add(autor);
            _context.SaveChanges();
        }

        public bool ExisteAutor(int autorId)
        {
            return _context.Autores.Any(a => a.Id == autorId);
        }

        public IEnumerable<Autor> ObtenerAutores()
        {
            return _context.Autores
                .Include(a => a.Libros)
                .Select(a => new Autor
                {
                    Id = a.Id,
                    NombreCompleto = a.NombreCompleto,
                    FechaNacimiento = a.FechaNacimiento,
                    CiudadProcedencia = a.CiudadProcedencia,
                    CorreoElectronico = a.CorreoElectronico,
                    Libros = a.Libros.Select(l => new Libro
                    {
                        Id = l.Id,
                        Titulo = l.Titulo,
                        Año = l.Año,
                        Genero = l.Genero,
                        NumeroPaginas = l.NumeroPaginas,
                        AutorId = l.AutorId
                    }).ToList()
                })
                .ToList();
        }
    }
}
