using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Infrastructure.Data;
using UserService.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace UserService.Infrastructure.Repository
{
    public class AuditRepository : IAuditRepository
    {
        private readonly UserServiceDbContext _context;
        public AuditRepository(UserServiceDbContext context)
        {
            _context = context;
        }
        public async Task<IList<Domain.Entities.AuditTask>> GetAllAuditsAsync()
        {
            return await _context.AuditTasks.ToListAsync();
        }
        public async Task<Domain.Entities.AuditTask> CreateNewAuditAsync(Domain.Entities.AuditTask createAuditTask)
        {
            var result = await _context.AuditTasks.AddAsync(createAuditTask);
            await  _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Domain.Entities.AuditTask> UpdateAudit(Domain.Entities.AuditTask updateAuditTask)
        {
            var existingAudit = await _context.AuditTasks.FirstOrDefaultAsync(a => a.AuditTaskId == updateAuditTask.AuditTaskId);
            if (existingAudit == null)
            {
                throw new Exception("Audit not found");
            }
            _context.Entry(existingAudit).CurrentValues.SetValues(updateAuditTask);
            await _context.SaveChangesAsync();
            return existingAudit;
        }
        public async Task<Domain.Entities.AuditTask> GetById(int id)
        {
            return await _context.AuditTasks.FirstOrDefaultAsync(a => a.AuditTaskId == id);
        }
    }
}
