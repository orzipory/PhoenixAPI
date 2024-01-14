namespace PhoenixAPI.Models
{
    public class LoginRequest
    {
        public LoginRequest()
        {
            this.Username = String.Empty;
            this.Password = String.Empty;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}