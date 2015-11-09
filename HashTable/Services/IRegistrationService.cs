using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NancyHost.Requests;

namespace NancyHost.Services
{
    public interface IRegistrationService
    {
        void Register(RegisterUserRequest register);
    }
}
