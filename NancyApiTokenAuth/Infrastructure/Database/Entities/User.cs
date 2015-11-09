using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApiTokenAuth.Infrastructure.Database.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public override string ToString()
        {
            return string.Format("User ({0}, Name: {1}, PasswordHash: {2}, PasswordSalt: {3})", base.ToString(), Name, PasswordHash, PasswordSalt);
        }
    }
}
