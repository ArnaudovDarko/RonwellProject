using Microsoft.EntityFrameworkCore;
using RonwellProject.Models;

namespace RonwellProject.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<EmployeeInfo>? Employees { get; set; }

    }
}
