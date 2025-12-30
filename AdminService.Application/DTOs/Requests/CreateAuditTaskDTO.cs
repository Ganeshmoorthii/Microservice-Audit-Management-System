using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminService.Domain.Enums;

namespace AdminService.Application.DTOs.Requests
{
    public class CreateAuditTaskDTO
    {
        public string AuditTitle { get; set; } = string.Empty;
        public AuditType AuditType { get; set; }
        public Department Department { get; set; }
        public string TaskDescription { get; set; } = string.Empty;
        public RiskLevel RiskLevel { get; set; }
        public ComplianceStandard ComplianceStandard { get; set; }
        public EvidenceRequired EvidenceRequired { get; set; }
        public DateTime AuditStartDate { get; set; }
        public DateTime AuditEndDate { get; set; }
        public DateTime TargetCompletionDate { get; set; }
    }
}
