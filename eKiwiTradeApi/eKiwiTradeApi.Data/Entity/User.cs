using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace eKiwiTradeApi.Logic.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("fullName")]
        public string? FullName { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("phoneNo")]
        public string? PhoneNo { get; set; }

        [BsonElement("passwordHash")]
        public string? PasswordHash { get; set; }

        [BsonElement("subscribeNewsletter")]
        public bool SubscribeNewsletter { get; set; }

        [BsonElement("termsAccepted")]
        public bool termsAccepted { get; set; }

        [BsonElement("isActive")]
        public bool IsActive { get; set; }

        [BsonElement("createdDate")]
        public DateTime CreatedDate { get; set; }

        [BsonElement("updatedDate")]
        public DateTime updatedDate { get; set; }

        [BsonElement("profilePictureUrl")]
        public string? ProfilePictureUrl { get; set; }

        [BsonElement("isEmailVerified ")]
        public bool IsEmailVerified { get; set; }
    }
}
