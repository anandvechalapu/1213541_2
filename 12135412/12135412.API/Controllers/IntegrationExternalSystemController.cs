namespace 12135412.API
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using 12135412.DTO;
    using 12135412.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationExternalSystemController : ControllerBase
    {
        private readonly IntegrationExternalSystemService _integrationExternalSystemService;

        public IntegrationExternalSystemController(IntegrationExternalSystemService integrationExternalSystemService)
        {
            _integrationExternalSystemService = integrationExternalSystemService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IntegrationExternalSystemDTO>> GetById(int id)
        {
            var integrationExternalSystem = await _integrationExternalSystemService.GetByIdAsync(id);
            if (integrationExternalSystem == null)
            {
                return NotFound();
            }

            return Ok(integrationExternalSystem);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IntegrationExternalSystemDTO>>> GetAll()
        {
            var integrationExternalSystems = await _integrationExternalSystemService.GetAllAsync();
            return Ok(integrationExternalSystems);
        }

        [HttpPost]
        public async Task<ActionResult<IntegrationExternalSystemDTO>> Add(IntegrationExternalSystemDTO integrationExternalSystemDTO)
        {
            var integrationExternalSystem = await _integrationExternalSystemService.AddAsync(integrationExternalSystemDTO);
            return CreatedAtAction(nameof(GetById), new { id = integrationExternalSystem.Id }, integrationExternalSystem);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<IntegrationExternalSystemDTO>> Update(int id, IntegrationExternalSystemDTO integrationExternalSystemDTO)
        {
            integrationExternalSystemDTO.Id = id;
            var integrationExternalSystem = await _integrationExternalSystemService.UpdateAsync(integrationExternalSystemDTO);
            if (integrationExternalSystem == null)
            {
                return NotFound();
            }

            return Ok(integrationExternalSystem);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _integrationExternalSystemService.DeleteAsync(id);
            return NoContent();
        }
    }
}