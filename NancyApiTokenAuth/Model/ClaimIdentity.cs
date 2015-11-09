using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApiTokenAuth.Model
{
    /// <summary>
    /// Represents a Claim with a Type and a Value.
    /// </summary>
    public class ClaimIdentity
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Value { get; set; }
    }
}
