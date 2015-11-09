using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Infrastructure.Database
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public ConnectionStringSettings GetConnectionString()
        {
            if (ConfigurationManager.ConnectionStrings["UserDB"] != null)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["UserDB"];

                return new ConnectionStringSettings
                {
                    ConnectionString = connectionString.ConnectionString,
                    ProviderName = connectionString.ProviderName
                };
            }

            throw new InvalidOperationException("ConnectionString with Name UserDB was not found");
        }
    }
}
