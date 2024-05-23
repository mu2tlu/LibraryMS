using Application.Features.Reports.Commands.Create;
using Application.Features.Reports.Commands.Delete;
using Application.Features.Reports.Commands.Update;
using Application.Features.Reports.Queries.GetById;
using Application.Features.Reports.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Reports.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Report, CreateReportCommand>().ReverseMap();
        CreateMap<Report, CreatedReportResponse>().ReverseMap();
        CreateMap<Report, UpdateReportCommand>().ReverseMap();
        CreateMap<Report, UpdatedReportResponse>().ReverseMap();
        CreateMap<Report, DeleteReportCommand>().ReverseMap();
        CreateMap<Report, DeletedReportResponse>().ReverseMap();
        CreateMap<Report, GetByIdReportResponse>().ReverseMap();
        CreateMap<Report, GetListReportListItemDto>().ReverseMap();
        CreateMap<IPaginate<Report>, GetListResponse<GetListReportListItemDto>>().ReverseMap();
    }
}