namespace ENG___User_Management_Service.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public bool Active { get; set; }
    }
}