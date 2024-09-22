using Microsoft.EntityFrameworkCore;
using TaskHive_HelperService.Models.Data;

namespace TaskHive_HelperService
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<DepartmentDataModel> Departments { get;}
        public DbSet<RoleDataModel> Roles { get;}
    }
}