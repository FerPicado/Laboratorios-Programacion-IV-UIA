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
            
            return Ok(matricula); 
        }

        [HttpGet("miMatriculaDb")]
        public async Task<IActionResult> miMatriculaDb()
        {
            try
            {
                var matriculaDb = await _matricula.miMatriculaDb();
                return Ok(matriculaDb);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
