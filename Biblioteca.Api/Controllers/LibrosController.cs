using Biblioteca.Core.DTOs;
using Biblioteca.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Api.Controllers
{
    [ApiController]
    [Route("api/libros")]
    public class LibrosController : ControllerBase
    {
        private readonly ILibroService _libroService;

        public LibrosController(ILibroService libroService)
        {
            _libroService = libroService;
        }


        /// <summary>
        /// Registra un nuevo libro
        /// </summary>
        [HttpPost]
        public IActionResult RegistrarLibro([FromBody] LibroDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _libroService.RegistrarLibro(dto);

            return Ok(new { mensaje = "Libro registrado correctamente" });
        }
    }
}
