using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco.FluentMappings;

namespace NancyApiTokenAuth.Infrastructure.Database
{
    public interface IMappingProvider
    {
        IMap[] GetMappings();
    }
}
