using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EnrollmentService.Controllers;
using EnrollmentService.Models;

namespace Laboratorio_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollment _enrollment;
        public EnrollmentController(IEnrollment ienrollment)
        {
            _enrollment = ienrollment;
        }

        [HttpGet("GetEnrollment")]
        public async Task<IActionResult> GetEnrollment()
        {
            var enrollment = await _enrollment.GetEnrollment();
            
            return Ok(enrollment); 
        }

        [HttpGet("GetEnrollmentDb")]
        public async Task<IActionResult> GetEnrollmentDb()
        {
            try
            {
                var enrollmentaDb = await _enrollment.GetEnrollmentDb();
                return Ok(enrollmentaDb);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateEnrollment")]
        public async Task<IActionResult> CreateEnrollment([FromBody] StudentEnrollmentModel enrollmentInfo)
        {
            try
            {
                var savedEnrollment = await _enrollment.CreateEnrollment(enrollmentInfo);
                return Ok(savedEnrollment);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
