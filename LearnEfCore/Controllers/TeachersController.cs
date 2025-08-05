using LearnEfCore.Data;
using LearnEfCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearnEfCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public TeachersController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Teacher>> PostAsync(Teacher studentTeacher)
        {
            await this.applicationDbContext.Teachers.AddAsync(studentTeacher);
            await this.applicationDbContext.SaveChangesAsync();

            return Ok(studentTeacher);
        }


        [HttpGet("{teacherId}/students")]
        public async Task<ActionResult<IQueryable>> GetStudentsByTeacherIdAsync(Guid teacherId)
        {
            IQueryable teachers = this.applicationDbContext.StudentTeachers
                .Where(studentTeacher => studentTeacher.TeacherId == teacherId)
                .Include(studentTeacher => studentTeacher.Student)
                .Select(studentTeacher => studentTeacher.Student);

            return Ok(teachers);
        }
    }
}
