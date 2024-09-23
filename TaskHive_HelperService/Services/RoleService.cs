using TaskHive_HelperService.Models.Data;
using TaskHive_HelperService.Repositories.Interfaces;
using TaskHive_HelperService.Services.Interfaces;

namespace TaskHive_HelperService.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<RoleDataModel> CreateRoleAsync(RoleDataModel roleData)
        {
            return await _roleRepository.CreateRoleAsync(roleData); 
        }

        public async Task<List<RoleDataModel>> GetRolesAsync()
        {
            return await _roleRepository.GetRolesAsync();
        }
    }
}