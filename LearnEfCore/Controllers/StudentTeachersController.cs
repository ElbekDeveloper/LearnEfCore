using LearnEfCore.Data;
using LearnEfCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnEfCore.Controllers
{
    [ApiController]
    [Route("api/student-controllers")]
    public class StudentTeachersController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StudentTeachersController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<StudentTeacher>> PostAsync(StudentTeacher studentTeacher)
        {
            await this.applicationDbContext.StudentTeachers.AddAsync(studentTeacher);
            await this.applicationDbContext.SaveChangesAsync();

            return Ok(studentTeacher);
        }
    }
}
