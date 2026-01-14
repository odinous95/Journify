namespace UserManagment.service.commands
{
    public class CreateUserCommand
    {
        public string Email { get; }
        public string Password { get; }

        public CreateUserCommand(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }

}
