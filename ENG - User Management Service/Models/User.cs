namespace ENG___User_Management_Service.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; } = true;
    }
}