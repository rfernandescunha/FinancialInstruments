using Financial.Instruments.Api.Domain.Dto.Instrument;
using Financial.Instruments.Api.Domain.Dto.InstrumentCategories;
using Financial.Instruments.Api.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Financial.Instruments.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class InstrumentCategoriesController : ControllerBase
    {
        private readonly IInstrumentCategoriesServices _services;

        public InstrumentCategoriesController(IInstrumentCategoriesServices services)
        {
            _services = services;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _services.Find(id);

            if (result != null)
                return Ok(result);

            return BadRequest("not found data.");
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _services.Find();

            return Ok(result);
        }

        [HttpGet("GetInstrumentCategories")]
        public async Task<IActionResult> GetInstrumentCategories([FromQuery] IEnumerable<InstrumentDto> dto)
        {
            var result = await _services.Find();

            if (result != null)
                return Ok(result);

            return BadRequest("not found data.");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InstrumentCategoriesPostDto dto)
        {
            if (dto == null) return BadRequest("data required.");

            var result = await _services.Insert(dto);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] InstrumentCategoriesUpdateDto dto)
        {
            if (dto == null) return BadRequest("data required.");

            var result = await _services.Update(dto);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _services.Delete(id);

            return Ok(result);
        }
    }
}
