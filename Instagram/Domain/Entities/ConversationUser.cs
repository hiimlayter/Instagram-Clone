namespace Domain.Entities
{
    public class ConversationUser
    {
        public int UserId { get; set; }
        public long ConversationId { get; set; }
        public string NickName { get; set; }
        public DateTime AddDate { get; set; }
    }
}