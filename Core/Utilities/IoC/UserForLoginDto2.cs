using Core.Entities;

namespace Entities.DTOs
{
    public class UserForLoginDto2 : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
