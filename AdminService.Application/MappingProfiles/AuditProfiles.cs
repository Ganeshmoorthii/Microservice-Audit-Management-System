using AdminService.Application.DTOs.Requests;
using AdminService.Application.DTOs.Responses;
using AdminService.Domain.Entities;
using AutoMapper;

namespace AdminService.Application.MappingProfiles
{
    public class AuditProfiles : Profile
    {
        public AuditProfiles() {
            // Mapping for ReadAuditTask.
            CreateMap<AuditTask, ReadAuditTask>();
            //CreateMap<AuditTask, ReadAuditTask>().ReverseMap();
            // Mapping for ModifyAuditTask.
            //CreateMap<UpdateAuditTaskDTO, AuditTask>()
            //    .ForAllMembers(opts => opts.Condition((src, _, srcMember) => srcMember != null));

            CreateMap<AuditTask, CreateAuditTaskDTO>().ReverseMap();
        }
    }
}
