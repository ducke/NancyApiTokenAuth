﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;
using NPoco.FluentMappings;

namespace NancyHost.Infrastructure.Database
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private NPoco.DatabaseFactory databaseFactory;

        public DatabaseFactory(IConnectionStringProvider connectionStringProvider, IMappingProvider mappingProvider)
        {
            DatabaseFactoryConfigOptions options = new DatabaseFactoryConfigOptions();

            var connectionString = connectionStringProvider.GetConnectionString();
            var mappings = mappingProvider.GetMappings();

            options.Database = () => new LoggingDatabase(connectionString);
            options.PocoDataFactory = FluentMappingConfiguration.Configure(mappings);

            databaseFactory = new NPoco.DatabaseFactory(options);
        }

        public IDatabase GetDatabase()
        {
            return databaseFactory.GetDatabase();
        }
    }
}
