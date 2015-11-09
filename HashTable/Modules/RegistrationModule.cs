using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.ModelBinding;
using NancyHost.Services;
using NancyHost.Requests;

namespace NancyHost.Modules
{
    public class RegistrationModule : NancyModule
    {
        public RegistrationModule(IRegistrationService registrationService)
        {
            Post["/register"] = x =>
            {
                var request = this.Bind<RegisterUserRequest>();

                registrationService.Register(request);

                return Negotiate.WithStatusCode(HttpStatusCode.OK);
            };
        }
    }
}
