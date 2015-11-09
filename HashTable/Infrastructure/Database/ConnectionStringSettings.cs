using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Infrastructure.Database
{
    public class ConnectionStringSettings
    {
        public string ConnectionString { get; set; }
        public string ProviderName { get; set; }
    }
}
