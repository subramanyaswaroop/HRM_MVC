using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class EmployeeInfo
    {
        [Key]
        public int EmployeeId { get; set; } 
        public string FirstName { get; set; }

        public string MiddleName { get; set; }  
        public string LastName { get; set; }

        public string MMID { get; set; }

        public string Department { get; set; }

        public int Age { get; set; }

    }
}
