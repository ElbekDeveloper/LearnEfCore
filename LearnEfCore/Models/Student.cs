namespace LearnEfCore.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }

        public virtual StudentAdditionalDetail StudentAdditionalDetail { get; set; }

        public virtual ICollection<Card> Card { get; set; }
        public virtual ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}
