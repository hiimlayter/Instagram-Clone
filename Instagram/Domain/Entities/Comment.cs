namespace Domain.Entities
{
    public class Comment
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime AddDate { get; set; }
    }
}