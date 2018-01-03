using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace ExampleApp.Accessors.Infrastructure
{
    public class MongoContext
    {
        private readonly MongoClient _client;
        public readonly IMongoDatabase _database;

        public MongoContext(string connectionString, string databaseName = "ExampleApp")
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);
        }
    }
}
