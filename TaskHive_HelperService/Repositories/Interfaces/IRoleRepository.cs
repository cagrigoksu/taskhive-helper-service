using TaskHive_HelperService.Models.Data;

namespace TaskHive_HelperService.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        Task<RoleDataModel> CreateRoleAsync(RoleDataModel roleData);
        Task<List<RoleDataModel>> GetRolesAsync();
    }
}