using Microsoft.EntityFrameworkCore;
using TaskHive_HelperService.Models.Data;
using TaskHive_HelperService.Repositories.Interfaces;

namespace TaskHive_HelperService.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _db;

        public RoleRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<RoleDataModel> CreateRoleAsync(RoleDataModel roleData)
        {
            try
            {
                roleData.CreateDate = DateTime.Now;
                roleData.LastUpdateDate = DateTime.Now;

                _db.Add(roleData);
                await _db.SaveChangesAsync();

                return roleData;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public async Task<List<RoleDataModel>> GetRolesAsync()
        {
            try
            {
                var roles = await _db.Roles.ToListAsync();   
                return roles;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}