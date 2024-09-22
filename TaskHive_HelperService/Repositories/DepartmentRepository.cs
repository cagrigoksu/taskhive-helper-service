using TaskHive_HelperService.Models.Data;
using TaskHive_HelperService.Repositories.Interfaces;

namespace TaskHive_HelperService.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _db;

        public DepartmentRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<DepartmentDataModel> CreateDepartmentAsync(DepartmentDataModel departmentData)
        {
            try
            {
                departmentData.CreateDate = DateTime.Now;
                departmentData.LastUpdateDate = DateTime.Now;

                _db.Add(departmentData);
                await _db.SaveChangesAsync();

                return departmentData;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}