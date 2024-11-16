using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaService.Models
{
    public class MatriculaEstudianteModel
    {
        [Key] public int IdEstudiante { get; set; }
        public int IdMatricula { get; set; }
        public bool CupoDisponible { get; set; }
        public string EstadoMatricula { get; set; }
        public DateTime FechaMatricula { get; set; }

    }

}
