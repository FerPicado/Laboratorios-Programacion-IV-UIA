using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MatriculaService.Controllers;

namespace Laboratorio_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatricula _matricula;
        public MatriculaController(IMatricula imatricula)
        {
            _matricula = imatricula;
        }

        [HttpGet("GetMatricula")]
        public async Task<IActionResult> GetMatricula()
        {
            var matricula = await _matricula.GetMatricula();
            // usado el _ para no almacenar el valor en una var que no vamos a usar, al final solo lo queremos ver en Postman
            return Ok(matricula); 
        }
    }
}
