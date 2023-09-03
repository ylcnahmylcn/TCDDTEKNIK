using Business.Abstract;
using Core.Business.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaultsController : ControllerBase
    {
        IFaultService _faultService;
        public FaultsController(IFaultService faultService)
        {
                _faultService= faultService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _faultService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetByİd(int id)
        {
            var result = _faultService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyname")]
        public IActionResult GetByName(string name)
        {
            var result = _faultService.Get(name);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Fault fault)
        {
            var result = _faultService.Add(fault);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _faultService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Fault fault)
        {
            var result = _faultService.Update(fault);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getdetaildto")]
        public IActionResult GetDetailDto()
        {
            var result = _faultService.GetFaultDetailDtos();
            if (result.Success)
            {
                return Ok(result);
            }  
            return BadRequest(result);
        }
    }
}
