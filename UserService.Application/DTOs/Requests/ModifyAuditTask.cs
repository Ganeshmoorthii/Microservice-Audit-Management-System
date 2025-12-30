using UserService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Application.DTOs.Requests
{
    public class ModifyAuditTask
    {
        public int AuditTaskId { get; set; }
        public AuditStatus NewAuditStatus { get; set; }
        public string? AdminRemarks { get; set; }
    }
}
