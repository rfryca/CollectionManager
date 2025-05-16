using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollectionManager.Web.Api.Data.Entities.Metadata
{
    [Table("CollectionTypes")]  
    public class CollectionType
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public string? Description { get; set; }

        
        [ForeignKey(nameof(Owner))]
        public string? ApplicationUserId { get; set; } = null;

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? Owner { get; set; } = null;

        [InverseProperty("CollectionType")]
        public IList<CategoryType> CategoryTypes { get; set; } = null!;

        [InverseProperty("CollectionType")]
        public IList<ItemType> ItemTypes { get; set; } = null!;


    }
}
