using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Services
{
    public class ApplicationSettings : IApplicationSettings
    {
        public string NancyBasePath
        {
            get { return "/api"; }
        }

        public string TokenEndpointBasePath
        {
            get { return "/token"; }
        }

        public int SaltSize
        {
            get { return 13; }
        }
    }
}
