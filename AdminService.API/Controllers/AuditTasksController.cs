using AdminService.Application.DTOs.Responses;
using AdminService.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdminService.Application.DTOs.Requests;

namespace AdminService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditTasksController : ControllerBase
    {
        //private readonly ILogger<AuditTasksController> _logger;
        private readonly IAuditService _auditService;
        public AuditTasksController(IAuditService auditService)
        {
            //_logger = logger;
            _auditService = auditService;
        }
        [HttpGet]
        public async Task<IEnumerable<ReadAuditTask>> GetAllAudits()
        {
            var audits = await _auditService.GetAllAuditsAsync();
            if(audits == null)
            {
                throw new Exception("No audits found");
            }
            return audits;
        }
        [HttpGet("{id}")]
        public async Task<ReadAuditTask> GetAuditById(int id)
        {
            var audit = await _auditService.GetAuditByIdAsync(id);
            if(audit == null)
            {
                throw new Exception($"No audit found with id: {id}");
            }
            return audit;
        }
        [HttpPut]
        public async Task<IActionResult> CreateNewAudit([FromBody] CreateAuditTaskDTO newAuditTask)
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
