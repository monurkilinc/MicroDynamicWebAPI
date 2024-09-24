namespace MicroDynamicWebAPI.Entities
{
    public class DynamicObject
    {
        public int Id { get; set; }
        public string ObjectType { get; set; }
        public string Data { get; set; }
        public int? ParentId { get; set; }
    }
}
