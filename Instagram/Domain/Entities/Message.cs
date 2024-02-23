using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Message
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long ConversationId { get; set; }

        [Required]
        public int UserId { get; set; }

        public string Content { get; set; }
        public long ImageId { get; set; }

        [Required]
        public int MessageTypeId { get; set; }

        [Required]
        public DateTime SendDate { get; set; } = DateTime.UtcNow;

        //Navigation Properties

        [ForeignKey(nameof(ConversationId))]
        public Conversation Conversation { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        [ForeignKey(nameof(ImageId))]
        public Image Image { get; set; }
    }
}