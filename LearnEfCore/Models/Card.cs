namespace LearnEfCore.Models
{
    public class Card
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTimeOffset ExpireTime { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
