using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Like
    {
        [Key]
        public long PostId { get; set; }

        [Key]
        public int UserId { get; set; }

        [Required]
        public DateTime LikeDate { get; set; } = DateTime.Now;

        //Navigation Properties

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}