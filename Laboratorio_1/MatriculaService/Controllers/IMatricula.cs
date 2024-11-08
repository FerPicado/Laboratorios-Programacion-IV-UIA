using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaService.Models;

namespace MatriculaService.Controllers
{
    public interface IMatricula
    {
        Task<MatriculaModel> GetMatricula();
    }

    public class MatriculaSystem() : IMatricula
    {
        public async Task<MatriculaModel> GetMatricula()
        {
            MatriculaModel matriculaModel = new MatriculaModel();
            matriculaModel.MatriculaEstudiante = "Maths";
            matriculaModel.CupoDisponible = true;
            return matriculaModel;
        }
    }
}
