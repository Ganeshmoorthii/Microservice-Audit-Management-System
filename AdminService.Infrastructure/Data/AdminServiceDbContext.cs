using Microsoft.EntityFrameworkCore;
using AdminService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminService.Infrastructure.Data
{
    public class AdminServiceDbContext : DbContext
    {
        public AdminServiceDbContext(DbContextOptions<AdminServiceDbContext> options) : base(options)
        {
        }
        public DbSet<AuditTask> AuditTasks { get; set; }
    }
}
