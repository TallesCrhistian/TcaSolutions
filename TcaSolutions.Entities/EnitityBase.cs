namespace TcaSolutions.Entities
{
    abstract class EnitityBase
    {
        public Guid Id { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
