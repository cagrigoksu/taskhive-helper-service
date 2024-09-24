using Microsoft.AspNetCore.Mvc;
using TaskHive_HelperService.Models.Data;
using TaskHive_HelperService.Services.Interfaces;

namespace TaskHive_HelperService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController: Controller
    {

        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost("create-department")]
        public async Task<IActionResult> CreateDepartment(DepartmentDataModel department)
        {
            var result = await _departmentService.CreateDepartmentAsync(department);
            
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet("get-departments")]
        public async Task<IActionResult> GetDepartmentsAsync()
        {
            var result = await _departmentService.GetDepartmentsAsync();

            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}