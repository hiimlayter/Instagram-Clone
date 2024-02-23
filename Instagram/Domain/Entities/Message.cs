namespace Domain.Entities
{
    public class Message
    {
        public long Id { get; set; }
        public long ConversationId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public long ImageId { get; set; }
        public int MessageTypeId { get; set; }
        public DateTime SendDate { get; set; }
    }
}