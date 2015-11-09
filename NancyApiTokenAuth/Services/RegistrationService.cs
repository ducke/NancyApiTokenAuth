using NancyApiTokenAuth.Infrastructure.Database;
using NancyApiTokenAuth.Infrastructure.Database.Entities;
using NancyApiTokenAuth.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApiTokenAuth.Services
{
    /// <summary>
    /// An Authentication Service to authenticate incoming requests.
    /// </summary>
    public class RegistrationService : BaseService, IRegistrationService
    {
        private readonly ICryptoService cryptoService;

        public RegistrationService(IDatabaseFactory databaseFactory, ICryptoService cryptoService)
            : base(databaseFactory)
        {
            this.cryptoService = cryptoService;
        }

        public void Register(RegisterUserRequest register)
        {
            using (var database = DatabaseFactory.GetDatabase())
            {
                // Let's do this in a transaction, so we cannot register two users
                // with the same name. Seems to be a useful requirement.
                using (var tran = database.GetTransaction())
                {
                    string hashBase64;
                    string saltBase64;

                    cryptoService.CreateHash(register.Password, out hashBase64, out saltBase64);

                    User user = new User()
                    {
                        Name = register.UserName,
                        PasswordHash = hashBase64,
                        PasswordSalt = saltBase64
                    };

                    database.Insert(user);
                    
                    tran.Complete();
                }
            }
        }
    }
}