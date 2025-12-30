using AdminService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using AdminService.Application.DTOs;

namespace AdminService.Infrastructure.Repository.Interfaces
{
    public interface IRepository
    {
        public Task<IList<AuditTask>> GetAll();
        public Task<AuditTask> GetById(int id);
        public Task<AuditTask> CreateAudit(AuditTask createAuditTask);
        public Task<AuditTask> UpdateAudit(AuditTask updateAuditTask);
    }
}
