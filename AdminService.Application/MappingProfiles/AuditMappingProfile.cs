using AdminService.Application.DTOs.Requests;
using AdminService.Application.DTOs.Responses;
using AdminService.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminService.Application.MappingProfiles
{
    public class AuditMappingProfile : Profile
    {
        public AuditMappingProfile() {
            // Mapping for ReadAuditTask.
            CreateMap<AuditTask, ReadAuditTask>();
            // Mapping for ModifyAuditTask.
            CreateMap<AuditTask, ModifyAuditTask>(); 
        }
    }
}
