namespace UserManagment.api.DTOS
{
    public sealed class AuthenticatedUserDTO
    {
        public string Sub { get; init; } = default!;
        public string Email { get; init; } = default!;
        public string Name { get; init; } = default!;
        public bool EmailVerified { get; init; }
        public AuthenticatedUserDTO(string sub, string name, string email, bool emailVerified)
        {
            Sub = sub;
            Name = name;
            Email = email;
            EmailVerified = emailVerified;
        }
    }
}