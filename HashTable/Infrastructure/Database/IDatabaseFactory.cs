using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace NancyHost.Infrastructure.Database
{
    public interface IDatabaseFactory
    {
        IDatabase GetDatabase();
    }
}
