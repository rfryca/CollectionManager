using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollectionManager.Web.Api.Data.Entities.Metadata
{
    [Table("CategoryTypes")]    
    public class CategoryType
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(Owner))]
        public string? ApplicationUserId { get; set; } = null;


        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? Owner { get; set; } = null;

        
        [Required]
        [ForeignKey(nameof(CollectionType))]
        public int CollectionTypeId { get; set; }
        [Required]
        [ForeignKey(nameof(CollectionTypeId))]
        public CollectionType CollectionType { get; set; } = null!;


        [ForeignKey("ParentCategoryType")]
        public int? ParentCategoryTypeId { get; set; }
        [ForeignKey(nameof(ParentCategoryTypeId))]       
        public CategoryType ParentCategoryType { get; set; } = null!;
     
        
        [InverseProperty("ParentCategoryType")]
        public IList<CategoryType> SubcategoryTypes { get; set; } = null!;
    }
}
