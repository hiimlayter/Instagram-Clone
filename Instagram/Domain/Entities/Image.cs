using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Filename { get; set; }

        [Required]
        public string Content { get; set; }
    }
}