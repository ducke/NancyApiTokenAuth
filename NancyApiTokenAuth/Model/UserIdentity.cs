using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApiTokenAuth.Model
{
    /// <summary>
    /// Represents a UserIdentity with a Users Name and Claims.
    /// </summary>
    public class UserIdentity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<ClaimIdentity> Claims { get; set; }
    }
}