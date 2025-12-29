using AdminService.Application.DTOs.Responses;
using AdminService.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.API.Controllers
{
    [Route("api/[controller]/[Action]")]
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
        //[HttpPut]
    }
}
