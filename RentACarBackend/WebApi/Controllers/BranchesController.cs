using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        IBranchService _branchService ;
        public BranchesController(IBranchService branchService)
        {
            _branchService = branchService ;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _branchService.GetAll();
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Branch branch)
        {
            var result = _branchService.Add(branch);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpPost("Update")]
        public IActionResult Update(Branch branch)
        {
            var result = _branchService.Update(branch);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Branch branch)
        {
            var result = _branchService.Delete(branch);
            if (result.Success) return Ok(result);
            return BadRequest(result.Message);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _branchService.GetById(id);
            if (result.Success) return Ok(result);
            return BadRequest(result);
        }



    }
}
