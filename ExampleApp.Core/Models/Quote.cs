using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace ExampleApp.Core.Models
{
    public class Quote : BaseMongoObject
    {
        [BsonElement(Fields.Text)]
        public string Text { get; set; }
        [BsonElement(Fields.FirstName)]
        public string FirstName { get; set; }
        [BsonElement(Fields.LastName)]
        public string LastName { get; set; }
        [BsonElement(Fields.Date)]
        public DateTime Date { get; set; }

        public static class Fields
        {
            public const string Text = "t";
            public const string FirstName = "f";
            public const string LastName = "l";
            public const string Date = "d";
        }
    }
}
