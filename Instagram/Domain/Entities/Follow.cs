namespace Domain.Entities
{
    public class Follow
    {
        public int FollowingUserId { get; set; }
        public int FollewedUserId { get; set; }
        public DateTime FollowDate { get; set; }
    }
}