using Biblioteca.Core.DTOs;
using Biblioteca.Core.Entidades;
using Biblioteca.Core.Excepciones;
using Biblioteca.Core.Interfaces;
using Biblioteca.Infrastructure.Data;
using System;

namespace Biblioteca.Infrastructure.Servicios
{
    public class LibroService : ILibroService
    {
        private const int MAX_LIBROS = 5;
        private readonly ApplicationDbContext _context;
        private readonly IAutorService _autorService;

        public LibroService(ApplicationDbContext context, IAutorService autorService)
        {
            _context = context;
            _autorService = autorService;
        }

        public void RegistrarLibro(LibroDto dto)
        {
            if (!_autorService.ExisteAutor(dto.AutorId))
                throw new AutorNoExisteException();

            var cantidadLibros = _context.Libros.Count();
            if (cantidadLibros >= MAX_LIBROS)
                throw new MaximoLibrosException();

            if (!int.TryParse(dto.Año, out int añoResult))
            {
                throw new BusinessException("El año debe ser un valor numérico.");
            }

            var tituloNormalizado = dto.Titulo.Trim().ToLower();

            if (_context.Libros.Any(l =>
                l.AutorId == dto.AutorId &&
                l.Titulo.ToLower() == tituloNormalizado))
            {
                throw new BusinessException("El libro ya está registrado.");
            }

            var libro = new Libro
            {
                Titulo = dto.Titulo,
                Año = dto.Año,
                Genero = dto.Genero,
                NumeroPaginas = dto.NumeroPaginas,
                AutorId = dto.AutorId
            };

            _context.Libros.Add(libro);
            _context.SaveChanges();
        }
    }
}
