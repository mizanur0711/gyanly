using API.Dto;
using AutoMapper;
using Entity;
using Entity.Interfaces;
using Microsoft.AspNetCore.Mvc; 

namespace API.Controller;

public class CoursesController : BaseController
{
    private readonly ICourseRepository _repository;
    private readonly IMapper _mapper;

    public CoursesController(ICourseRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<CourseDto>>> GetCourses()
    {
        var courses = await _repository.GetCoursesAsync();
        return Ok(_mapper
            .Map<IReadOnlyList<Course>, IReadOnlyList<CourseDto>>(courses));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CourseDto>> GetCourse(Guid id)
    {
        var course = await _repository.GetCourseByIdAsync(id);

        return _mapper.Map<Course, CourseDto>(course);
    }
}