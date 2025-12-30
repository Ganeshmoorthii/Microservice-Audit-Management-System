using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain.Entities;

namespace UserService.Infrastructure.Repository.Interfaces
{
    public interface IAuditRepository
    {
        public Task<IList<AuditTask>> GetAllAuditsAsync();
        public Task<AuditTask> CreateNewAuditAsync(AuditTask createAuditTask);
        public Task<AuditTask> UpdateAudit(AuditTask updateAuditTask);
        public Task<AuditTask> GetById(int id);
    }
}
