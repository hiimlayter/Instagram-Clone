namespace Domain.Entities
{
    public class Like
    {
        public long PostId { get; set; }
        public int UserId { get; set; }
        public DateTime LikeDate { get; set; }
    }
}