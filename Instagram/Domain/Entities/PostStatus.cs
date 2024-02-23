using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class PostStatus
    {
        [Key]
        public int Id { get; set; }

        public string SupportName { get; set; }
    }
}