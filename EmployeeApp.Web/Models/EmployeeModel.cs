using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Web.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmpId { get; set; }
        [Required(ErrorMessage="Please enter Employe Name.")]
        [Display(Name="Employee Name")]
        public string EmpName { get; set; }
        [Required(ErrorMessage="Please enter Email.")]
        [Display(Name="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage="Please enter Age.")]
        [Display(Name="Age")]
        [Range(26,60)]
        public int Age { get; set; }
        [Required(ErrorMessage="Please enter Employe Salary.")]
        [Display(Name="Employee Salary")]
        public int Salary { get; set; }
    }
}
