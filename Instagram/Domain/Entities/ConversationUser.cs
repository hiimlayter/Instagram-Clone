using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ConversationUser
    {
        [Key]
        public int UserId { get; set; }

        [Key]
        public long ConversationId { get; set; }

        public string NickName { get; set; }

        [Required]
        public DateTime AddDate { get; set; } = DateTime.Now;

        //Navigation Properties

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }

        [ForeignKey(nameof(ConversationId))]
        public Conversation Conversation { get; set; }
    }
}