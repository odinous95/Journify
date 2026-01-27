namespace UserManagment.service.commands
{
    public class UserCommand
    {
        public string ExternalIdentifyProvider { get; }
        public string Email { get; }
        public string Username { get; }
        public string Role { get; set; } = "User";

        public UserCommand(string externalIdentifyProvider, string email, string username, string role)
        {
            ExternalIdentifyProvider = externalIdentifyProvider;
            Email = email;
            Username = username;
            Role = role;
        }
    }

}
