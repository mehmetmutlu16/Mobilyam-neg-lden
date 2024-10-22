﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Mobilyaminegolden.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public int CategoryId { get; set; }

        [BsonIgnore]
        public Category Category { get; set; }
    }
}
