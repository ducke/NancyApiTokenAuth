using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco.FluentMappings;
using NancyApiTokenAuth.Infrastructure.Database.Entities;

namespace NancyApiTokenAuth.Infrastructure.Database.Mapping
{
    public class UserClaimsMapping : Map<UserClaims>
    {
        public UserClaimsMapping()
        {
            PrimaryKey(p => p.Id, autoIncrement: true)
                .TableName("user_claim")
                .Columns(x =>
                {
                    x.Column(p => p.Id).WithName("user_claim_id");
                    x.Column(p => p.UserId).WithName("user_id");
                    x.Column(p => p.ClaimId).WithName("claim_id");
                });
        }
    }
}
