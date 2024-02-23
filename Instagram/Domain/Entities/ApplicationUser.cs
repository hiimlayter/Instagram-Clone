using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ApplicationUser
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public long ProfilePictureId { get; set; }

        //Navigation Properties

        [ForeignKey(nameof(ProfilePictureId))]
        public Image ProfilePicture { get; set; }
    }
}