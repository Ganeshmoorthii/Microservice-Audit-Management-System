using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminService.Infrastructure.Repository.Interfaces;

public class Repository : IRepository
{
    public Task<IEnumerable<Domain.Entities.AuditTask>> GetAll()
    {
        throw new NotImplementedException();
    }
}
