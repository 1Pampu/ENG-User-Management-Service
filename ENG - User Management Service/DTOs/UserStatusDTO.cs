using System.ComponentModel.DataAnnotations;

namespace ENG___User_Management_Service.DTOs
{
    public class UserStatusDTO
    {
        [Required(ErrorMessage = "Active field is required")]
        public bool Active { get; set; }
    }
}
