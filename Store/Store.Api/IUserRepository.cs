namespace Store.Api
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
    }

    public class LoginRequestDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class LoginResponseDTO
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
    public class UserDTO
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
    }

    public class RegisterationRequestDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
