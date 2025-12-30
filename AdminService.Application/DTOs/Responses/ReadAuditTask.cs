using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminService.Domain.Enums;

namespace AdminService.Application.DTOs.Responses
{
    public class ReadAuditTask
    {
        public int AuditTaskId { get; set; }
        public string AuditTitle { get; set; }
        public AuditType AuditType { get; set; }
        public Department Department { get; set; }
        public RiskLevel RiskLevel { get; set; }
        public AuditStatus AuditStatus { get; set; }
        public DateTime AuditStartDate { get; set; }
        public DateTime AuditEndDate { get; set; }
        public DateTime TargetCompletionDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public int RaisedByUserId { get; set; }
    }
}
