using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NancyApiTokenAuth.Requests;

namespace NancyApiTokenAuth.Services
{
    public interface IRegistrationService
    {
        void Register(RegisterUserRequest register);
    }
}
