namespace Domain.Entities
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public long ProfilePictureId { get; set; }
    }
}