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
        public Task<IEnumerable<AuditTask>> GetAll();
        //public Task<DTOs.Responses.ReadAuditTask> GetById(int id);
    }
}
