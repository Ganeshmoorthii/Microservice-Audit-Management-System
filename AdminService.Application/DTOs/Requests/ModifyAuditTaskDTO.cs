using AdminService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminService.Application.DTOs.Requests
{
    public class ModifyAuditTaskDTO
    {
        public int AuditTaskId { get; set; }
        public AuditStatus NewAuditStatus { get; set; }
        public string? AdminRemarks { get; set; }
    }
}
