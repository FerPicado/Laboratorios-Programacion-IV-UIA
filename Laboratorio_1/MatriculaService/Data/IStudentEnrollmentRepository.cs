using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EnrollmentService.Models;
using Microsoft.EntityFrameworkCore;


namespace EnrollmentService.Data
{
    public interface IStudentEnrollmentRepository
    {
        Task<IEnumerable<StudentEnrollmentModel>> GetEnrollmentDb();

    }


    public class EnrollmentRepository : IStudentEnrollmentRepository
    {
        private readonly MyDbContext _myDbContext;
        public EnrollmentRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task<IEnumerable<StudentEnrollmentModel>> GetEnrollmentDb()
        {
            return await _myDbContext.StudentEnrollmentModel.ToListAsync(); //(captura de SQL SELECT *
        }

    }
}
