using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.DTOs.Requests;
using UserService.Application.Interfaces;

namespace UserService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditController : ControllerBase
    {
        private readonly IAuditService _auditService;
        public AuditController(IAuditService auditService)
        {
            _auditService = auditService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAudits()
        {
            var audits = await _auditService.GetAllAuditsAsync();
            if (audits == null)
            {
                return NotFound("No audits found");
            }
            return Ok(audits);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNewAudit([FromBody] CreateAuditTask newAuditTask)
        {
            await _auditService.CreateAuditAsync(newAuditTask);
            return Ok("Audit created successfully");
        }
        [HttpPatch("{id}")]
        public async Task<IActionResult> updateAudit([FromRoute] int id, [FromBody] UpdateAuditTaskDTO updateAuditTask)
        {
            if (id != updateAuditTask.AuditTaskId)
            {
                return BadRequest("Audit ID mismatch");
            }
            await _auditService.UpdateAuditAsync(updateAuditTask);
            return Ok("Audit updated successfully");
        }

    }
}
