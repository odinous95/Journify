namespace UserManagment.service.commands
{
    public sealed record ProvisionUserCommand(
       string AuthSub,
       string Username,
       string Email,
       bool EmailVerified
   );
}