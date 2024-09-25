using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MicroDynamicWebAPI.Domain.Entities
{
    public class DynamicObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string ObjectType { get; set; }
        public required string Data { get; set; }
        public int? ParentId { get; set; }
    }
}
