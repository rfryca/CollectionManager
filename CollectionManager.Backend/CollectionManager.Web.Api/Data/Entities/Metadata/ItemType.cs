using System.ComponentModel.DataAnnotations.Schema;

namespace CollectionManager.Web.Api.Data.Entities.Metadata
{
    [Table("ItemTypes")]
    public class ItemType
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(Owner))]
        public string? ApplicationUserId { get; set; } = null;

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? Owner { get; set; } = null;
        [ForeignKey(nameof(CollectionType))]
        public int? CollectionTypeId { get; set; }
        [ForeignKey(nameof(CollectionTypeId))]
        public CollectionType CollectionType { get; set; } = null!;
    }
}
