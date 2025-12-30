using AdminService.Application.Interfaces;
using AdminService.Infrastructure.Repository.Interfaces;
using AutoMapper;

namespace AdminService.Application.Services
{
    public class AuditService : IAuditService
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public AuditService(IRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IList<DTOs.Responses.ReadAuditTask>> GetAllAuditsAsync()
        {
            var audits = await _repository.GetAll();
            if(audits == null)
            {
                throw new Exception("No audits found");
            }
            var readDTOs = _mapper.Map<IEnumerable<DTOs.Responses.ReadAuditTask>>(audits);
            return (IList<DTOs.Responses.ReadAuditTask>)readDTOs;
        }   
        public async Task<DTOs.Responses.ReadAuditTask> GetAuditByIdAsync(int id)
        {
            var audit = await _repository.GetById(id);
            if(audit == null)
            {
                throw new Exception("Audit not found");
            }
            var readDTO = _mapper.Map<DTOs.Responses.ReadAuditTask>(audit);
            return readDTO;
        }
        public async Task<Domain.Entities.AuditTask> CreateAuditAsync(DTOs.Requests.CreateAuditTaskDTO createAuditTask)
        {
            var createdAudit = _mapper.Map<Domain.Entities.AuditTask>(createAuditTask);
            var newAudit = await _repository.CreateAudit(createdAudit);
            return createdAudit;
        }
        public async Task<Domain.Entities.AuditTask> UpdateAuditAsync(DTOs.Requests.UpdateAuditTaskDTO updateAuditTask)
        {
            if (updateAuditTask == null)
            {
                throw new ArgumentNullException(nameof(updateAuditTask));
            }

            // Load existing entity
            var existing = await _repository.GetById(updateAuditTask.AuditTaskId);
            if (existing == null)
            {
                throw new Exception($"Audit not found with id: {updateAuditTask.AuditTaskId}");
            }

            existing.AuditStatus = updateAuditTask.AuditStatus;
            existing.AdminRemarks = updateAuditTask.AdminRemarks;
            var updated = await _repository.UpdateAudit(existing);
            return updated;
        }
    }
}
