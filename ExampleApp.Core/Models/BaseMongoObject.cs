using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExampleApp.Core.Models
{
    public abstract class BaseMongoObject : IBaseMongoObject
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
