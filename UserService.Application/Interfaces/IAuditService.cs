using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain.Entities;

namespace UserService.Application.Interfaces
{
    public interface IAuditService
    {
        public Task<IList<DTOs.Responses.ReadAuditTask>> GetAllAuditsAsync();
        public Task<AuditTask> CreateAuditAsync(DTOs.Requests.CreateAuditTask createAuditTask);
        public Task<AuditTask> UpdateAuditAsync(DTOs.Requests.UpdateAuditTaskDTO updateAuditTask);
    }
}
