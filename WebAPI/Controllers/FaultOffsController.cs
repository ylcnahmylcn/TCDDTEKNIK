using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaultOffsController : ControllerBase
    {
        IFaultOffService _faultoffService;
        public FaultOffsController(IFaultOffService faultoffService)
        {
            _faultoffService = faultoffService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _faultoffService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(FaultOff faultoff)
        {
            var result = _faultoffService.Add(faultoff);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
