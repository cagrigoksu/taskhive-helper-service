using TaskHive_HelperService.Models.Data;

namespace TaskHive_HelperService.Services.Interfaces
{
    public interface IRoleService
    {
        Task<RoleDataModel> CreateRoleAsync(RoleDataModel roleData);
        Task<List<RoleDataModel>> GetRolesAsync();
    }
}