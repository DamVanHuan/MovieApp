namespace MovieApp.DTOs.Users
{
    public class RegisterUserResponseDTO
    {
        public UserDTO User { get; set; } = null!;
        public string Token { get; set; } = null!;
    }
}
