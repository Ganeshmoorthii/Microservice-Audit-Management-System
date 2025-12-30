using AutoMapper;
using UserService.Application.DTOs.Requests;
using UserService.Application.DTOs.Responses;
using UserService.Domain.Entities;

namespace UserService.Application.MappingProfiles
{
    public class AuditProfiles : Profile
    {
        public AuditProfiles()
        {
            CreateMap<AuditTask,CreateAuditTask>();
            CreateMap<CreateAuditTask, AuditTask>();
            CreateMap<AuditTask,ReadAuditTask>();
        }
    }
}
