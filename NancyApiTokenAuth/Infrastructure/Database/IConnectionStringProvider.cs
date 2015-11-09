using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApiTokenAuth.Infrastructure.Database
{
    public interface IConnectionStringProvider
    {
        ConnectionStringSettings GetConnectionString();
    }
}
