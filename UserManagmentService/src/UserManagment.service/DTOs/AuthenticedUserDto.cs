namespace UserManagment.Service.DTOs
{
    public sealed class AuthenticatedUserDto
    {
        public string ExternalIdentityId { get; }
        public string Email { get; }
        public string Name { get; }
        public string Role { get; }

        public AuthenticatedUserDto(string externalIdentityId, string email, string name, string role)
        {
            ExternalIdentityId = externalIdentityId;
            Email = email;
            Name = name;
            Role = role;
        }
    }
}
