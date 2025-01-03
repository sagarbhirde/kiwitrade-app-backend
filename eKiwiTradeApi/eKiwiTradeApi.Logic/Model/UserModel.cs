using System.ComponentModel.DataAnnotations;

namespace eKiwiTradeApi.Logic.Model
{
    public class UserModel
    {
         public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string PhoneNo { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public bool SubscribeNewsletter { get; set; }

        [Required]
        public bool termsAccepted { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime updatedDate { get; set; }

        public string ProfilePictureUrl { get; set; }

        public bool IsEmailVerified { get; set; }
    }
}
