using NancyApiTokenAuth.Model;
using NancyApiTokenAuth.Infrastructure.Authentication;

namespace NancyApiTokenAuth.Services
{
    public interface IAuthenticationService
    {
        bool TryAuthentifcate(Credentials request, out UserIdentity identity);
    }
}
