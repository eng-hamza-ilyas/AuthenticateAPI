using AuthenticateAPI.Model;
using AuthenticateAPI.Request_Model;

namespace AuthenticateAPI.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginrequest);
    }
}
