using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain.Enums;

namespace UserService.Application.DTOs.Responses
{
    public class ReadAuditTask
    {
        public int AuditTaskId { get; set; }
        public int AuditTitle { get; set; }
        public AuditType AuditType { get; set; }
        public Department Department { get; set; }
        public RiskLevel RiskLevel { get; set; }
        public AuditStatus AuditStatus { get; set; }
        public DateTime AuditStartDate { get; set; }
        public DateTime AuditEndDate { get; set; }
        public DateTime TargetCompletionDate { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
