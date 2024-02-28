using Financial.Instruments.Api.Domain.Dto.Instrument;
using Financial.Instruments.Api.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;


namespace Financial.Instruments.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class InstrumentController : ControllerBase
    {
        private readonly IInstrumentServices _services;

        public InstrumentController(IInstrumentServices services)
        {
            _services = services;
        }


        [HttpPost]
        public async Task<IActionResult> Get([FromBody] InstrumentGetDto dto)
        {
            var result = await _services.GetCategories(dto);

            if (result != null)
                return Ok(result);

            return BadRequest("not found data.");
        }

    }
}
