namespace Domain.Entities
{
    public class PostImage
    {
        public long ImageId { get; set; }
        public long PostId { get; set; }
        public int Sequence { get; set; }
    }
}