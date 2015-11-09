using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco.FluentMappings;
using NancyApiTokenAuth.Infrastructure.Database.Entities;

namespace NancyApiTokenAuth.Infrastructure.Database.Mapping
{
    public class UserMapping : Map<User>
    {
        public UserMapping()
        {
            PrimaryKey(p => p.Id, autoIncrement: true)
                .TableName("user")
                .Columns(x =>
                {
                    x.Column(p => p.Id).WithName("user_id");
                    x.Column(p => p.Name).WithName("name");
                    x.Column(p => p.PasswordHash).WithName("password_hash");
                    x.Column(p => p.PasswordSalt).WithName("password_salt");
                });
        }
    }
}
