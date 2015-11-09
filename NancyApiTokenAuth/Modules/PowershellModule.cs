using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using NancyApiTokenAuth.Infrastructure.Nancy;
using NancyApiTokenAuth.Infrastructure.Authentication;

namespace NancyApiTokenAuth.Modules
{
    public class PowershellModule : SecureModule
    {
        public PowershellModule()
        {
            Get["/admin"] = _ =>
            {
                if (!this.Principal.HasClaim(SampleClaimTypes.Admin))
                {
                    return HttpStatusCode.Forbidden;
                }

                return "Hello Admin!";
            };

            Get["/"] = _ =>
            {
                if (!IsAuthenticated)
                {
                    return HttpStatusCode.Forbidden;
                }

                return "Hello User!";
            };
        }
    }
}
