namespace Students.Models.Entities
{
    public class Student
    {
        
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string  email { get; set; }

        public int PhoneNumber { get; set; }
        public bool Subscribe { get; set; }
    }
}
