using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PostImage
    {
        [Key]
        public long ImageId { get; set; }

        [Key]
        public long PostId { get; set; }

        [Required]
        public int Sequence { get; set; }

        //Navigation Properties

        [ForeignKey(nameof(ImageId))]
        public Image Image { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post Post { get; set; }
    }
}