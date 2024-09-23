using TaskHive_HelperService.Models.Data;

namespace TaskHive_HelperService.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task<DepartmentDataModel> CreateDepartmentAsync(DepartmentDataModel departmentData);
        Task<List<DepartmentDataModel>> GetDepartmentsAsync();
    }
}