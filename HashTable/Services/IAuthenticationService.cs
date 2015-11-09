using NancyHost.Model;
using NancyHost.Infrastructure.Authentication;

namespace NancyHost.Services
{
    public interface IAuthenticationService
    {
        bool TryAuthentifcate(Credentials request, out UserIdentity identity);
    }
}
