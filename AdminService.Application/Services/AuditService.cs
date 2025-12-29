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
        public Task<IEnumerable<DTOs.Responses.ReadAuditTask>> GetAllAuditsAsync()
        {
            var audits = _repository.GetAll();
            if(audits == null)
            {
                throw new Exception("No audits found");
            }
            var readDTOs = _mapper.Map<IEnumerable<DTOs.Responses.ReadAuditTask>>(audits);
            return Task.FromResult(readDTOs);
        }
        public Task<DTOs.Responses.ReadAuditTask> GetAuditByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
