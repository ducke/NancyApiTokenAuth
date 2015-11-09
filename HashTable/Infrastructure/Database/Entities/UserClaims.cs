using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyHost.Infrastructure.Database.Entities
{
    public class UserClaims : Entity
    {
        public string UserId { get; set; }

        public string ClaimId { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format("UserClaim ({0}, UserId: {1}, ClaimId: {2}, Value: {3})", base.ToString(), UserId, ClaimId, Value);
        }
    }
}