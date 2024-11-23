using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentService.Models
{
    public class StudentEnrollmentModel
    {
        [Key] public int StudentId { get; set; }
        public int EnrollmentId { get; set; }
        public bool IsSlotAvailable { get; set; }
        public string EnrollmentStatus { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
}
