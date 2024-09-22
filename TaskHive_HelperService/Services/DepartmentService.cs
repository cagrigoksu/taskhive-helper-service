using TaskHive_HelperService.Models.Data;
using TaskHive_HelperService.Repositories.Interfaces;
using TaskHive_HelperService.Services.Interfaces;

namespace TaskHive_HelperService.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<DepartmentDataModel> CreateDepartmentAsync(DepartmentDataModel departmentData)
        {
            return await _departmentRepository.CreateDepartmentAsync(departmentData); 
        }
    }
}