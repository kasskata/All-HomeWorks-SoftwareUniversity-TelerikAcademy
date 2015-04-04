using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ChatDatabaseInMongoLab
{
    class Message
    {
      
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Text { get; set; }

        public DateTime Time { get; set; }

        public string UserName { get; set; }

        public override string ToString()
        {
            return string.Format("{1}, {2}", this.Id, this.Text, this.Time);
        }
    }
}