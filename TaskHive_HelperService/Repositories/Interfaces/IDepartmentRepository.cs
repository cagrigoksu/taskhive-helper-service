using TaskHive_HelperService.Models.Data;

namespace TaskHive_HelperService.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<DepartmentDataModel> CreateDepartmentAsync(DepartmentDataModel departmentData);
        Task<List<DepartmentDataModel>> GetDepartmentsAsync();
    }
}