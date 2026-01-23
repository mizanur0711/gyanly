using Entity;
using Entity.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;

public class CoursesController : BaseController
{
    private readonly ICourseRepository _repository;

    public CoursesController(ICourseRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]

    public async Task<ActionResult<List<Course>>> getCourses()
    {

        var courses =  await _repository.GetCourseAsync();
        return Ok(courses);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Course>> GetCourse(Guid id)
    {
        return await _repository.GetCourseByIdAsync(id);
    }
}