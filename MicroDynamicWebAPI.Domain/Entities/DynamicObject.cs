namespace MicroDynamicWebAPI.Domain.Entities
{
    public class DynamicObject
    {
        public int Id { get; set; }
        public required string ObjectType { get; set; }
        public required string Data { get; set; }
        public int? ParentId { get; set; }
    }
}
