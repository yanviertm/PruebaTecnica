using Biblioteca.Core.DTOs;
using Biblioteca.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Api.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutorController : ControllerBase
    {
        private readonly IAutorService _autorService;

        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        /// <summary>
        /// Registra un nuevo autor
        /// </summary>
        [HttpPost]
        public IActionResult RegistrarAutor([FromBody] AutorDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _autorService.RegistrarAutor(dto);

            return Ok(new { mensaje = "Autor registrado correctamente" });
        }

        [HttpGet]
        public IActionResult ObtenerAutores()
        {
            var resultado = _autorService.ObtenerAutores();
            return Ok(resultado);
        }
    }
}
