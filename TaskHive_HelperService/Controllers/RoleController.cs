using Microsoft.AspNetCore.Mvc;
using TaskHive_HelperService.Models.Data;
using TaskHive_HelperService.Services.Interfaces;

namespace TaskHive_HelperService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController: Controller
    {

        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost("create-role")]
        public async Task<IActionResult> CreateRole(RoleDataModel role)
        {
            var result = await _roleService.CreateRoleAsync(role);
            
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("get-roles")]
        public async Task<IActionResult> GetRolesAsync()
        {
            var result = await _roleService.GetRolesAsync();

            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}