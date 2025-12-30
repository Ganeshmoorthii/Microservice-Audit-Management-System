using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Application.Interfaces;
using UserService.Domain.Entities;
using UserService.Infrastructure.Repository.Interfaces;

namespace UserService.Application.Services
{
    public class AuditService : IAuditService
    {
        private readonly IAuditRepository _auditRepository;
        private readonly IMapper _mapper;
        public AuditService(IAuditRepository auditRepository,IMapper mapper)
        {
            _auditRepository = auditRepository;
            _mapper = mapper;
        }
        public async Task<IList<DTOs.Responses.ReadAuditTask>> GetAllAuditsAsync()
        {
            var audits = await _auditRepository.GetAllAuditsAsync();
            if(audits == null)
            {
                throw new Exception("No audits found");
            }
            var auditDTOs = _mapper.Map<IEnumerable<DTOs.Responses.ReadAuditTask>>(audits);
            return (IList<DTOs.Responses.ReadAuditTask>)auditDTOs;
        }
        public async Task<AuditTask> CreateAuditAsync(DTOs.Requests.CreateAuditTask createAuditTask)
        {
            var createdAudit = _mapper.Map<AuditTask>(createAuditTask);
            var newAudit = await _auditRepository.CreateNewAuditAsync(createdAudit);
            if (newAudit == null)
            {
                throw new Exception("Failed to create audit");
            }
            return newAudit;
        }
        public async Task<Domain.Entities.AuditTask> UpdateAuditAsync(DTOs.Requests.UpdateAuditTaskDTO updateAuditTask)
        {
            if (updateAuditTask == null)
            {
                throw new ArgumentNullException(nameof(updateAuditTask));
            }

            // Load existing entity
            var existing = await _auditRepository.GetById(updateAuditTask.AuditTaskId);
            if (existing == null)
            {
                throw new Exception($"Audit not found with id: {updateAuditTask.AuditTaskId}");
            }

            existing.AuditStatus = updateAuditTask.AuditStatus;
            existing.AdminRemarks = updateAuditTask.AdminRemarks;
            var updated = await _auditRepository.UpdateAudit(existing);
            return updated;
        }
    }
}
