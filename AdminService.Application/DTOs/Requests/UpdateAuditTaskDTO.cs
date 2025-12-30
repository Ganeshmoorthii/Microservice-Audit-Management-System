using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminService.Domain.Enums;

namespace AdminService.Application.DTOs.Requests
{
    public class UpdateAuditTaskDTO
    {
        public int AuditTaskId { get; set; }
        public AuditStatus AuditStatus { get; set; }
        public string? AdminRemarks { get; set; }
    }
}
