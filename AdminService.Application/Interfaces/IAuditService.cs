using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminService.Application.Interfaces
{
    public interface IAuditService
    {
        public Task<IList<DTOs.Responses.ReadAuditTask>> GetAllAuditsAsync();
        public Task<DTOs.Responses.ReadAuditTask> GetAuditByIdAsync(int id);
        public Task<Domain.Entities.AuditTask> CreateAuditAsync(DTOs.Requests.CreateAuditTaskDTO createAuditTask);
        public Task<Domain.Entities.AuditTask> UpdateAuditAsync(DTOs.Requests.UpdateAuditTaskDTO updateAuditTask);
    }
}
