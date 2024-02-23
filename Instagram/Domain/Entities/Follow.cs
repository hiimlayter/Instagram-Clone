using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Follow
    {
        [Key]
        public int FollowingUserId { get; set; }

        [Key]
        public int FollewedUserId { get; set; }

        [Required]
        public DateTime FollowDate { get; set; } = DateTime.Now;

        //Navigation Properties

        [ForeignKey(nameof(FollowingUserId))]
        public ApplicationUser FollowingUser { get; set; }

        [ForeignKey(nameof(FollewedUserId))]
        public ApplicationUser FollowedUser { get; set; }
    }
}