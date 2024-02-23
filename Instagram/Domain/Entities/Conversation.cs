using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Conversation
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        [Required]
        public long LastMessageId { get; set; }

        [Required]
        public long PictureImageId { get; set; }

        [Required]
        public int CreatedByUserId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        //Navigation Properties

        [ForeignKey(nameof(LastMessageId))]
        public Message LastMessage { get; set; }

        [ForeignKey(nameof(PictureImageId))]
        public Image PictureImage { get; set; }

        [ForeignKey(nameof(CreatedByUserId))]
        public ApplicationUser CreatedByUser { get; set; }
    }
}