using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Infrastructure.Database
{
    public interface IConnectionStringProvider
    {
        ConnectionStringSettings GetConnectionString();
    }
}
