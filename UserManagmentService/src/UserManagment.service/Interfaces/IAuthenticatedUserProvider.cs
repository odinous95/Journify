
using UserManagment.Service.DTOs;

namespace UserManagment.service.Interfaces
{
    public interface IAuthenticatedUserProvider
    {
        AuthenticatedUserDto GetCurrentUser();
    }
}
