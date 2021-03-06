﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco.FluentMappings;
using NancyApiTokenAuth.Infrastructure.Database.Mapping;

namespace NancyApiTokenAuth.Infrastructure.Database
{
    public class MappingProvider : IMappingProvider
    {
        public IMap[] GetMappings()
        {
            return new IMap[] { new UserMapping(), new ClaimMapping(), new UserClaimsMapping() };
        }
    }
}
