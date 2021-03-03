
using Microsoft.EntityFrameworkCore;
namespace EmployeeApp.Web.Models
{
    public class EmployeeDBContext :DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) :base(options){

        }
        public DbSet<EmployeeModel> Employee { get; set; }
    }
}