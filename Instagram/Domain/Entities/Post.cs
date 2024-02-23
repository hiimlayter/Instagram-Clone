namespace Domain.Entities
{
    public class Post
    {
        public long Id { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public int PostStatusId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}