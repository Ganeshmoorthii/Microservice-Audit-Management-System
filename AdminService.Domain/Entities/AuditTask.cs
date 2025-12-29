using AdminService.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminService.Domain.Entities
{
    public class AuditTask
    {
        [Key]
        public int AuditTaskId { get; set; }
        public string AuditTitle { get; set; } = string.Empty;
        public AuditType AuditType { get; set; }
        public Department Department { get; set; }
        public int AssignedAuditor { get; set; }
        public string TaskDescription { get; set; } = string.Empty;
        public RiskLevel RiskLevel { get; set; }
        public ComplianceStandard ComplianceStandard { get; set; }
        public EvidenceRequired EvidenceRequired { get; set; }
        public DateTime AuditStartDate { get; set; }
        public DateTime AuditEndDate { get; set; }
        public DateTime TargetCompletionDate { get; set; }
        public AuditStatus AuditStatus { get; set; }
        public string? AdminRemarks { get; set; }
        public int RaisedByUserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
