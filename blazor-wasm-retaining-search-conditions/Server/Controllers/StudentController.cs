using System.Collections.Generic;
using System.Threading.Tasks;
using blazorwasmretainingsearchconditions.Server.Data;
using blazorwasmretainingsearchconditions.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using blazorwasmretainingsearchconditions.Shared.Models;

namespace blazorwasmretainingsearchconditions.Server.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;

        public StudentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents([FromQuery] long? id,
                                                                          [FromQuery] string firstName,
                                                                          [FromQuery] string lastName,
                                                                          [FromQuery] int? age,
                                                                          [FromQuery] Gender? gender,
                                                                          [FromQuery] string email)
        {
            var result = await _context.Students
                .WhereIf(id != null, x => x.Id == id)
                .WhereIf(!string.IsNullOrWhiteSpace(firstName), x => x.FirstName.Contains(firstName))
                .WhereIf(!string.IsNullOrWhiteSpace(lastName), x => x.LastName.Contains(lastName))
                .WhereIf(age != null, x => x.Age == age)
                .WhereIf(gender != null, x => x.Gender == gender)
                .WhereIf(!string.IsNullOrWhiteSpace(email), x => x.Email.Contains(email))
                .ToListAsync();

            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(long id)
        {
            Student student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }
    }
}