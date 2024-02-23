using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Post
    {
        [Key]
        public long Id { get; set; }

        public string Body { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int PostStatusId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        //Navigation Properties

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}