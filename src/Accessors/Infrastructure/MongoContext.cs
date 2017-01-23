using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accessors.Infrastructure
{
    public class MongoContext
    {
        private readonly MongoClient _client;
        public readonly IMongoDatabase _database;

        public MongoContext(string connectionString, string databaseName = "dteske")
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);
        }
    }
}
