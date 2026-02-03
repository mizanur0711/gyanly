using API.Dto;
using AutoMapper;
using Entity;

namespace API.Helpers;

public class MappingProfiles : Profile
{
    protected MappingProfiles()
    {
        CreateMap<Course, CourseDto>()
            .ForMember(c => c.Category,
                o => o.MapFrom(s => s.Category.Name));

        CreateMap<Learning, LearningDto>();

        CreateMap<Requirement, RequirementDto>();

        CreateMap<Category, CategoryDto>();

        CreateMap<Category, CategoriesDto>();
    }
}