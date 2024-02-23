namespace Domain.Entities
{
    public class Conversation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long LastMessageId { get; set; }
        public long PictureImageId { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}