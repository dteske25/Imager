using System;
using System.Collections.Generic;
using System.Text;
using ExampleApp.Accessors.Infrastructure;
using ExampleApp.Core.Accessors;
using ExampleApp.Core.Models;
using MongoDB.Driver;

namespace ExampleApp.Accessors
{
    public class QuoteAccessor : MongoAccessor<Quote>, IQuoteAccessor
    {
        public QuoteAccessor(MongoContext context) : base(context)
        {
            // Create any special indexes here
            _collection.Indexes.CreateOne(Builders<Quote>.IndexKeys.Ascending(f => f.FirstName).Ascending(f => f.LastName));
        }
    }
}
