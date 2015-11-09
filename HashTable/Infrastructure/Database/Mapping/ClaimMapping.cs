using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco.FluentMappings;
using NancyHost.Infrastructure.Database.Entities;

namespace NancyHost.Infrastructure.Database.Mapping
{
    public class ClaimMapping : Map<Claim>
    {
        public ClaimMapping()
        {
            PrimaryKey(p => p.Id, autoIncrement: true)
                .TableName("claim")
                .Columns(x =>
                {
                    x.Column(p => p.Id).WithName("claim_id");
                    x.Column(p => p.Type).WithName("type");
                    x.Column(p => p.Value).WithName("value");
                });
        }
    }
}
