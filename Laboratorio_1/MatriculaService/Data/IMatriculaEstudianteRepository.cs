using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MatriculaService.Models;
using Microsoft.EntityFrameworkCore;


namespace MatriculaService.Data
{
    public interface IMatriculaEstudianteRepository
    {
        Task<IEnumerable<MatriculaEstudianteModel>> miMatriculaDb();
    }


    public class MatriculaRepository : IMatriculaEstudianteRepository
    {
        private readonly MyDbContext _myDbContext;
        public MatriculaRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<IEnumerable<MatriculaEstudianteModel>> miMatriculaDb()
        {
            return await _myDbContext.MatriculaEstudianteModel.ToListAsync(); //(captura de SQL SELECT *
        }

    }
}
