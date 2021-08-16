namespace blazorwasmretainingsearchconditions.Shared.Models
{
    public class StudentSearchCondition
    {
        public long? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public Gender? Gender { get; set; }

        public string Email { get; set; }
    }
}
