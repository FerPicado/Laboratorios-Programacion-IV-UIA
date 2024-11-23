using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentService.Models;
using EnrollmentService.Data;
using System.Runtime.InteropServices.Marshalling;


namespace EnrollmentService.Controllers
{
    public interface IEnrollment
    {
        Task<StudentEnrollmentModel> GetEnrollment();
        Task<IEnumerable<StudentEnrollmentModel>> GetEnrollmentDb();

        Task<object> CreateEnrollment(StudentEnrollmentModel enrollmentInfo);
    }

    public class EnrollmentSystem : IEnrollment
    {
        private readonly IStudentEnrollmentRepository _repository;
        public EnrollmentSystem(IStudentEnrollmentRepository repository) 
        {
            _repository = repository;
        }
        public async Task<StudentEnrollmentModel> GetEnrollment()
        {
            StudentEnrollmentModel enrollmentModel = new StudentEnrollmentModel();
            enrollmentModel.EnrollmentDate = DateTime.Now;
            enrollmentModel.IsSlotAvailable = true;
            enrollmentModel.EnrollmentStatus = "Activo";
            enrollmentModel.EnrollmentId = 1;
            enrollmentModel.StudentId = 1;
            return enrollmentModel;
        }

        public async Task<IEnumerable<StudentEnrollmentModel>> GetEnrollmentDb()
        {
            return await _repository.GetEnrollmentDb();
        }

        public async Task<object> CreateEnrollment(StudentEnrollmentModel enrollmentInfo)
        {
            return new
            {
                msg = $"Enrollment {enrollmentInfo.EnrollmentId} created successfully.",
                details = new
                {
                    enrollmentInfo.IsSlotAvailable,
                    enrollmentInfo.EnrollmentDate,
                    enrollmentInfo.EnrollmentStatus,
                    enrollmentInfo.StudentId,
                    enrollmentInfo.EnrollmentId
                }
            };
        }
    }
}
