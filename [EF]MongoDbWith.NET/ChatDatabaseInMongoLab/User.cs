using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChatDatabaseInMongoLab
{
    class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Username { get; set; }
    }
}