using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminService.Application.Interfaces
{
    public interface IAuditService
    {
        public Task<IEnumerable<DTOs.Responses.ReadAuditTask>> GetAllAuditsAsync();
        public Task<DTOs.Responses.ReadAuditTask> GetAuditByIdAsync(int id);
    }
}
